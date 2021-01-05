using System;
using System.Resources;

namespace UniLine
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ResourceManager manager = ResourceManager.CreateFileBasedResourceManager("Resources.resx", "Properties", null);
            string version = manager.GetString("version");
            Console.WriteLine("UniLine " + version);
        }
    }
}
