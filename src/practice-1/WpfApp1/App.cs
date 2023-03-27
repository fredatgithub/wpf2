using FormsMain;
using System.Windows;

namespace WpfApp1
{
  internal class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            CustomWindow1 win = new();
            win.ShowDialog();
        }
    }
}
