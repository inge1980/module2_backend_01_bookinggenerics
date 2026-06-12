namespace Models;

public class HotelRoom
{
    public int RoomNumber { get; set; }

    public int Capacity { get; set; }

    public override string ToString()
    {
        return $"Room {RoomNumber} - Capacity: {Capacity}";
    }
}