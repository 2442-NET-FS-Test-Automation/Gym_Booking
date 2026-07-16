using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymBooking.Data.Entities;

[Table("Users")]
public class Users
{
    [Key]
    public int User_Id {get; set; }

    [Required, MaxLength(50)]
    public string UserName {get; set; }

    [Required]
    public string Password {get; set; }

    [Required]
    public int Role_Id {get; set; }
    public Roles Role {get; set; } = default!;

    [Required, MaxLength(200)]
    public string FullName {get; set; }

    [MaxLength(100)]
    public string Address {get; set; }

    [MaxLength(10)]
    public string PhoneNumber {get; set; }

    public ICollection<EnrroledToCourse> EnrroledCourses {get; set; } = default!;
    public ICollection<Schedules> Schedule {get; set; } = default!;
}