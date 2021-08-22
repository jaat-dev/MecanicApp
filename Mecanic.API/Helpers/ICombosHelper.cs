using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Mecanic.API.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboDocumentTypes();

        IEnumerable<SelectListItem> GetComboProcedures();

        IEnumerable<SelectListItem> GetComboVehicleTypes();

        IEnumerable<SelectListItem> GetComboBrands();
    }
}
