using System;
using System.Collections.Generic;

namespace BlazorApp1.Data.Entities;

public partial class Iesiri
{
    public decimal Id { get; set; }

    public decimal? Numar { get; set; }

    public DateTime? Data { get; set; }

    public decimal? Gestiunea { get; set; }

    public virtual Gestiuni? GestiuneaNavigation { get; set; }

    public virtual ICollection<IesiriDetaliu> IesiriDetalius { get; set; } = new List<IesiriDetaliu>();
}
