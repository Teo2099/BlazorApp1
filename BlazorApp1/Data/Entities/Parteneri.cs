using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Entities;

public partial class Parteneri
{
    public decimal Id { get; set; }

    public int Cod { get; set; }

    public string? Denumire { get; set; }

    public string? Cui { get; set; }

    public string? Adresa { get; set; }

    public virtual ICollection<Intrari> Intraris { get; set; } = new List<Intrari>();
}
