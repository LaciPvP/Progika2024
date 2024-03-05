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

namespace wpfGYAK2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string nev = textbox1.Text;
            string szhely = textbox2.Text;
            string kor = textbox3.Text;
            if (nev == "" || szhely == "" || kor == "")
            {
                MessageBox.Show("Töltsd ki mind!!");
            }
            else 
            {
                listbox.Items.Add(nev + ", " + szhely + ", " + kor + ", ");

                textbox1.Text = "";
                textbox2.Text = "";
                textbox3.Text = "";
            }

            private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {

            }

            private void listbox_dblclick(object sender, MouseButtonEventArgs e)
            {
                var item = ItemsControl.ContainerFromElement(sender as ListBox, e.OriginalSource as DependencyObject) as ListBoxItem;
                if (item != null)
                {
                    //System.Windows.Controls.ListBoxItem:
                    string[] sor = item.ToString().Split(", ");
                    textbox1.Text = sor[0].Substring(37);
                    textbox2.Text = sor[1];
                    textbox3.Text = sor[2];
                }
            }

        }
    }
}
