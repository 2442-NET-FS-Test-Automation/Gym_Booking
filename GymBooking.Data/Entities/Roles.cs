using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymBooking.Data.Entities;

[Table("Roles")]
public class Roles
{
    [Key]
    public int Role_Id {get; set; }

    [Required]
    public string RoleName {get; set; }

    public ICollection<Users> User {get; set; } = default!;
}