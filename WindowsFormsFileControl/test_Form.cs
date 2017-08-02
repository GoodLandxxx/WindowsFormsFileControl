using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFileControl
{
    public partial class test_Form : Form
    {
        public test_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s= this.textBox1.Text.Trim();
           DB_file.ExeuteNonQuery( DB_file.CrateDataSystem(s));
            DB_file.ExeuteNonQuery(DB_file.CreateTable(s, "jordan"));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          ) ;
        }
    }
}
