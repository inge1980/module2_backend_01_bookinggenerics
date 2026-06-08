namespace Core.Models;

public class Booking
{
    public string GuestName { get; set; } = string.Empty;

    public int RoomNumber { get; set; }

    public DateTime BookingDate { get; set; }

    public override string ToString()
    {
        return $"{GuestName} booked room {RoomNumber} on {BookingDate:d}";
    }
}