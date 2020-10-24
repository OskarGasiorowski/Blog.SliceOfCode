using Autofac;
using Autofac.Extras.DynamicProxy;
using SliceOfCode.Logging.Api.Logging;
using SliceOfCode.Logging.Api.Services;

namespace SliceOfCode.Logging.Api.IoC
{
    public class AutofacModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LoggingInterceptor>()
                .SingleInstance();
            
            builder.RegisterType<LoggingFilter>()
                .InstancePerDependency()
                .AsSelf();

            builder.RegisterType<SampleService>()
                .As<ISampleService>()
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(LoggingInterceptor))
                .InstancePerDependency();
        }
    }
}