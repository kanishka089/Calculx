namespace CalculX.Base.Services
{
    public sealed class TenantProvider
    {
        private const string TenantIdHeaderName = "X-TenantId";
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TenantProvider(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public int GetTenantId()
        {
            var tenantIdHeader = _httpContextAccessor.HttpContext?
                .Request
                .Headers[TenantIdHeaderName];
            //var tenantClaim = _httpContextAccessor.HttpContext?.User?.Claims
            //.FirstOrDefault(c => c.Type == "TenantId");


            if (!tenantIdHeader.HasValue || !int.TryParse(tenantIdHeader.Value, out var tenantId))
            {
                throw new ArgumentException("Tenant Id is not present");
            }
            return tenantId;
            //if (tenantClaim != null && int.TryParse(tenantClaim.Value, out int tenantId))
            //{
            //    return tenantId;
            //}

           // throw new Exception("TenantId claim is missing in the JWT token.");
        }
    }
}
