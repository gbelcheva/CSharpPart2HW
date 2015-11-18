namespace DateFirst.Api.Infrastructure
{
    using System.Security.Principal;

    public interface IIdentityProvider
    {
        IPrincipal GetIdentity();
    }
}
