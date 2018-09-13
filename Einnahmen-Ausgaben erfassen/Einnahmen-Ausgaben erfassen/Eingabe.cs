using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Einnahmen_Ausgaben_erfassen
{
    public partial class Eingabe : Form
    {
        public Eingabe()
        {
            InitializeComponent();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private int Einaus(int einaus)
        {
            if (einnahmenRBTN.Checked == true)
            {
                einaus = 1;
            }
            else if (ausgabenRBTN.Checked == true)
            {
                einaus = 0;
            }
            else
            {
                MessageBox.Show("Bitte wählen sie Einnahme oder Ausgabe aus!");
            }
            return einaus;
        }
        private void saveBTN_Click_1(object sender, EventArgs e)
        {
            if (grundTB.Text != "" && datumjahrTB.Text != "" && datummonatTB.Text != "" && datumtagTB.Text != "" && wertTB.Text != "")
            {
                string grund = grundTB.Text;
                string datum, wert;
                int einaus;
                einaus = Einaus(0);
                datum = datumjahrTB.Text +"."+ datummonatTB.Text + "." + datumtagTB.Text;
                wert = string.Format("€{0:N2} Euro", wertTB.Text);
                //create a MySQL connection with a query string
                MySqlConnection connection = new MySqlConnection("server=127.0.0.1;database=einnahmen_ausgaben;userid=root;password=''");
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT into buchungen (Grund, einaus, Wert, Datum) values ('" + grund + "','" + einaus + "','" + wert + "','" + datum + "')";

                //open the connection
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Speichern Erfolgreich!");

                //close the connection
                connection.Close();
                datumjahrTB.Text = "JJJJ";
                datummonatTB.Text = "MM";
                datumtagTB.Text = "TT";
                grundTB.Clear();
                wertTB.Clear();
                grundTB.Focus();
                
            }
            else
            {
                MessageBox.Show("Bitte fülle alle Felder aus!");
            }

        }
    }
}
