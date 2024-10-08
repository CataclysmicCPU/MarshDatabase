using DarkModeForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarshDatabase
{
    public partial class ReadData : Form
    {
        public ReadData()
        {
            InitializeComponent();
            DarkModeCS DM = new DarkModeCS(this);
            DM.ApplyTheme(true);
        }

        //private void ReadData_Load(object sender, EventArgs e)
        //{

        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReadData_Load(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
