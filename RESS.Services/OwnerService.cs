using RESS.Data;
using RESS.Models.Owner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESS.Services
{
    public class OwnerService
    {

        public bool CreateOwner(OwnerCreate model)
        {
            var entity =
                new Owner()
                {
                    OwnerFirstName = model.OwnerFirstName,
                    OwnerLastName = model.OwnerLastName,
                    MobileNo = model.MobileNo,
                    Email = model.Email,
                    PurchaseDate = model.PurchaseDate,
                    PurchasePrice  = model.PurchasePrice,
                    DownPayment = model.DownPayment,
                    MortgageAmount = model.MortgageAmount,
                    OwnedProperties = model.OwnedProperties

                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Owners.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<OwnerListItem> GetOwner()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Owners
                        .Select(
                            e =>
                                new OwnerListItem
                                {
                                    OwnerId = e.OwnerId,
                                    OwnerFirstName = e.OwnerFirstName,
                                    OwnerLastName = e.OwnerLastName,
                                    MobileNo = e.MobileNo,
                                    Email = e.Email

                                });
                return query.ToArray();
            }
        }

        public OwnerDetail GetOwnerById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Owners
                        .Single(e => e.OwnerId == id);
                return
                    new OwnerDetail
                    {
                        OwnerId = entity.OwnerId,
                        OwnerFirstName = entity.OwnerFirstName,
                        OwnerLastName = entity.OwnerLastName,
                        MobileNo = entity.MobileNo,
                        Email = entity.Email,
                        PurchaseDate = entity.PurchaseDate,
                        OwnedDuration = entity.OwnedDuration,
                        PurchasePrice = entity.PurchasePrice,
                        DownPayment = entity.DownPayment,
                        MortgageAmount = entity.MortgageAmount,
                        OwnedProperties = (List<Property>)entity.OwnedProperties

                    };
            }
        }

        public bool UpdateOwner(OwnerEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Owners
                        .Single(e => e.OwnerId == model.OwnerId);

                entity.OwnerFirstName = model.OwnerFirstName;
                entity.OwnerLastName = model.OwnerLastName;
                entity.MobileNo = model.MobileNo;
                entity.Email = model.Email;
                entity.PurchaseDate = model.PurchaseDate;
                entity.PurchasePrice = model.PurchasePrice;
                entity.DownPayment = model.DownPayment;
                entity.MortgageAmount = model.MortgageAmount;
                entity.OwnedProperties = model.OwnedProperties;

                return ctx.SaveChanges() == 1;

            }
        }

        public bool DeleteOwner(int ownerId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Owners
                    .Single(e => e.OwnerId == ownerId);
                ctx.Owners.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
