using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymBooking.Data.Entities;

[Table("WeekDays")]
public class WeekDays
{
    [Key]
    public int WeekDay_Id {get; set; }

    [Required]
    public int WeekDay {get; set; }

    [Required]
    public int Schedule_Id {get; set; }
    public Schedules Schedule {get; set; } = default!;
}