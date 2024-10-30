using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Entities;

public partial class IesiriDetaliu
{
    public decimal Id { get; set; }

    public decimal? IdIesiri { get; set; }

    public decimal? Produs { get; set; }

    public decimal? Cantitate { get; set; }

    public decimal? Valoare { get; set; }

    public virtual Iesiri? IdIesiriNavigation { get; set; }

    public virtual Produse? ProdusNavigation { get; set; }
}
