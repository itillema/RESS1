using RESS.Models.Owner;
using System.Collections.Generic;

namespace RESS.Services
{
    public interface IOwnerService
    {
        bool CreateOwner(OwnerCreate model);
        bool DeleteOwner(int ownerId);
        IEnumerable<OwnerListItem> GetOwner();
        OwnerDetail GetOwnerById(int id);
        bool UpdateOwner(OwnerEdit model);
    }
}