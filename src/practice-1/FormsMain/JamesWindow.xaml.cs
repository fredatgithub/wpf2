using System.Windows;

namespace FormsMain
{
  /// <summary>
  /// JamesWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class JamesWindow : Window
    {
        public JamesWindow()
        {
            InitializeComponent();
            DataContext = new JamesViewModel();
        }
    }
}
