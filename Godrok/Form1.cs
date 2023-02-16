using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//file beolvasás

namespace Godrok
{
    public partial class Form1 : Form
    {

        List<int> adatok = new List<int>();
        float erintetlen = 0f;

        public Form1()
        {
            InitializeComponent();
        }

        private void adatokbeolv_btn_Click(object sender, EventArgs e)
        {
            StreamReader olvas = new StreamReader("melyseg.txt");
            string line;
            line = olvas.ReadLine();
            while( line != null)
            {
                adatok.Add(int.Parse(line));
                if (line == "0")
                    erintetlen++;
                ki_lb.Items.Add(adatok.Count() + ".\t" + line);
                line= olvas.ReadLine();
            }
            feladat1_lbl.Text = adatok.Count() + "db adat beolvasva!";
        }

        private void feladat2_btn_Click(object sender, EventArgs e)
        {
            int tav = int.Parse(tav_tb.Text);

            feladat2_lbl.Text = adatok[tav-1] + " mély ott a gödör";
        }

        private void feladat3_btn_Click(object sender, EventArgs e)
        {
            float szazalek = erintetlen / adatok.Count() * 100;
            feladat3_lbl.Text = szazalek + "%";
            
        }
    }
}
