using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;


namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string host = "localhost";
            int port = 3306;
            string database = "milk_fabric";
            string username = "root";
            string password = "Qwerty2003dima!";

            MySqlConnection conn = DBMySQLUtils.GetDBConnection(host, port, database, username, password);
            conn.Open();

            MySqlDataAdapter adapter = new MySqlDataAdapter(
                textBox1.Text,
                conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
