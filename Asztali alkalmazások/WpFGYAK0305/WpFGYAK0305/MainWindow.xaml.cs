using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpFGYAK0305
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBlock.Text = textBox.Text;
            if (checkBox.IsChecked == true)
            {
                textBlock.Text = textBlock.Text.ToUpper();
            }
            else 
            {
            
            }
            
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            textBlock.Text = textBlock.Text.ToUpper(); 
            textBox.Focus();
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            textBlock.Text = textBox.Text;
            textBox.Focus();

        }
    }
}
