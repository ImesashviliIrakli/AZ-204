using System.ComponentModel.DataAnnotations;

namespace SqlApp.Models;

public class Product
{
    [Key]
    public int ProductID { get; set; }
    public string ProductName { get; set; }

    public int Quantity { get; set; }
}
