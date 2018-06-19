using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace APIWcfRest
{
    [RunInstaller(true)]
    public partial class Installer1 : Installer
    {
        private ServiceInstaller _installer;
        private ServiceProcessInstaller _process;

        public Installer1()
        {
            _process = new ServiceProcessInstaller();
            _process.Account = ServiceAccount.LocalSystem;
            _installer = new ServiceInstaller();
            _installer.ServiceName = "MeuTesteWCFRest";
            _installer.Description = "Apenas um teste para receber um objeto que tenha data e hora";
            Installers.Add(_process);
            Installers.Add(_installer);
        }
    }
}
