﻿using System.Text.Json.Serialization;

namespace Staris.Shared.ViewModel;
public class ViewModelBase
{
    public int? Id { get; set; }
    public string? ImageUrl { get; set; }
    public List<string>? Imagens { get; set; }
    public DateTime? Created { get; set; }
    public DateTime? Edited { get; set; }
    public string? Url { get; set; }
}
