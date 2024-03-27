using System;
using System.Collections.Generic;
using System.IO;
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

namespace LatinTancokWPF
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

        List<Par> tancok = new List<Par>();

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader olvas = new StreamReader("tancrenD.txt");
            while (!olvas.EndOfStream) 
            {
                string[] sorok = new string[3];
                for (int i = 0; i < sorok.Length; i++)
                {
                    sorok[i] = olvas.ReadLine();
                
                }
                tancok.Add(new Par(sorok[0], sorok[1], sorok[2]));
            }

            olvas.Close();

            List<string> tancNevek = new List<string>();
            for (int i = 0; i < tancok.Count; i++) 
            {
                if (!tancNevek.Contains(tancok[i].tanc)) 
                {
                    tancNevek.Add(tancok[i].tanc);
                }
            
            }
        }

        
    
        

        private void gomb_Click(object sender, RoutedEventArgs e)
        {
            string szoveg = "Első tánc: " + tancok[0].tanc + ", az utolsó tánc: " + tancok[tancok.Count -1].tanc;
            textBlock.Text = szoveg;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private int tancSzamol(string tanc) 
        {
            int db = 0;
            for (int i = 0; i < tancok.Count; i++) 
            {
                if (tancok[i].tanc == tanc) 
                {
                    db++;
                }
            }

            return db;
        
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox lb = sender as ListBox;
            string partner = "Ilyet nem táncolt";
            //label1.Content=tancSzamol(lb.SelectedItem.ToString());
            for (int i = 0; tancok.Count > 0; i++) 
            {
                if (tancok[i].lany == "Vilma")
                {
                    if (tancok[i].tanc == lb.SelectedItem.ToString()) 
                    {
                        partner = tancok[i].fiu;
                        
                    }
                
                }
            }
            label5.Content = partner;


        }
    }
}
