// Zeeshan Kazmi
// KAZ22527866

// User class created
public class User
{
    public string Name { get; private set; }
    public string LastName { get; private set; }
    public User(string name, string lastName)
    {
        Name = name;
        LastName = lastName;
    }
}