using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace GrpcFunClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Country.CountryClient(channel);

            var reply = await client.GetAllAsync(new EmptyRequest());
            Console.WriteLine("Countries: " + reply.Countries);
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
