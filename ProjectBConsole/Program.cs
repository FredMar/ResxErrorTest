using Microsoft.Extensions.FileProviders;
using ProjectAWeb.Localization;

namespace ProjectBConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tmp = new ManifestEmbeddedFileProvider(typeof(Translations).Assembly);

            var names = typeof(Program).Assembly.GetManifestResourceNames();


            Console.WriteLine("Hello, World!");
        }
    }
}