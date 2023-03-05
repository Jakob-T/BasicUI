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
    /// Interaction logic for Uklanjanje.xaml
    /// </summary>
    public partial class Uklanjanje : Window
    {
        private List<Zaposlenik> lista = SqliteDataAccess.LoadPeople();
        private Dictionary<int, Zaposlenik> rjecnik = new Dictionary<int, Zaposlenik>();
        
        
        public Uklanjanje()
        {
            InitializeComponent();
            
            foreach(Zaposlenik zaposlenik in lista)
            {
                ComboboxID.Items.Add(zaposlenik.Id);

            }
            for(int i = 1; i<lista.Count(); i++)
            {
                rjecnik.Add(lista[i].Id,lista[i]);
            }

            DataContext = this;
            
        }

        private void GumbGeneriraj_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(ComboboxID.Text))
            {
                MessageBox.Show("Niste odabrali osobu");
            }
            else
            {
                int pozicija = Convert.ToInt32(ComboboxID.Text);
                TextblockIme.Text = rjecnik[pozicija].Ime;
                TextblockPrezime.Text = rjecnik[pozicija].Prezime;
                TextblockKontakt.Text = rjecnik[pozicija].Kontakt;
                TextblockOdjel.Text = rjecnik[pozicija].Odjel;
                TextblockZanimanje.Text = rjecnik[pozicija].Zanimanje;
            }
            
        }
        private void GumbUkloni_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(ComboboxID.Text))
            {
                MessageBox.Show("Niste odabrali osobu");
            }
            else
            {
                if (MessageBox.Show("Jeste li sigurni?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    SqliteDataAccess.RemovePeople(Convert.ToInt32(ComboboxID.Text));
                    
                    this.Close();
                }
            }
        }

    }
}
