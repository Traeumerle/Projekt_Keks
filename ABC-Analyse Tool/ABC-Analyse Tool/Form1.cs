using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace ABC_Analyse_Tool
{
    public partial class Form1 : Form
    {
        MySqlConnection con;
        private string a = "Werte in Prozent", b = "Menge in Prozent", c = "Güterklasse", d = "Kumulierter Umsatz";
        private string tableDB;
        private int wert,menge,werttrbA = 63,werttrbC = 37;
        

        public Form1()
        {
            InitializeComponent();
            Form_füllen();
        }

        private void Form_füllen()
        {
            filler_combo();
            fillcomboBox();
            Datensatzauswahl(datentabellenCB);
            settrackbar();
    }
        private void settrackbar()
        {
            WerttrB1.Value = werttrbA;
            güterALBL.Text = "Güterklasse A: " + WerttrB1.Value + "%";
            Werttrb2.Value = werttrbC;
            güterBLBL.Text = "Güterklasse C: " + Werttrb2.Value + "%";
        }

        private void Mysqlconnection()
        {
            tableDB = datentabellenCB.SelectedItem.ToString();
            con = new MySqlConnection("server=127.0.0.1;DATABASE=stueckliste;uid=root;PASSWORD=;");

            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM " + tableDB, con);
            DataSet DS = new DataSet();
            adapter.Fill(DS);
            ausgabedGV.DataSource = DS.Tables[0];
            con.Close();

        }

        private void filler_combo()
        {
            datentabellenCB.Items.Add("verfügbare Datensätze");
            datentabellenCB.SelectedItem = "verfügbare Datensätze";
        }

        private void fillcomboBox()
        {  
            con = new MySqlConnection("server=127.0.0.1;DATABASE=stueckliste;uid=root;PASSWORD=;");
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SHOW TABLES;";
            MySqlDataReader reader;
            con.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    datentabellenCB.Items.Add(reader.GetValue(i).ToString());
                }
            }
            con.Close();
        }

        private void Datensatzauswahl(ComboBox datentabellenCB)
        {
            datentabellenCB.SelectedIndexChanged += new System.EventHandler(datentabellenCB_SelectedIndexChanged);
        }

        private void datentabellenCB_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (datentabellenCB.SelectedIndex != 0)
            {
                if (datentabellenCB.SelectedItem.ToString() != tableDB)
                {
                    Mysqlconnection();
                    if (ausgabedGV.ColumnCount < 8)
                    {
                        Datagridviewcolumnadd();
                    }
                    werterrechnen();
                    prozenteerrechnen();
                    rangfolgeFestlegen();
                    sortiereNachGüterklasse();
                }
            }
        }

        private void ausgabedGV_Sorted(object sender, EventArgs e)
        {
            werterrechnen();
            prozenteerrechnen();
            rangfolgeFestlegen();
        }

        private void Datagridviewcolumnadd()
        {
            ausgabedGV.Columns.Add(a, a);
            ausgabedGV.Columns.Add(b, b);
            ausgabedGV.Columns.Add(c, c);
            ausgabedGV.Columns.Add(d, d);
        }

        private void werterrechnen()
        {
            menge = 0;
            wert = 0;
            for (int i = 0; i < ausgabedGV.RowCount; i++)
            {
                menge += Convert.ToInt32(ausgabedGV.Rows[i].Cells["Menge"].Value);
                wert += Convert.ToInt32(ausgabedGV.Rows[i].Cells["Wert"].Value) * Convert.ToInt32(ausgabedGV.Rows[i].Cells["Menge"].Value);
            }
        }

        private void prozenteerrechnen()
        {
            int buffer = 0;
            for (int i = 0; i < ausgabedGV.RowCount; i++)
            {
                ausgabedGV.Rows[i].Cells[b].Value = Math.Round(Convert.ToDecimal(Convert.ToDecimal(ausgabedGV.Rows[i].Cells["Menge"].Value) * 100 / menge));
                ausgabedGV.Rows[i].Cells[a].Value = Math.Round(Convert.ToDecimal(Convert.ToDecimal(ausgabedGV.Rows[i].Cells["Wert"].Value) * Convert.ToDecimal(ausgabedGV.Rows[i].Cells["Menge"].Value)* 100 / wert));
             
                buffer += Convert.ToInt32(ausgabedGV.Rows[i].Cells[a].Value);
                ausgabedGV.Rows[i].Cells[d].Value = buffer;
            }
        }

        private void rangfolgeFestlegen()
        {
            ausgabedGV.Rows[0].Cells[c].Value = "A";
            for (int i = 1; i < ausgabedGV.RowCount; i++)
            {
                if (Convert.ToInt32(ausgabedGV.Rows[i].Cells[d].Value) <= werttrbA)
                {
                    ausgabedGV.Rows[i].Cells[c].Value = "A";
                }
                else if (Convert.ToInt32(ausgabedGV.Rows[i].Cells[d].Value) > 90)
                {
                    ausgabedGV.Rows[i].Cells[c].Value = "C";
                }
                else if (Convert.ToInt32(ausgabedGV.Rows[i].Cells[d].Value) <= 90)
                {
                    ausgabedGV.Rows[i].Cells[c].Value = "B";
                }
            }
        }

        private void sortiereNachGüterklasse()
        {
            ausgabedGV.Sort(ausgabedGV.Columns["Wert"], ListSortDirection.Descending);
        }

        private void WerttrB1_Scroll(object sender, EventArgs e)
        {
            güterALBL.Text = "Güterklasse A: " + WerttrB1.Value + "%";
            güterBLBL.Text = "Güterklasse C: " + Werttrb2.Value + "%";
            Werttrb2.Value =  100 - WerttrB1.Value;
            werttrbA = WerttrB1.Value;
            rangfolgeFestlegen();

        }

        private void Werttrb2_Scroll(object sender, EventArgs e)
        {
            güterALBL.Text = "Güterklasse A: " + WerttrB1.Value + "%";
            güterBLBL.Text = "Güterklasse C: " + Werttrb2.Value + "%";
            WerttrB1.Value = 100 - Werttrb2.Value;
            //werttrbC = Werttrb2.Value;
            rangfolgeFestlegen();
        }

        private void speichernBTN_Click(object sender, EventArgs e)
        {
            dgvalsPdfspeichern();

        }

        private void dgvalsPdfspeichern()
        {
            if (filepathTB.Text != "" && ausgabedGV.RowCount != 0)
            {
                PdfPTable pdfTable = new PdfPTable(ausgabedGV.ColumnCount);
                float[] widths = new float[] { 30f, 120f, 80f, 80f, 100f, 100f, 100f, 100f };
                pdfTable.SetWidths(widths);
                pdfTable.DefaultCell.Padding = 1;
                pdfTable.WidthPercentage = 100;
                pdfTable.DefaultCell.BorderWidth = 1;

                //Adding Header row
                foreach (DataGridViewColumn column in ausgabedGV.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    pdfTable.AddCell(cell);
                }

                //Adding DataRow
                foreach (DataGridViewRow row in ausgabedGV.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                }

                //Exporting to PDF
                string folderPath = "C:\\Users\\StichlTo\\Desktop\\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (FileStream stream = new FileStream(folderPath + filepathTB.Text + ".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
                MessageBox.Show("Ihre Datei wurde Erfolgreich gespeichert unter: " + folderPath + filepathTB.Text + ".pdf");
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Dateinamen ein und wählen Sie einen Datensatz aus!");
            }
        }
    }
}
