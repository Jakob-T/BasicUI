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
using System.Windows.Shapes;

namespace BasicUI
{
    /// <summary>
    /// Interaction logic for Zaposljavanje.xaml
    /// </summary>
    public partial class Zaposljavanje : Window
    {
        public string[] Odjeli { get; set; }
        public string[] Zanimanja { get; set; }
        public Zaposljavanje()
        {
            
            InitializeComponent();
            Odjeli = new string[] {"Web Development", "Software Development", "Knjigovodstvo", "Odrzavanje", "Uprava"};
            Zanimanja = new string[] {"Knjigovoda","Tajnik","Tajnica","Izvrsni Direktor","Tehnicka Podrska","Domar","Software Developer","Frontend Developer","Backend Developer"};
            DataContext = this;
        }

        private void GumbSpremi_Click(object sender, RoutedEventArgs e)
        {
            List<Zaposlenici> lista = SqliteDataAccess.LoadPeople();

            SqliteDataAccess.InsertPeople(lista.Last().Id+1,TextboxIme.Text, TextboxPrezime.Text, TextboxKontakt.Text, ComboboxOdjel.Text , ComboboxZanimanja.Text);
            
        }
    }
}
