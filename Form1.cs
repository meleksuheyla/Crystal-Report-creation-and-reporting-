using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace CRYSTALREPORT_ARAMA_YAPMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0; Data Source=bilgiler3.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            CrystalReport1 rapor = new CrystalReport1();
            crystalReportViewer1.ReportSource = rapor;
            crystalReportViewer1.Show();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("LÜTFEN BOŞ BIRAKMA");
                return;
            
            }
            DataTable tablo = new DataTable();
            OleDbDataAdapter arama = new OleDbDataAdapter("SELECT * FROM TABLO1 WHERE ADI=A AND SOYADI=S ",baglan);
            arama.SelectCommand.Parameters.AddWithValue("A", textBox1.Text.Trim());
            arama.SelectCommand.Parameters.AddWithValue("S", textBox2.Text.Trim());
            arama.Fill(tablo);
            if (tablo.Rows.Count > 0)
            {
                CrystalReport1 rapor = new CrystalReport1();
                rapor.SetDataSource(tablo);
                crystalReportViewer1.ReportSource = rapor;

            }
            else
            {

                MessageBox.Show("GİRİLEN KAYIT BULUNMADI");
                return;
            }

        }
    }
}
