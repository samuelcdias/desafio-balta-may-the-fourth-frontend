﻿using Microsoft.AspNetCore.Components;
using System.Net.Http.Headers;

namespace Staris.Shared.Components.Code;

public class ComponentBaseGeneric<T>: ComponentBase where T : class, new()
{
    [Parameter]
    public T Model { get; set; }

    public bool IsDone { get; set; }
}
