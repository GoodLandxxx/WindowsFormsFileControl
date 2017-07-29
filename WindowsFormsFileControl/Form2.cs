using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFileControl
{

    public partial class Form2 : Form
    {
        public String foldPath;
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FileHandle.ReadAllText("D:\\搜狗高速下载");
            //DirectoryInfo folder = new DirectoryInfo(foldPath);
            //string s = FileHandle.countFileSize(folder.GetFiles()[0]);
            FileHandle.ReadAllText(foldPath);

        }  

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = FileHandle.ReadAllText(foldPath); ;
            this.dataGridView1.Refresh();
        }
    }
}
