namespace Models;

public class Booking
{
    public string GuestName { get; set; } = string.Empty;

    public int RoomNumber { get; set; }

    public DateTime BookingDate { get; set; }

    public override string ToString()
    {
        return $"{GuestName} booked room {RoomNumber} on {BookingDate:d}";
    }
    public bool Validate(out List<string> errors)
    {
        errors = new List<string>();

        if (string.IsNullOrWhiteSpace(GuestName))
            errors.Add("GuestName is required");

        if (RoomNumber <= 0)
            errors.Add("RoomNumber must be greater than 0");

        if (BookingDate == default)
            errors.Add("BookingDate is required");

        return errors.Count == 0;
    }
}