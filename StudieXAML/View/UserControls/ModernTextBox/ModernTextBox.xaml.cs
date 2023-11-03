using System.Windows;
using System.Windows.Controls;

namespace StudieXAML.View.UserControls.ModernTextBox
{
    public partial class ModernTextBox : UserControl
    {
        public ModernTextBox()
        {
            InitializeComponent();
        }

        private string placeholder;

        public string Placeholder
        {
            get { return placeholder; }
            set 
            {   placeholder = value; 
                tbPlaceholder.Text = placeholder;
            } 
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(input.Text))
            {
                tbPlaceholder.Visibility = Visibility.Visible;
            }
            else
            {
                tbPlaceholder.Visibility = Visibility.Hidden;
            }
        }
    }
}
