using Microsoft.AspNetCore.Components;
using Staris.Shared.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staris.Shared.Components.Code.Shared
{
    public class ListItems : ComponentBase
    {
        [Parameter]
        public string Name { get; set; } = "Lista";
        [Parameter]
        public string Url { get; set; } = "/";
        [Parameter]
        public List<BaseToListViewModel> Items { get; set; } = new();
    }
}
