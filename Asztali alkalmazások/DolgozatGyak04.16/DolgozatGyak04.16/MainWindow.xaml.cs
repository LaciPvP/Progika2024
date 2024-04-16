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

namespace DolgozatGyak04._16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            combobox.Items.Add("Lány");
            combobox.Items.Add("Fiú");

            combobox1.Items.Add("Nagyatád");
            combobox1.Items.Add("Kutas");
            combobox1.Items.Add("Berzence");
            combobox1.Items.Add("Segesd");
            combobox1.Items.Add("Somogyszob");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listbox.Items.Add("Név: " + textbox1.Text);
            listbox.Items.Add("Cím: " + textbox2.Text);
            listbox.Items.Add("Életkor: " + textbox3.Text);
            listbox.Items.Add("Neme: " + combobox.SelectedItem);
            listbox.Items.Add("Lakhelye: " + combobox1.SelectedItem);
        }
    }
}
