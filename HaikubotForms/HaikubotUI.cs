using PoemLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;

namespace HaikubotForms
{
    public partial class HaikubotUI : Form
    {
        //PoemGenerate haiku = new PoemGenerate();
        //SQLiteDataAccess SQLDA = new SQLiteDataAccess();

        public HaikubotUI()
        {

            InitializeComponent();
        }

        private void btnHaiku_Click(object sender, EventArgs e)
        {
            //string førstetext = haiku.CreateHaiku();
            //MessageBox.Show(førstetext.ToString());

            SQLiteConnection con = new SQLiteConnection(@"data source=C:\Users\Mathias\Desktop\PraktikProjekt\HaikubotForms-master\HaikubotForms\HaikuLines.db");
            con.Open();
            string query = "SELECT FirstHaikuLine FROM FirstLine ORDER BY RANDOM() LIMIT 1; ";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\Users\Mathias\Desktop\PraktikProjekt\HaikubotForms-master\HaikubotForms\HaikuLines.db");
            con.Open();
            string query = "SELECT SecondHaikuLine FROM SecondLine ORDER BY RANDOM() LIMIT 1; ";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dataGridView2.DataSource = dt;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\Users\Mathias\Desktop\PraktikProjekt\HaikubotForms-master\HaikubotForms\HaikuLines.db");
            con.Open();
            string query = "SELECT  ThirdHaikuLine FROM ThirdLine ORDER BY RANDOM() LIMIT 1; ";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            dataGridView3.DataSource = dt;
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\Users\Mathias\Desktop\PraktikProjekt\HaikubotForms-master\HaikubotForms\HaikuLines.db");
            con.Open();
            string query = "SELECT  ThirdHaikuLine FROM ThirdLine ORDER BY RANDOM() LIMIT 1; ";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            //listView1.ToString = dt;

        }

        private void Samlet_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=C:\Users\Mathias\Desktop\PraktikProjekt\HaikubotForms-master\HaikubotForms\HaikuLines.db");
            con.Open();
            string query = "SELECT FirstHaikuLine FROM FirstLine ORDER BY RANDOM() LIMIT 1; ";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            DataTable dt1 = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt1);

            dataGridView1.DataSource = dt1;

            SQLiteConnection con2 = new SQLiteConnection(@"data source=C:\Users\Mathias\Desktop\PraktikProjekt\HaikubotForms-master\HaikubotForms\HaikuLines.db");
            con2.Open();
            string query2 = "SELECT SecondHaikuLine FROM SecondLine ORDER BY RANDOM() LIMIT 1; ";
            SQLiteCommand cmd2 = new SQLiteCommand(query2, con2);
            DataTable dt2 = new DataTable();
            SQLiteDataAdapter adapter2 = new SQLiteDataAdapter(cmd2);
            adapter2.Fill(dt2);

            dataGridView2.DataSource = dt2;

            SQLiteConnection con3 = new SQLiteConnection(@"data source=C:\Users\Mathias\Desktop\PraktikProjekt\HaikubotForms-master\HaikubotForms\HaikuLines.db");
            con3.Open();
            string query3 = "SELECT  ThirdHaikuLine FROM ThirdLine ORDER BY RANDOM() LIMIT 1; ";
            SQLiteCommand cmd3 = new SQLiteCommand(query3, con3);
            DataTable dt3 = new DataTable();
            SQLiteDataAdapter adapter3 = new SQLiteDataAdapter(cmd3);
            adapter3.Fill(dt3);

            dataGridView3.DataSource = dt3;

        }
    }
}
