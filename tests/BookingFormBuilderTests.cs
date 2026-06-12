using Models;
namespace tests;

public class BookingFormBuilderTests
{
    [Fact]
    public void Booking_WithValidData_ValidateReturnsTrue()
    {
        var booking = new Booking
        {
            GuestName = "Ola Nordmann",
            RoomNumber = 101,
            BookingDate = DateTime.Today
        };

        var isValid = booking.Validate(out var errors);

        Assert.True(isValid);
        Assert.Empty(errors);
    }

}
