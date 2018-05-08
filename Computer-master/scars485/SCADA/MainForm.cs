using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SCADA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lbTenNhom.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
            btnExit.BackColor = System.Drawing.Color.Transparent;
            btnRequest.BackColor = System.Drawing.Color.Transparent;
          
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to quit?", "NQN", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            RequestForm _requestForm = new RequestForm();
            _requestForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScadaForm _scadaForm = new ScadaForm();
            _scadaForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataQueryForm _queryForm = new DataQueryForm();
            _queryForm.ShowDialog();
        }    

    }
}
