namespace WebDeliveryApp.Data;

public class ApplicationDbContext
{
    public ApplicationDbContext(object database)
    {
        Database = database;
    }

    public object Database { get; set; }
}