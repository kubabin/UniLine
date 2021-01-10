using System;
using System.Resources;
using System.Diagnostics;

namespace UniLine
{
    class Program
    {

        static void Main(string[] args)
        {
            // TODO: Uruchom z argumentami
            Console.Title = args[1];
            ResourceManager manager = ResourceManager.CreateFileBasedResourceManager("Resources.resx", "Properties", null);
            string version = manager.GetString("version");
            Console.WriteLine("UniLine " + version + "> help for help");
            Console.WriteLine("> ");
        }
    }
    // Nazwa kodowa: GetInstance
    class Instance
    {
        public ConsoleColor ForeColor { get; set; }
        public ConsoleColor BackColor { get; set; }
        public string WindowTitle { get; set; }
        public string[] Commands { get; set; }
        public bool CursorVisible { get; set; }

        protected void Init()
        {
            try
            {
                Console.BackgroundColor = BackColor;
                Console.ForegroundColor = ForeColor;
                Console.Title = WindowTitle;
                Console.CursorVisible = this.CursorVisible;
            }
            catch(Exception e)
            {
                Debug.WriteLine("[UNILINE] ERROR! Exception: " + e);
                
            }
            Debug.WriteLine("[UNILINE] Everything set up!");
            
        }
    }
}
