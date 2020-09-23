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
        //private string LoadPeopleList()
        //{
        //    var firstl = SQLiteDataAccess.LoadFirstLine();
        //    return firstl;
        //}
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._555;

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

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
