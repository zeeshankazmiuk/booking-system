// Zeeshan Kazmi
// KAZ22527866

// Bookings interface created with 2 methods
public interface Bookings
{
    void Book(Accommodation accommodation, User user);
    void CancelBooking(Accommodation accommodation, User user);
}


// Booked accommodation cannot be booked again by anyone
// but can be cancelled by the user who initally booked them
public class Booked : Bookings
{
    public void Book(Accommodation accommodation, User user)
    {
        Console.WriteLine($"Sorry {user.Name}, {accommodation.Name} has already been booked.");
    }

    public void CancelBooking(Accommodation accommodation, User user)
    {
        if (accommodation.Booker == user)
        {
            accommodation.IsBooked = false;
            Console.WriteLine($"{user.Name}'s booking for {accommodation.Name} has been cancelled.");
            accommodation.ChangeState(new Available());
        }
        else
        {
            Console.WriteLine($"Sorry {user.Name}, you do not have a booking for {accommodation.Name}.");
        }
    }
}


// Available accommodation can be booked by anyone
// but cannot be cancelled by anyone
class Available : Bookings
{
    public void Book(Accommodation accommodation, User user)
    {
        accommodation.IsBooked = true;
        Console.WriteLine($"{user.Name} {user.LastName} has booked {accommodation.Name}");
        accommodation.Booker = user;
        accommodation.ChangeState(new Booked());
    }

    public void CancelBooking(Accommodation accommodation, User user)
    {
        Console.WriteLine($"Sorry {user.Name}, you do not have a booking for {accommodation.Name}, however, it's available to book!");
    }
}
