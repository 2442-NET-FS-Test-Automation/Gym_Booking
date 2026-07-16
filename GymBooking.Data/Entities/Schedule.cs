using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymBooking.Data.Entities;

[Table("Schedules")]
public class Schedules
{
    [Key]
    public int Schedule_Id {get; set; }

    [Required]
    public int Trainer_Id {get; set; }
    public Users Trainer {get; set; } = default!;

    [Required]
    public int Course_Id {get; set; }
    public Courses Course {get; set; } = default!;

    [Required]
    public int Room_Id {get; set; }
    public Rooms Room {get; set; } = default!;

    [Required]
    public TimeOnly StartTime {get; set; }

    [Required]
    public TimeOnly EndTime {get; set; }

    [Required]
    public DateOnly StartDate {get; set; }

    [Required]
    public DateOnly EndDate {get; set; }

    public ICollection<WeekDays> weekDays {get; set; } = default!;
    public ICollection<EnrroledToCourse> EnrroledCouurse {get; set; } = default!;
    
}