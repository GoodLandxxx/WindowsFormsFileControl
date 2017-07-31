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
        private List<File_class> fileeeee ;
        private List<FileInfo> FileInfos;
        private bool ischanged = false;
        public Form2()
        {
            //this.BackColor = Color.Cyan;
            //this.BackgroundImage = Image.FromFile("");
            InitializeComponent();
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;//分行
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;//列高自适应
            this.delete.Visible = false;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable d = new DataTable();
            dataGridView1.DataSource = null;
            d.Clear();
            dataGridView1.DataSource = d;
            FileHandle.clearObject();

            //dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.Automatic;
            //dataGridView1.DataSource = fileeeee;
        }
     



        private void button2_Click(object sender, EventArgs e)
        {
            this.delete.Visible = true;
            FileInfos = new List<FileInfo> { };
            FileInfos = FileHandle.ReadAllText(foldPath); 
            if ( fileeeee==null || ischanged ==true )
            {
              
                   fileeeee = FileHandle.ReadAllText(FileInfos);
              

            }
           
            this.dataGridView1.DataSource = fileeeee;
            //this.dataGridView1.Refresh();
           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

           
            MessageBox.Show("您单击的是第" + (e.RowIndex + 1) + "行第" + (e.ColumnIndex + 1) + "列！");

        }




        private void showFold()
        {
         
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "请选择文件路径";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    foldPath = dialog.SelectedPath;//文件夹路径
                }
                this.textBox1.Text = null;
                this.textBox1.Text = foldPath;
                this.textBox1.Enabled = false;
                 ischanged = true;


        }

        private void changeFilePath_Click(object sender, EventArgs e)
        {
            showFold();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            foreach(File_class fs in fileeeee)
            {
                FileHandle.AddFile(fs);
                
            }
            MessageBox.Show("chengg");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileInfos = new List<FileInfo> { };
            FileInfos = FileHandle.ReadAllText(foldPath);
            //FileHandle.SortAsFileName(foldPath);
            if (fileeeee == null || ischanged == true)
            {

                fileeeee = FileHandle.ReadAllText(FileInfos);
                //  FileHandle.clearObject();

            }

            this.dataGridView1.DataSource = fileeeee;
            
        }
    }
}
