using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinemaBiletSatisUygulamasi
{
    public partial class Form1 : Form
    {
        public int misiradet,cayadet,kolaadet,biletadet,tutar,kasa, sonkasa;
        public static int i = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            misiradet = Convert.ToInt32(misirgiris.Value);
            cayadet = Convert.ToInt32(caygiris.Value);
            kolaadet = Convert.ToInt32(kolagiris.Value);
            biletadet = Convert.ToInt32(biletgiris.Value);
            sonkasa = (int)Convert.ToUInt32(label10.Text);
            if (misiradet== 0 && cayadet == 0 && kolaadet == 0 && biletadet == 0 )
            {
                MessageBox.Show("Ürün girişi yoksa fiş kesilmez");
            }
            else
            {

            
           
            tutar = (5 * misiradet) + (2 * cayadet) + (4 * kolaadet) + (10 * biletadet);
          
            richTextBox1.AppendText(Environment.NewLine + "Fiş No: " + i + "\n" + "Tutar : " + tutar + "Tl"); 
            i++;
            kasa = tutar + sonkasa; 
              label10.Text = kasa.ToString();
                temizle();
            }
        }

        private void temizle()
        {
            misirgiris.Value = 0;
            caygiris.Value = 0;
            kolagiris.Value = 0;
            biletgiris.Value = 0;

        }
    }
}
