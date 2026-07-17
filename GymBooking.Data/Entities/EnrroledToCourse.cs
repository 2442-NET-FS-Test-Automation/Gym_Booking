using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymBooking.Data.Entities;

[Table("EnrroledToCourse")]
public class EnrroledToCourse
{
    [Key]
    public int EnrroledToCourse_Id {get; set; }

    [Required]
    public int User_Id {get; set; }
    public Users User {get; set; } = default!;

    [Required]
    public int Schedule_Id {get; set; }
    public Schedules Schedule {get; set; } = default!;

    public byte[] RowVersion {get; set; } = default!;
}