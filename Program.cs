using Core.Models;
using Core.Repositories;

Repository<HotelRoom> roomRepository = new();
Repository<Guest> guestRepository = new();
Repository<Booking> bookingRepository = new();

roomRepository.Add(new HotelRoom
{
    RoomNumber = 101,
    Capacity = 2
});

roomRepository.Add(new HotelRoom
{
    RoomNumber = 102,
    Capacity = 4
});

guestRepository.Add(new Guest
{
    Name = "Ola Nordmann",
    Email = "ola@test.no"
});

guestRepository.Add(new Guest
{
    Name = "Kari Hansen",
    Email = "kari@test.no"
});

bookingRepository.Add(new Booking
{
    GuestName = "Ola Nordmann",
    RoomNumber = 101,
    BookingDate = DateTime.Now
});

Console.WriteLine("ROOMS");
foreach (var room in roomRepository.GetAll())
{
    Console.WriteLine(room);
}

Console.WriteLine();

Console.WriteLine("GUESTS");
foreach (var guest in guestRepository.GetAll())
{
    Console.WriteLine(guest);
}

Console.WriteLine();

Console.WriteLine("BOOKINGS");
foreach (var booking in bookingRepository.GetAll())
{
    Console.WriteLine(booking);
}