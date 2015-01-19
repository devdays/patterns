using System;


public class Service
{
    public void Serve()
    {
        Console.WriteLine("Service Called");
        //To Do: Some Stuff
    }
}

public class Client
{
    private Service _service;

    public Client(Service service)
    {
        this._service = service;
    }

    public void Start()
    {
        Console.WriteLine("Service Started");
        this._service.Serve();
        //To Do: Some Stuff
    }
}

class Program
{
    static void Main(string[] args)
    {
        Client client = new Client(new Service());
        client.Start();

        Console.ReadKey();

    }
}

   /* 
class AlternateService
{
    public void Serve()
    {
        Console.WriteLine("Service Called");
        //To Do: Some Stuff
    }
}

class TestClient
{
    // will not compile. Cannot mock out the alternate service
    Client client = new Client(new AlternateService());
    client.Start();

    Console.ReadKey();
}
    */

