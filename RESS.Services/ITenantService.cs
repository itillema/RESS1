using RESS.Models.Tenant;
using System.Collections.Generic;

namespace RESS.Services
{
    public interface ITenantService
    {
        bool CreateTenant(TenantCreate model);
        bool DeleteTenant(int tenantId);
        IEnumerable<TenantListItem> GetTenant();
        TenantDetail GetTenantById(int id);
        bool UpdateTenant(TenantEdit model);
    }
}