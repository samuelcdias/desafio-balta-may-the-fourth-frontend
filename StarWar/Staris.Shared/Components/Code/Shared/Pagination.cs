using Microsoft.AspNetCore.Components;
using Staris.Shared.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staris.Shared.Components.Code.Shared
{
    public class Pagination : ComponentBase
    {
        [Inject]
        public NavigationManager _navigationManager { get; set; } = default!;
        [Parameter]
        [SupplyParameterFromQuery]
        public int Page { get; set; } = 1;
        [Parameter]
        public int TotalPages{ get; set; }
        public Pagination()
        {
            Page = 1;
        }

        public int StartPage
        {
            get
            {
                int startPage = Page - 2;
                if (startPage < 1)
                {
                    startPage = 1;
                }

                return startPage;
            }
        }

        public int MaxPage
        {
            get
            {
                int maxPage = StartPage + 4;

                if (maxPage > TotalPages)
                {
                    maxPage = TotalPages;
                }

                return maxPage;
            }
        }
        public string GetUrl(int page)
        {
            var uriBuilder = new UriBuilder(_navigationManager.Uri);
            var q = System.Web.HttpUtility.ParseQueryString(uriBuilder.Query);
            q["page"] = page.ToString();
            uriBuilder.Query = q.ToString();
            var newUrl = uriBuilder.ToString();
            return $"{uriBuilder}";
           
        }
    }
}
