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
    public partial class Form1 : Form
    {
        public String foldPath =null;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            showFold();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (foldPath != null && foldPath !="")
            {
                Form2 form2 = new Form2();
                form2.foldPath = foldPath;
                form2.Show();
                this.Dispose(false);
            }
            else
            {
                showFold();
                
            }
         
  
           
        }

        void showFold()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foldPath = dialog.SelectedPath;//文件夹路径

            }

            this.textBox1.Text = foldPath;
            this.textBox1.Enabled = false;
        }
    }
}
