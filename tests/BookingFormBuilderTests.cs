using Xunit;
namespace tests;

public class BookingFormBuilderTests
{
    [Fact]
    public void BookingForm_WithValidData_ValidateReturnsTrue()
    {
        var form = new BookingForm
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
