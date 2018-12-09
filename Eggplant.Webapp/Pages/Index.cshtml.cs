using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eggplant.Application.Recipes.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eggplant.Webapp.Pages
{
    public class IndexModel : PageModel
    {

        readonly IGetRecipesListQuery _query;
        public IndexModel(IGetRecipesListQuery query)
        {
            _query= query;
        }
        public void OnGet()
        {

        }
    }
}
