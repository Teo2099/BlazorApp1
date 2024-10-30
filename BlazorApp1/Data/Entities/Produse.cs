using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Entities;

public partial class Produse
{
    public decimal Id { get; set; }

    public int Cod { get; set; }

    public string? Denumire { get; set; }

    public decimal? PretUnitar { get; set; }

    public virtual ICollection<IesiriDetaliu> IesiriDetalius { get; set; } = new List<IesiriDetaliu>();

    public virtual ICollection<IntrariDetaliu> IntrariDetalius { get; set; } = new List<IntrariDetaliu>();
}
