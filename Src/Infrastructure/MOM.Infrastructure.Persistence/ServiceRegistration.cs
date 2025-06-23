using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MOM.Application.Interfaces;
using MOM.Application.Interfaces.Repositories;
using MOM.Infrastructure.Persistence.Contexts;
using MOM.Infrastructure.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MOM.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration, bool useInMemoryDatabase)
        {
            if (useInMemoryDatabase)
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseInMemoryDatabase(nameof(ApplicationDbContext)));
            }
            else
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            }

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.RegisterRepositories();

            return services;
        }

        /// <summary>
        /// 注册所有仓储相关服务
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            // 1. 注册开放泛型仓储（基础仓储）
            RegisterOpenGenericRepositories(services);

            // 2. 注册具体的仓储实现
            RegisterConcreteRepositories(services);

            // 3. 注册关系仓储
            RegisterRelationshipRepositories(services);

            return services;
        }

        /// <summary>
        /// 注册开放泛型仓储
        /// </summary>
        private static void RegisterOpenGenericRepositories(IServiceCollection services)
        {
            // 注册基础泛型仓储
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            // 注册关系泛型仓储
            services.AddScoped(typeof(IRelationshipRepository<,,>), typeof(RelationshipRepository<,,>));
        }

        /// <summary>
        /// 注册具体的仓储实现（非关系仓储）
        /// </summary>
        private static void RegisterConcreteRepositories(IServiceCollection services)
        {
            var interfaceAssembly = Assembly.GetAssembly(typeof(IGenericRepository<>))!;
            var implementationAssembly = Assembly.GetAssembly(typeof(GenericRepository<>))!;

            // 获取所有具体的仓储接口（继承自IGenericRepository<T>但不是关系仓储）
            var concreteInterfaces = interfaceAssembly.GetTypes()
                .Where(t => t.IsInterface &&
                           !t.IsGenericTypeDefinition &&
                           !IsRelationshipRepository(t) && // 排除关系仓储接口
                           InheritsFromGenericRepository(t))
                .ToList();

            // 获取所有具体的仓储实现类
            var concreteImplementations = implementationAssembly.GetTypes()
                .Where(t => t.IsClass &&
                           !t.IsAbstract &&
                           !t.IsGenericTypeDefinition &&
                           !IsRelationshipRepositoryImplementation(t) && // 排除关系仓储实现
                           InheritsFromGenericRepositoryClass(t))
                .ToList();

            // 匹配并注册接口和实现
            foreach (var interfaceType in concreteInterfaces)
            {
                var implementation = FindMatchingImplementation(interfaceType, concreteImplementations);
                if (implementation != null)
                {
                    services.AddScoped(interfaceType, implementation);
                }
            }
        }

        /// <summary>
        /// 注册关系仓储
        /// </summary>
        private static void RegisterRelationshipRepositories(IServiceCollection services)
        {
            // 获取包含关系仓储的程序集
            var assemblies = GetRepositoryAssemblies();

            foreach (var assembly in assemblies)
            {
                RegisterRelationshipRepositoriesFromAssembly(services, assembly);
            }
        }

        /// <summary>
        /// 从指定程序集注册关系仓储
        /// </summary>
        private static void RegisterRelationshipRepositoriesFromAssembly(IServiceCollection services, Assembly assembly)
        {
            var relationshipRepositoryType = typeof(RelationshipRepository<,,>);

            // 获取所有关系仓储实现类
            var repositoryImplementations = assembly.GetTypes()
                .Where(t => t.IsClass &&
                           !t.IsAbstract &&
                           !t.IsGenericTypeDefinition &&
                           IsSubclassOfOpenGeneric(t, relationshipRepositoryType))
                .ToList();

            foreach (var implementation in repositoryImplementations)
            {
                // 找到对应的具体接口
                var matchingInterface = FindRelationshipRepositoryInterface(implementation);

                if (matchingInterface != null)
                {
                    services.AddScoped(matchingInterface, implementation);
                }
            }
        }

        #region 辅助方法

        /// <summary>
        /// 获取所有包含仓储的程序集
        /// </summary>
        private static Assembly[] GetRepositoryAssemblies()
        {
            var assemblies = new List<Assembly>();

            // 添加基础仓储程序集
            var baseAssembly = Assembly.GetAssembly(typeof(IGenericRepository<>));
            if (baseAssembly != null)
                assemblies.Add(baseAssembly);

            // 添加实现程序集
            var implAssembly = Assembly.GetAssembly(typeof(GenericRepository<>));
            if (implAssembly != null)
                assemblies.Add(implAssembly);

            // 尝试添加关系仓储程序集（如果存在）
            try
            {
                var relationshipAssembly = Assembly.GetAssembly(typeof(HierarchyScopeContainsRelationshipRepository));
                if (relationshipAssembly != null)
                    assemblies.Add(relationshipAssembly);
            }
            catch
            {
                // 如果类型不存在，忽略
            }

            return assemblies.Distinct().ToArray();
        }

        /// <summary>
        /// 检查类型是否继承自IGenericRepository<T>
        /// </summary>
        private static bool InheritsFromGenericRepository(Type type)
        {
            return type.GetInterfaces().Any(i =>
                i.IsGenericType &&
                i.GetGenericTypeDefinition() == typeof(IGenericRepository<>));
        }

        /// <summary>
        /// 检查类型是否继承自GenericRepository<T>
        /// </summary>
        private static bool InheritsFromGenericRepositoryClass(Type type)
        {
            var baseType = type.BaseType;
            while (baseType != null)
            {
                if (baseType.IsGenericType &&
                    baseType.GetGenericTypeDefinition() == typeof(GenericRepository<>))
                {
                    return true;
                }
                baseType = baseType.BaseType;
            }
            return false;
        }

        /// <summary>
        /// 检查是否为关系仓储接口
        /// </summary>
        private static bool IsRelationshipRepository(Type type)
        {
            return type.GetInterfaces().Any(i =>
                i.IsGenericType &&
                i.GetGenericTypeDefinition() == typeof(IRelationshipRepository<,,>));
        }

        /// <summary>
        /// 检查是否为关系仓储实现
        /// </summary>
        private static bool IsRelationshipRepositoryImplementation(Type type)
        {
            return IsSubclassOfOpenGeneric(type, typeof(RelationshipRepository<,,>));
        }

        /// <summary>
        /// 检查类型是否是开放泛型的子类
        /// </summary>
        private static bool IsSubclassOfOpenGeneric(Type toCheck, Type openGenericType)
        {
            while (toCheck != null && toCheck != typeof(object))
            {
                var cur = toCheck.IsGenericType ? toCheck.GetGenericTypeDefinition() : toCheck;
                if (openGenericType == cur)
                {
                    return true;
                }
                toCheck = toCheck.BaseType;
            }
            return false;
        }

        /// <summary>
        /// 为接口找到匹配的实现类
        /// </summary>
        private static Type? FindMatchingImplementation(Type interfaceType, List<Type> implementations)
        {
            // 优先按命名约定匹配 (IUserRepository -> UserRepository)
            var expectedImplementationName = interfaceType.Name.Substring(1); // 移除 'I' 前缀
            var implementationByName = implementations
                .FirstOrDefault(impl => impl.Name == expectedImplementationName);

            if (implementationByName != null)
                return implementationByName;

            // 如果按名称找不到，则检查接口实现
            return implementations
                .FirstOrDefault(impl => impl.GetInterfaces().Contains(interfaceType));
        }

        /// <summary>
        /// 为关系仓储找到对应的接口
        /// </summary>
        private static Type? FindRelationshipRepositoryInterface(Type implementation)
        {
            // 优先按命名约定查找 (HierarchyScopeContainsRelationshipRepository -> IHierarchyScopeContainsRelationshipRepository)
            var expectedInterfaceName = "I" + implementation.Name;

            var matchingInterface = implementation.GetInterfaces()
                .FirstOrDefault(i => i.Name == expectedInterfaceName);

            if (matchingInterface != null)
                return matchingInterface;

            // 如果找不到按命名约定的接口，查找其他关系仓储接口
            return implementation.GetInterfaces()
                .FirstOrDefault(i => !i.IsGenericTypeDefinition &&
                                   i.GetInterfaces().Any(baseInterface =>
                                       baseInterface.IsGenericType &&
                                       baseInterface.GetGenericTypeDefinition() == typeof(IRelationshipRepository<,,>)));
        }

        #endregion 辅助方法
    }
}