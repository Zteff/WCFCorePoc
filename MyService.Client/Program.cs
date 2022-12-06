// See https://aka.ms/new-console-template for more information
Console.WriteLine("Connecting to service...");

var client = new ServiceReference1.ServiceClient(ServiceReference1.ServiceClient.EndpointConfiguration.BasicHttpBinding_IService);

while (true)
{
    Console.WriteLine("Enter data to send to service:");
    var input = Console.ReadLine();

    var response = await client.GetDataAsync(input);
    Console.WriteLine($"{response}");
}
