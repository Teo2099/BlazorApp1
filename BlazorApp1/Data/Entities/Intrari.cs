using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Entities;

public partial class Intrari
{
    public decimal Id { get; set; }

    public decimal Numar { get; set; }

    public DateTime? Data { get; set; }

    public decimal? Partener { get; set; }

    public decimal? Gestiune { get; set; }

    public virtual Gestiuni? GestiuneNavigation { get; set; }

    public virtual ICollection<IntrariDetaliu> IntrariDetalius { get; set; } = new List<IntrariDetaliu>();

    public virtual Parteneri? PartenerNavigation { get; set; }
}
