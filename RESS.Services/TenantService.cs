using RESS.Data;
using RESS.Models.Tenant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESS.Services
{
    public class TenantService
    {

        public bool CreateTenant(TenantCreate model)
        {
            var entity =
                new Tenant()
                {
                    TenantFirstName = model.TenantFirstName,
                    TenantLastName = model.TenantLastName,
                    MobileNo = model.MobileNo,
                    Email = model.Email,
                    LeaseStart = model.LeaseEnd,
                    LeaseEnd = model.LeaseEnd,
                    SecurityDeposit = model.SecurityDeposit,
                    RentAmount = model.RentAmount,
                    
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Tenants.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<TenantListItem> GetTenant()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Tenants
                        .Select(
                            e =>
                                new TenantListItem
                                {
                                    TenantId = e.TenantId,
                                    TenantFirstName = e.TenantFirstName,
                                    TenantLastName = e.TenantLastName,
                                    MobileNo = e.MobileNo,
                                    Email = e.Email
                                    

                                });
                return query.ToArray();
            }
        }

        public TenantDetail GetTenantById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Tenants
                        .Single(e => e.TenantId == id);
                return
                    new TenantDetail
                    {
                        TenantId = entity.TenantId,
                        TenantFirstName = entity.TenantFirstName,
                        TenantLastName = entity.TenantLastName,
                        MobileNo = entity.MobileNo,
                        Email = entity.Email,
                        LeaseStart = entity.LeaseStart,
                        LeaseEnd = entity.LeaseEnd,
                        LeaseDuration = entity.LeaseDuration,
                        SecurityDeposit = entity.SecurityDeposit,
                        RentAmount = entity.RentAmount,
                        PropertyId = entity.PropertyId,
                        Address = entity.Address

                    };
            }
        }

        public bool UpdateTenant(TenantEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Tenants
                        .Single(e => e.TenantId == model.TenantId);

                entity.TenantFirstName = model.TenantFirstName;
                entity.TenantLastName = model.TenantLastName;
                entity.MobileNo = model.MobileNo;
                entity.Email = model.Email;
                entity.LeaseStart = model.LeaseStart;
                entity.LeaseEnd = model.LeaseEnd;
                entity.SecurityDeposit = model.SecurityDeposit;
                entity.RentAmount = model.RentAmount;

                return ctx.SaveChanges() == 1;

            }
        }

        public bool DeleteTenant(int tenantId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Tenants
                    .Single(e => e.TenantId == tenantId);
                ctx.Tenants.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}

