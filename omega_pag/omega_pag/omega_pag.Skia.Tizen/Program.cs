using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace omega_pag.Skia.Tizen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new omega_pag.App());
            host.Run();
        }
    }
}
