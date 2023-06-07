using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apotekCemaraUASDataSet.Pembeli' table. You can move, or remove it, as needed.
            this.pembeliTableAdapter.Fill(this.apotekCemaraUASDataSet.Pembeli);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
