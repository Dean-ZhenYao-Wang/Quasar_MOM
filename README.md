# MOM
1��API�ӿ���/Src/AppsĿ¼���½�Orchard MVC ��ģ����Ŀ 
	--> ������Ŀ��ӵ�MOM.Apps��Ŀ����Ŀ����
2��������¼�����ȣ���/Src/Core/Application/FeaturesĿ¼���½�Orchard MVC ��ģ����Ŀ 
	--> ��Startup�ļ���ConfigureServices���services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Startup).Assembly));
	--> ��Ӷ�MOM.Application����Ŀ����
	--> ������Ŀ��ӵ�1������Ŀ������
3���ִ��ӿ�д��/Src/Core/Application/MOM.Application.Interfaces/Repositories��
4���ִ���ʵ��д��/Src/Infrastructure/MOM.Infrastructure.Persistence/Repositories��
# ע��
1�������Ҫ���ػ�����ʹ��MOM.Application.Wrappers��ITranslator
2��һ����Ծ���ĸ�������Ȩ�޺��Ժ�����Ȩ�޻�������Ҫ�˼���������˵�Ȩ�޿��ǣ����޸���������Ա�Ž��д������ã��Ǳ�Ҫ��Ҫ����