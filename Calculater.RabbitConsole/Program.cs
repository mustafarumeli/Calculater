using System;
using System.Linq;
using System.Threading.Tasks;
using Calculater.Database;
using Calculater.Models;
using Calculater.Queues;
using MassTransit;

namespace Calculater.RabbitConsole
{
    class Program
    {
        static void Main(string[] args)
        {


            var imageFileQueue = new ImageFileQueue();
            imageFileQueue.InitConnection("rabbitmq://localhost/", "guest", "guest", "litteQueue");
            imageFileQueue.Start();
            imageFileQueue.Publish(DbFactory.ImageFiles.Skip(1).First());
            imageFileQueue.SetConsumer(Consume);

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        private static void Consume(ImageFile obj)
        {
            Console.WriteLine(obj.FileName);
        }
      
    }
}
