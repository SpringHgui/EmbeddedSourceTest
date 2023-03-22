using System.Reflection;

namespace EmbeddedSourceTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] manifestResourceNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            for (int i = 0; i < manifestResourceNames.Length; i++)
            {
                Console.WriteLine(manifestResourceNames[i]);
            }

            Console.ReadLine();
        }
    }
}