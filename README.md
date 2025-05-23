# MOM
1、API接口在/Src/Apps目录下新建Orchard MVC 子模块项目 
	--> 把新项目添加到MOM.Apps项目的项目引用
2、具体的事件服务等，在/Src/Core/Application/Features目录下新建Orchard MVC 子模块项目 
	--> 在Startup文件的ConfigureServices添加services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Startup).Assembly));
	--> 添加对MOM.Application的项目引用
	--> 将此项目添加到1步骤项目的引用
3、仓储接口写在/Src/Core/Application/MOM.Application.Interfaces/Repositories中
4、仓储的实现写在/Src/Infrastructure/MOM.Infrastructure.Persistence/Repositories中
# 注意
1、如果需要本地化，可使用MOM.Application.Wrappers的ITranslator
2、一旦针对具体的个人设置权限后，以后设置权限基本都需要顾及到这个个人的权限考虑，仅限个别特殊人员才进行此项配置，非必要不要进行