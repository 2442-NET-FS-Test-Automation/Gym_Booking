using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymBooking.Data.Entities;

[Table("Courses")]
public class Courses
{
    [Key]
    public int Course_Id {get; set; }

    [Required]
    public string CourseName {get; set; }

    [Required]
    public int Category_Id {get; set; }
    public Categories Category {get; set; } = default!;
}