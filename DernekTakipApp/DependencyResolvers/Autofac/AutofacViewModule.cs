﻿using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;

namespace DernekTakipApp.DependencyResolvers.Autofac
{
    public class AutofacViewModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FormMain>().AsSelf();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                }).SingleInstance();
        }
    }
}
