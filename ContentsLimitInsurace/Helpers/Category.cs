using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentsLimitInsuranceWebApp.Helpers
{
    public class Category
    {
        public static List<SelectListItem> categoryList()
        {
            List<SelectListItem> categories = new List<SelectListItem>();

            categories.Add(new SelectListItem { Text = "Electronics", Value = "Electronics" });
            categories.Add(new SelectListItem { Text = "Clothing", Value = "Clothing" });
            categories.Add(new SelectListItem { Text = "Kitchen", Value = "Kitchen" });
            categories.Add(new SelectListItem { Text = "Bathroom", Value = "Bathroom" });
            categories.Add(new SelectListItem { Text = "Patio/Outdoor", Value = "Patio/Outdoor" });

            return categories;
        }


    }
}
