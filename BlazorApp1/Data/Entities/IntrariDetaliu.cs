using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Entities;

public partial class IntrariDetaliu
{
    public decimal Id { get; set; }

    public decimal? IdIntrari { get; set; }

    public decimal? Produs { get; set; }

    public decimal? Cantitate { get; set; }

    public decimal? Valoare { get; set; }

    public virtual Intrari? IdIntrariNavigation { get; set; }

    public virtual Produse? ProdusNavigation { get; set; }
}
