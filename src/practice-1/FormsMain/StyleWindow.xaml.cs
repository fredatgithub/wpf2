using System.Windows;

namespace FormsMain
{
  /// <summary>
  /// StyleWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class StyleWindow : Window
    {
        public StyleWindow()
        {
            InitializeComponent();
            DataContext = new JamesViewModel();
        }
    }
}
