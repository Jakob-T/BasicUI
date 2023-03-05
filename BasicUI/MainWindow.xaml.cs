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
using System.Data.SqlClient;
using System.Data;

namespace BasicUI
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
        

        private void Button_Click_Zaposlenici(object sender, RoutedEventArgs e)
        {
            
            List<Zaposlenik> lista=SqliteDataAccess.LoadPeople();

            ZaposleniciWin zaposleniciWin = new ZaposleniciWin();

            

            
            zaposleniciWin.Osoba1_ID.Text = "ID: " + lista[0].Id.ToString();
            zaposleniciWin.Osoba1_Ime.Text = lista[0].Ime + " " + lista[0].Prezime;
            zaposleniciWin.Osoba1_Kontakt.Text = "Kontakt: " + lista[0].Kontakt;
            zaposleniciWin.Osoba1_Odjel.Text = "Odjel: " + lista[0].Odjel;
            zaposleniciWin.Osoba1_Zanimanje.Text = "Zanimanje: " + lista[0].Zanimanje;
            

            zaposleniciWin.Osoba2_ID.Text = "ID: "+lista[1].Id.ToString();
            zaposleniciWin.Osoba2_Ime.Text = lista[1].Ime+" "+lista[1].Prezime;
            zaposleniciWin.Osoba2_Kontakt.Text = "Kontakt: "+lista[1].Kontakt;
            zaposleniciWin.Osoba2_Odjel.Text = "Odjel: " + lista[1].Odjel;
            zaposleniciWin.Osoba2_Zanimanje.Text ="Zanimanje: "+ lista[1].Zanimanje;

            zaposleniciWin.Osoba3_ID.Text = "ID: " + lista[2].Id.ToString();
            zaposleniciWin.Osoba3_Ime.Text = lista[2].Ime + " " + lista[2].Prezime;
            zaposleniciWin.Osoba3_Kontakt.Text = "Kontakt: " + lista[2].Kontakt;
            zaposleniciWin.Osoba3_Odjel.Text = "Odjel: " + lista[2].Odjel;
            zaposleniciWin.Osoba3_Zanimanje.Text = "Zanimanje: " + lista[2].Zanimanje;

            zaposleniciWin.Osoba4_ID.Text = "ID: " + lista[3].Id.ToString();
            zaposleniciWin.Osoba4_Ime.Text = lista[3].Ime + " " + lista[3].Prezime;
            zaposleniciWin.Osoba4_Kontakt.Text = "Kontakt: " + lista[3].Kontakt;
            zaposleniciWin.Osoba4_Odjel.Text = "Odjel: " + lista[3].Odjel;
            zaposleniciWin.Osoba4_Zanimanje.Text = "Zanimanje: " + lista[3].Zanimanje;

            zaposleniciWin.Osoba5_ID.Text = "ID: " + lista[4].Id.ToString();
            zaposleniciWin.Osoba5_Ime.Text = lista[4].Ime + " " + lista[4].Prezime;
            zaposleniciWin.Osoba5_Kontakt.Text = "Kontakt: " + lista[4].Kontakt;
            zaposleniciWin.Osoba5_Odjel.Text = "Odjel: " + lista[4].Odjel;
            zaposleniciWin.Osoba5_Zanimanje.Text = "Zanimanje: " + lista[4].Zanimanje;

            zaposleniciWin.Osoba6_ID.Text = "ID: " + lista[5].Id.ToString();
            zaposleniciWin.Osoba6_Ime.Text = lista[5].Ime + " " + lista[5].Prezime;
            zaposleniciWin.Osoba6_Kontakt.Text = "Kontakt: " + lista[5].Kontakt;
            zaposleniciWin.Osoba6_Odjel.Text = "Odjel: " + lista[5].Odjel;
            zaposleniciWin.Osoba6_Zanimanje.Text = "Zanimanje: " + lista[5].Zanimanje;

            zaposleniciWin.Osoba7_ID.Text = "ID: " + lista[6].Id.ToString();
            zaposleniciWin.Osoba7_Ime.Text = lista[6].Ime + " " + lista[6].Prezime;
            zaposleniciWin.Osoba7_Kontakt.Text = "Kontakt: " + lista[6].Kontakt;
            zaposleniciWin.Osoba7_Odjel.Text = "Odjel: " + lista[6].Odjel;
            zaposleniciWin.Osoba7_Zanimanje.Text = "Zanimanje: " + lista[6].Zanimanje;
            
            zaposleniciWin.Osoba8_ID.Text = "ID: " + lista[7].Id.ToString();
            zaposleniciWin.Osoba8_Ime.Text = lista[7].Ime + " " + lista[7].Prezime;
            zaposleniciWin.Osoba8_Kontakt.Text = "Kontakt: " + lista[7].Kontakt;
            zaposleniciWin.Osoba8_Odjel.Text = "Odjel: " + lista[7].Odjel;
            zaposleniciWin.Osoba8_Zanimanje.Text = "Zanimanje: " + lista[7].Zanimanje;

            zaposleniciWin.Osoba9_ID.Text = "ID: " + lista[8].Id.ToString();
            zaposleniciWin.Osoba9_Ime.Text = lista[8].Ime + " " + lista[8].Prezime;
            zaposleniciWin.Osoba9_Kontakt.Text = "Kontakt: " + lista[8].Kontakt;
            zaposleniciWin.Osoba9_Odjel.Text = "Odjel: " + lista[8].Odjel;
            zaposleniciWin.Osoba9_Zanimanje.Text = "Zanimanje: " + lista[8].Zanimanje;

            zaposleniciWin.Osoba10_ID.Text = "ID: " + lista[9].Id.ToString();
            zaposleniciWin.Osoba10_Ime.Text = lista[9].Ime + " " + lista[9].Prezime;
            zaposleniciWin.Osoba10_Kontakt.Text = "Kontakt: " + lista[9].Kontakt;
            zaposleniciWin.Osoba10_Odjel.Text = "Odjel: " + lista[9].Odjel;
            zaposleniciWin.Osoba10_Zanimanje.Text = "Zanimanje: " + lista[9].Zanimanje;

            zaposleniciWin.Osoba11_ID.Text = "ID: " + lista[10].Id.ToString();
            zaposleniciWin.Osoba11_Ime.Text = lista[10].Ime + " " + lista[10].Prezime;
            zaposleniciWin.Osoba11_Kontakt.Text = "Kontakt: " + lista[10].Kontakt;
            zaposleniciWin.Osoba11_Odjel.Text = "Odjel: " + lista[10].Odjel;
            zaposleniciWin.Osoba11_Zanimanje.Text = "Zanimanje: " + lista[10].Zanimanje;

            zaposleniciWin.Show();

            
            

        }

        private void Button_Click_Novosti(object sender, RoutedEventArgs e)
        {
            Novosti novosti = new Novosti();

            novosti.Show();
        }

        private void Podrska_Click(object sender, RoutedEventArgs e)
        {
            List<Zaposlenik> lista = SqliteDataAccess.LoadPeople();
            Podrska form = new Podrska();

            form.Glavni1.Text = lista[29].Ime+" "+lista[29].Prezime;
            form.Email_Glavni1.Text = lista[29].Ime+ lista[29].Prezime+"@gmail.com";
            form.Izvrsni1.Text = lista[27].Ime + " " + lista[27].Prezime;
            form.Email_Izvrsni1.Text = lista[27].Ime + lista[27].Prezime + "@gmail.com";
            form.Izvrsni2.Text = lista[28].Ime + " " + lista[28].Prezime;
            form.Email_Izvrsni2.Text = lista[28].Ime + lista[28].Prezime + "@gmail.com";

            form.Prvi.Text= lista[23].Ime + " " + lista[23].Prezime;
            form.Kontakt_Prvi.Text= lista[23].Kontakt;
            form.Drugi.Text = lista[24].Ime + " " + lista[24].Prezime;
            form.Kontakt_Drugi.Text = lista[24].Kontakt;
            form.Treci.Text = lista[25].Ime + " " + lista[25].Prezime;
            form.Kontakt_Treci.Text = lista[25].Kontakt;

            

            form.Show();
        }

        private void Ukloni_Click(object sender, RoutedEventArgs e)
        {
            Uklanjanje uklanjanje = new Uklanjanje();
            uklanjanje.Show();
        }

        private void Zaposljavanje_Click(object sender, RoutedEventArgs e)
        {
            Zaposljavanje zaposljavanje = new Zaposljavanje();


            zaposljavanje.Show();
        }
    }
}
