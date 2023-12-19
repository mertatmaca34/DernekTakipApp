using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MemberManager>().As<IMemberManager>().SingleInstance();
            builder.RegisterType<DueManager>().As<IDueManager>().SingleInstance();
            builder.RegisterType<EfMemberDal>().As<IMemberDal>().SingleInstance();
            builder.RegisterType<EfDueDal>().As<IDueDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                }).SingleInstance();
        }
    }
}