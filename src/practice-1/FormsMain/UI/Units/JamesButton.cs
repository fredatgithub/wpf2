using System.Windows;
using System.Windows.Controls;

namespace FormsMain.UI.Units
{
  public class JamesButton : Button
    {
        static JamesButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(JamesButton), new FrameworkPropertyMetadata(typeof(JamesButton)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            Border Border = GetTemplateChild("bd") as Border;
        }
    }
}
