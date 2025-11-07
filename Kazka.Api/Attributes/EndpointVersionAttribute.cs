using Asp.Versioning;

namespace Kazka.Api.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class EndpointVersionAttribute: Attribute
    {
        public int Version { get; }
        public EndpointVersionAttribute(int version) => Version = version;
    }
}
