using RESS.Models;
using System.Collections.Generic;

namespace RESS.Services
{
    public interface IPropertyService
    {
        bool CreateProperty(PropertyCreate model);
        bool DeleteProperty(int propertyId);
        IEnumerable<PropertyListItem> GetProperties();
        PropertyDetail GetPropertyById(int id);
        bool UpdateProperty(PropertyEdit model);
    }
}