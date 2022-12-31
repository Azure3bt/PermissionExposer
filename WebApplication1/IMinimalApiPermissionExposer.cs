namespace WebApplication1
{
    public interface IMinimalApiPermissionExposer : IPermissionExposer
    {
        public string Path { get; }

        public HttpMethod Method { get; }

        public Delegate Handler { get; }
    }
}
