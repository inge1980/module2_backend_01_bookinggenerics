using Models;
using Repositories;
namespace tests;

public class BookingTests
{

    [Fact]
    public void Repository_GetByIndex_NegativeIndex_ShouldReturnNull()
    {
        var repo = new Repository<Guest>();

        repo.Add(new Guest());

        var result = repo.GetByIndex(-1);

        Assert.Null(result);
    }


    [Fact]
    public void Repository_GetByIndex_InvalidIndex_ShouldReturnNull()
    {
        var repo = new Repository<HotelRoom>();

        repo.Add(new HotelRoom());

        var result = repo.GetByIndex(99);

        Assert.Null(result);
    }

    [Fact]
    public void Repository_GetByIndex_ShouldReturnCorrectItem()
    {
        var repo = new Repository<Booking>();

        repo.Add(new Booking());
        repo.Add(new Booking
        {
            GuestName = "Ola Nordmann",
            RoomNumber = 101,
            BookingDate = DateTime.Today
        });
        var item = repo.GetByIndex(1);

        Assert.Equal("Ola Nordmann", item.GuestName );
    }

    [Fact]
    public void Repository_Add_ShouldStoreItem_And_GetAllReturnsIt()
    {
        var repo = new Repository<string>();

        repo.Add("A");

        var items = repo.GetAll();

        Assert.Single(items);
        Assert.Contains("A", items);
    }

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
