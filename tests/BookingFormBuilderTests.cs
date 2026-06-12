//using Xunit;
using src.Models.Booking;
using src.Models.Guest;
using src.Models.HotelRoom;
namespace tests;

public class BookingFormBuilderTests
{
    [Fact]
    public void Booking_WithValidData_ValidateReturnsTrue()
    {
        var form = new Booking
        {
            CustomerName = "John",
            CustomerEmail = "john@example.com",
            CustomerPhone = "12345678",
            RoomType = RoomType.Double,
            BookingDate = DateTime.Today,
            CheckInDate = DateTime.Today.AddDays(1),
            CheckOutDate = DateTime.Today.AddDays(2)
        };

        var isValid = form.Validate(out var errors);

        Assert.True(isValid);
        Assert.Empty(errors);
    }

}
