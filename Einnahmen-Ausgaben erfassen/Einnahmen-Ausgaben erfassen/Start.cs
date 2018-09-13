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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void eingabeBTN_Click(object sender, EventArgs e)
        {
            Hide();
            using (Eingabe Keks = new Eingabe())
                Keks.ShowDialog();

            Show();
        }

        private void ausgabeBTN_Click(object sender, EventArgs e)
        {
            Hide();
            using (Ausgabe Keks = new Ausgabe())
                Keks.ShowDialog();

            Show();
        }
    }
}
