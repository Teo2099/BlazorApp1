using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Entities;

public partial class Gestiuni
{
    public decimal Id { get; set; }

    public int Cod { get; set; }

    public string? Denumire { get; set; }

    public virtual ICollection<Iesiri> Iesiris { get; set; } = new List<Iesiri>();

    public virtual ICollection<Intrari> Intraris { get; set; } = new List<Intrari>();
}
