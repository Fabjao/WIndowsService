using System;
using System.ServiceModel;
using System.ServiceProcess;

namespace APIWcfRest
{
    public partial class Service1 : ServiceBase
    {
        static ServiceHost[] _serviceHost;
        public Service1()
        {
            _serviceHost = new ServiceHost[]
            {
                new ServiceHost(typeof(ImplementationPessoa))
            };
        }

        public static void Main(string[] args)
        {
            ServiceBase[] _serviceToRun;
            _serviceToRun = new ServiceBase[]
            {
                new Service1()
            };

            //ServiceBase.Run(_serviceToRun);
            (_serviceToRun[0] as Service1).OnStart(args);
            Console.WriteLine("Digite algo para sair");
            Console.Read();
        }

        protected override void OnStart(string[] args)
        {
            foreach (var item in _serviceHost)
            {
                item.Open();
            }
        }

        protected override void OnStop()
        {
            foreach (var item in _serviceHost)
            {
                if (item != null)
                {
                    item.Close();
                }
            }
        }
    }
}
