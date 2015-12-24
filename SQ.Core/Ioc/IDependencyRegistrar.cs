using Autofac;
using SQ.Core.Reflection;
using SQ.Core.Config;

namespace SQ.Core.Ioc
{
    public interface IDependencyRegistrar
    {
        void Register(ContainerBuilder builder, ITypeFinder typeFinder, SQConfig config);

        int Order { get; }
    }
}
