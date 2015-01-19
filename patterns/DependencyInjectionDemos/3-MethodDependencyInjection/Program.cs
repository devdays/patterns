using System;

public interface IService
{
    void Serve();
}

public class Service : IService
{
    public void Serve()
    {
        Console.WriteLine("Service Called");
        //To Do: Some Stuff
    }
}
 
public class Client
{
    private IService _service;
 
    public void Start(IService service)
    {
        this._service = service;
        Console.WriteLine("Service Started");
        this._service.Serve();
        //To Do: Some Stuff
    }
}

class Program
{
    static void Main(string[] args)
    {
        Client client = new Client();
        client.Start(new Service());
     
        Console.ReadKey();
    }
}

