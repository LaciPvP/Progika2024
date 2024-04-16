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

namespace tortek
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

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            int szamlalo = 0;
            try
            {
                szamlalo = Convert.ToInt32(textbox1.Text);
                
            }

            catch 
            {
            }


            int nevezo = 0;
            try
            {
                nevezo = Convert.ToInt32(textbox2.Text);

            }

            catch
            {
            }
            if (nevezo != 0 && szamlalo % nevezo == 0)
            {
                textblock1.Text = (szamlalo / nevezo).ToString();
            }

            else if (nevezo != 0 && szamlalo % nevezo != 0)
            {
                textblock1.Text = "Nem egész";
            }

            else 
            {
                textblock1.Text = "Nullával való osztás";
            }
            

        }

        private void textbox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
