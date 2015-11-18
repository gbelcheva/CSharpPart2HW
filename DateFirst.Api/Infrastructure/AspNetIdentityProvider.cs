namespace DateFirst.Api.Infrastructure
{
    using System.Security.Principal;
    using System.Threading;

    public class AspNetIdentityProvider : IIdentityProvider
    {
        public IPrincipal GetIdentity()
        {
            return Thread.CurrentPrincipal;
        }
    }
}