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
    public partial class Ausgabe : Form
    {
        public Ausgabe()
        {
            InitializeComponent();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ausgabe_Load(object sender, EventArgs e)
        {
            
            //create a MySQL connection with a query string
            MySqlConnection connection = new MySqlConnection("server=127.0.0.1;database=einnahmen_ausgaben;userid=root;password=''");
            MySqlCommand commandein = connection.CreateCommand();
            MySqlCommand commandaus = connection.CreateCommand();
            MySqlDataReader readerein;
            MySqlDataReader readeraus;
            commandein.CommandText = "SELECT Grund, Wert, Datum FROM buchungen WHERE einaus=1 ORDER BY Datum";

            //open the connection
            connection.Open();
            readerein = commandein.ExecuteReader();

            while (readerein.Read())
            {
                for (int i = 0; i < readerein.FieldCount; i++)
                {
                    einnahmenRTB.Text += readerein[i].ToString();
                    einnahmenRTB.Text += " ";
                }
                einnahmenRTB.Text += Environment.NewLine;
            }
            
            readerein.Close();
            commandaus.CommandText = "SELECT Grund, Wert, Datum FROM buchungen WHERE einaus=0 ORDER BY Datum";
            readeraus = commandaus.ExecuteReader();

            while (readeraus.Read())
            {
                for (int i = 0; i < readeraus.FieldCount; i++)
                {
                    ausgabenRTB.Text += readeraus[i].ToString();
                    ausgabenRTB.Text += " ";
                }
                ausgabenRTB.Text += Environment.NewLine;

            }
            readeraus.Close();
            //close the connection
            connection.Close();
        }

    }
}
