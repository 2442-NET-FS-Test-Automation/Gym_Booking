using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymBooking.Data.Entities;

[Table("Rooms")]
public class Rooms
{
    [Key]
    public int Room_Id {get; set; }

    [Required]
    public string RoomName {get; set; }

    public ICollection<Schedules> Schedule {get; set; } = default!;
}