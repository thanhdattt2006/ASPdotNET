namespace StageSeven.Models;

public class Product
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Product name cant be null!")]
    public string? Name { get; set; }

    [Range(0.01, double.MaxValue, ErrorMessage = "Price must be more 0!")]
    public double Price { get; set; }

    public int Quantity { get; set; }

    public bool Status { get; set; }

    public DateTime Mfg { get; set; }

    public string? Photo { get; set; }

    [NotMapped]
    public string StatusDisplay => Status ? "in stock" : "out of stock";
}