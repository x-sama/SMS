using System.ComponentModel.DataAnnotations;

namespace CoreBusiness;
// the core business is a class library that hold the project models
public class Category
{
    public int CategoryId { get; set; }
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
}