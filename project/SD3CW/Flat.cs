// Zeeshan Kazmi
// KAZ22527866

// Subclass Flat created
public class Flat : Accommodation
{
    private int floor;
    private int bedroomCount;
    private int bathroomCount;
    private bool hasBalcony;

    // Constructor includes base attributes inherited from Accommodation
    public Flat(string Name, string Address, int DoorNum, decimal Price, int OccupantCapacity, bool isBooked, int Floor, int BedroomCount, int BathroomCount, bool HasBalcony)
        : base(Name, Address, DoorNum, Price, OccupantCapacity, isBooked)
    {
        floor = Floor;
        bedroomCount = BedroomCount;
        bathroomCount = BathroomCount;
        hasBalcony = HasBalcony;
    }

    // Overide Print method to print details specific to Flat
    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Floor: {floor}");
        Console.WriteLine($"Bedroom Count: {bedroomCount}");
        Console.WriteLine($"Bathroom Count: {bathroomCount}");
        Console.WriteLine($"Has Balcony: {hasBalcony} \n\n");
    }
}
