using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymBooking.Data.Entities;

[Table("Categories")]
public class Categories
{
    [Key]
    public int Category_Id {get; set; }

    [Required]
    public string CategoryName {get; set; }

    public ICollection<Courses> Course {get; set; } = default!;
}