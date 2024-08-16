using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace back.Models;

public partial class Product
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public long? Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? Image { get; set; }

    public decimal Price { get; set; }

    public string Category { get; set; } = null!;

    public decimal Quantity { get; set; }

    public string InventoryStatus { get; set; } = null!;

    public decimal? Rating { get; set; }
}
