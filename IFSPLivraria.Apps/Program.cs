using IFSPLivraria.App.Infra;

namespace IFSPLivraria.App
{
    internal static class Program
    {
        
        
        static void Main()
        {
            ConfigureDI.ConfiguraServices();
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Principal());
        }
    }
}