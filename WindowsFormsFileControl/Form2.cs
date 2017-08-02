using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public String foldPath = "";
        private List<File_class> fileeeee;
        private List<FileInfo> FileInfos;
        private bool pathIsChanged = false;
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
            path_label.Text = foldPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable d = new DataTable();
            dataGridView1.DataSource = null;
            d.Clear();
            dataGridView1.DataSource = d;
            FileHandle.ReFresh();

            //dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.Automatic;
            //dataGridView1.DataSource = fileeeee;
        }



        //查询事件
        private void button_search_Click(object sender, EventArgs e)
        {
            if (pathIsChanged)
            {
                DataTable d = new DataTable();
                dataGridView1.DataSource = null;
                d.Clear();
                dataGridView1.DataSource = d;
                FileHandle.ReFresh();
            }
            this.delete.Visible = true;
            FileInfos = new List<FileInfo> { };
            FileInfos = FileHandle.ReadAllText(foldPath);
            DataTable dt = FileHandle.CreateDataTable("fileInfo", FileHandle.ReadAllText(FileInfos));
            if (dt != null || pathIsChanged == true)
            {

                //fileeeee = FileHandle.ReadAllText(FileInfos);
               ;
                DB_file.SqlBulkCopyByDatatable(dt);
                DataTable d = new DataTable();
                dataGridView1.DataSource = d;
                dataGridView1.DataSource = dt;
                this.dataGridView1.Refresh();
                pathIsChanged = false;
            }
            else
            {
                showFold();
            }

            //this.dataGridView1.DataSource = fileeeee;



            //foreach (File_class fs in fileeeee)
            //{
            //    FileHandle.AddFile(fs);//写入数据库事件

            //}

            ltems_label.Text = FileInfos.Count.ToString();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            FileInfos = new List<FileInfo> { };
            FileInfos = FileHandle.ReadAllText(foldPath);
           
            FileInfos = null;
            this.dataGridView1.Refresh();
        }
        //单击DatGridView中单元格事件
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 4)
            {
                string s = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
            // MessageBox.Show("您单击的是第" + (e.RowIndex + 1) + "行第" + (e.ColumnIndex + 1) + "列！");

        }



        //显示选择文件夹
        private void showFold()
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foldPath = dialog.SelectedPath;//文件夹路径
            }
            
            pathIsChanged = true;


        }
        
        private void changeFilePath_Click(object sender, EventArgs e)
        {
            //更改路径事件
            showFold();
            path_label.Text = foldPath;

        }

        //双击DatGridView中单元格事件
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 4)
            {
                System.Diagnostics.Process.Start(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
            if (e.ColumnIndex == 1)
            {

                string s = @dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 3].Value.ToString() + '\\' + dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                Process.Start(s);
            }
        }


        //在单元格中右键事件
        private void dataGridView1_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            try {
                DataGridViewRow dataGridViewRow1 = dataGridView1.Rows[e.RowIndex];

                ToolStripMenuItem toolStripMenuItem1 = new ToolStripMenuItem("删除", null, delete_onCilck);
                toolStripMenuItem1.Enabled = true;


                ContextMenuStrip employeeMenuStrip = new ContextMenuStrip();
                employeeMenuStrip.Items.Add(toolStripMenuItem1);
                string s = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                // Show the ContextMenuStrip ContextMenuStrip based on the employees title.
                e.ContextMenuStrip = employeeMenuStrip;
                e.ContextMenuStrip.Show(MousePosition);
            }catch(Exception ex)
            { }
            }


       
        private void delete_onCilck(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("delete");
            if(result ==DialogResult.OK)
            {

            }
            else
            {

            }
        }

       

        private void path_textBox1_Click(object sender, EventArgs e)
        {
            showFold();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ltems_label_Click(object sender, EventArgs e)
        {

        }
    }
}