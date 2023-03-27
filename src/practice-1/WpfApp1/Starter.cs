using System;

namespace WpfApp1
{
  internal class Starter
    {
        [STAThread]
        public static void Main(string[] args)
        {
            App app = new();
            app.Run();
        }
    }
}
