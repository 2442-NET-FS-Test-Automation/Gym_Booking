using Cinema.Data.Entities;

namespace Cinema.ControllerApi.DTOs;

public record ShowtimeDto(int Showtime_Id, Movies Movie, Rooms Room, DateOnly ShowDate, TimeOnly StartTime, TimeOnly EndTime, decimal Price);