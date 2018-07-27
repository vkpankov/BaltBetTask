using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace BaltBetSimpleServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost studentServiceHost = null;
            try
            {
                Uri httpBaseAddress = new Uri(@"http://localhost:4321/IUserService");
            
                studentServiceHost = new ServiceHost(typeof(BaltBetService.UserService),
                    httpBaseAddress);

                studentServiceHost.AddServiceEndpoint(typeof(BaltBetService.IUserService),
                                                        new WSHttpBinding(), "");

                ServiceMetadataBehavior serviceBehavior = 
                    new ServiceMetadataBehavior();
                serviceBehavior.HttpGetEnabled = true;
                studentServiceHost.Description.Behaviors.Add(serviceBehavior);

                studentServiceHost.Open();
                Console.WriteLine("Сервис открыт по адресу : {0}", httpBaseAddress);
                Console.ReadKey();
            }

            catch (Exception ex)
            {
                studentServiceHost = null;
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.ReadKey();
            }

        }
    }
}
