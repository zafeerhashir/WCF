using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost sh = new ServiceHost(typeof(WcfService2.Service1)))
            {
                sh.Open();
                Console.Write("Host Started", DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
