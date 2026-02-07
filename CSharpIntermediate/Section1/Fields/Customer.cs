namespace Fields;

public class Customer(int id)
{
    public int Id = id;
    public string? Name;
    public readonly List<Order> Orders = [];

    public Customer(int id, string name)
        : this(id)
    {
        Name = name;
    }

    public void Promote()
    {
        // ....
    }
}

