using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SCADA
{
    public partial class DataQueryForm : Form
    {
        public DataQueryForm()
        {
            InitializeComponent();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            string query = "select * from DATASCADA where _DAY = @_day";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetAllData(query).Tables[0];
 
        }

        // connection string
        DataSet GetAllData(string query)
        {
            DataSet data = new DataSet();

            // Sqlconnection
            string _day = dateTimePicker1.Value.ToString();

            
            using(SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@_day", _day);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            // //  Sqlcommand
            // SqlDataAdapter
            return data;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {         
            string query = "insert into dbo.DATASCADA(ID,DATA,[_DAY]) VALUES ('"+txbId.Text+"','"+txbData.Text+"','"+dateTimePicker2.Value.ToString()+"')";
            GetAllData(query);
        }
    }
}
