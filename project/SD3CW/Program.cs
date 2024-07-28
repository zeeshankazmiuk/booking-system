// Zeeshan Kazmi
// KAZ22527866

class Program
{
    public static void Main(string[] args)
    {

        // Make an object for each subclass of Accommodation
        House wayneManor = new House("Wayne Manor", "Negra Arroyo Lane", 308, 69000, 4, false, 2, 3, 2, true);
        Hotel transylvania = new Hotel("Transylvania", "Spooky Lane", 21, 420000, 2, false, 36, true, true, true, false);
        Flat happyFlat = new Flat("Happy Flat", "Happy Street", 1, 99999, 1, false, 0, 1, 1, true);
        Sofa susSofa = new Sofa("Craigslist Sofa", "Shady Street", 666, 5, false, 1, "fabric");
        UniDorm wesleyHall = new UniDorm("Wesley Hall", "Southlands College", 1, 8000, false, 1, 2, "KAZ226969", true);

        // Put the objects in a list
        List<Accommodation> accomList = new List<Accommodation>();
        accomList.Add(wayneManor);
        accomList.Add(transylvania);
        accomList.Add(happyFlat);
        accomList.Add(susSofa);
        accomList.Add(wesleyHall);


        // Make 3 users
        User bob = new User("Bob", "The Builder");
        User zk = new User("Z", "K");
        User mariojudah = new User("Mario", "Judah");


        // Bob books Wayne Manor
        wayneManor.Book(wayneManor, bob);

        // Mario Judah cannot book Wayne Manor
        wayneManor.Book(wayneManor, mariojudah);

        // Z K cannot cancel Bob's booking
        wayneManor.CancelBooking(wayneManor, zk);

        // Bob cancels their own booking
        wayneManor.CancelBooking(wayneManor, bob);

        // Mario Judah has no booking to cancel
        transylvania.CancelBooking(transylvania, mariojudah);

        Console.WriteLine("\n");


        // Print out the details of each accommodation
        foreach (var accommodation in accomList)
        {
            accommodation.Print();
        }
    }
}
