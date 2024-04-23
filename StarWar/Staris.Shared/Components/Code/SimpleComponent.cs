using Microsoft.AspNetCore.Components;

namespace Staris.Shared.Components.Code;

public  class SimpleComponent<T> : ComponentBaseGeneric<T> where T : class, new()
{

}
