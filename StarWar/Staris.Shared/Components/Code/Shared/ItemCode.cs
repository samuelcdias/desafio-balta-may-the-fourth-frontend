using Microsoft.AspNetCore.Components;
using Staris.Shared.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staris.Shared.Components.Code.Shared
{
    public class ItemCode<T> : ComponentBase where T : ViewModelBase
    {
        [Parameter]
        public T Item { get; set; } = null!;
        [Parameter]
        public string ImageAsset { get; set; } = "assets/not-found-generic.png";

        protected string GetImage()
        {
            if (!string.IsNullOrEmpty(Item.ImageUrl))
            {
                var img = RemoverSubstring(Item.ImageUrl);
                return img;

            }
            return ImageAsset;
        }
        public static string RemoverSubstring(string texto, string substring = "/revision")
        {
            int indice = texto.IndexOf(substring);
            if (indice != -1)
            {
                // Remove a substring e tudo que vem depois dela
                return texto.Substring(0, indice);
            }
            else
            {
                // Se a substring não for encontrada, retorna o texto original
                return texto;
            }
        }
    }
}
