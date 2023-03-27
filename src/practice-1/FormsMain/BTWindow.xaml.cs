using System.Windows;
using System.Windows.Input;

namespace FormsMain
{
  /// <summary>
  /// BTWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class BTWindow : Window
    {
        public BTWindow()
        {
            InitializeComponent();

            grid1.MouseLeftButtonDown += Grid1_MouseLeftButtonDown;
            txb1.MouseLeftButtonDown += Txb1_MouseLeftButtonDown;
            MouseLeftButtonDown += BTWindow_MouseLeftButtonDown;

            grid1.PreviewMouseLeftButtonDown += Grid1_PreviewMouseLeftButtonDown;
            txb1.PreviewMouseLeftButtonDown += Txb1_PreviewMouseLeftButtonDown;
            PreviewMouseLeftButtonDown += BTWindow_PreviewMouseLeftButtonDown;
        }

        private void BTWindow_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
        }

        private void BTWindow_MouseLeftButtonDown1(object sender, MouseButtonEventArgs e)
        {
        }

        private void Txb1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void Grid1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void BTWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void Txb1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {  
        }

        private void Grid1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        { 
        }
    }
}
