using System;
using System.Drawing;
using WindowsFormsFileControl.Properties;

namespace WindowsFormsFileControl
{
   
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File_classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.changeFilePath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.path_label = new System.Windows.Forms.Label();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Label();
            this.ltems_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.File_classBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(877, 361);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 38);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "查询";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delete,
            this.fileNameDataGridViewTextBoxColumn,
            this.fileTypeDataGridViewTextBoxColumn,
            this.fileSizeDataGridViewTextBoxColumn,
            this.filePathDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.File_classBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(780, 387);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.dataGridView1_RowContextMenuStripNeeded);
            // 
            // delete
            // 
            this.delete.FillWeight = 50F;
            this.delete.HeaderText = "删除";
            this.delete.Image = global::WindowsFormsFileControl.Properties.Resources.ic_close_black_18dp_1x;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 50;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "fileName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.fileNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.fileNameDataGridViewTextBoxColumn.FillWeight = 96.50538F;
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "文件名";
            this.fileNameDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.fileNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // fileTypeDataGridViewTextBoxColumn
            // 
            this.fileTypeDataGridViewTextBoxColumn.DataPropertyName = "fileType";
            this.fileTypeDataGridViewTextBoxColumn.FillWeight = 10.43952F;
            this.fileTypeDataGridViewTextBoxColumn.HeaderText = "文件类型";
            this.fileTypeDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.fileTypeDataGridViewTextBoxColumn.Name = "fileTypeDataGridViewTextBoxColumn";
            this.fileTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileTypeDataGridViewTextBoxColumn.Width = 60;
            // 
            // fileSizeDataGridViewTextBoxColumn
            // 
            this.fileSizeDataGridViewTextBoxColumn.DataPropertyName = "handlefileSize";
            this.fileSizeDataGridViewTextBoxColumn.FillWeight = 14.88252F;
            this.fileSizeDataGridViewTextBoxColumn.HeaderText = "文件大小";
            this.fileSizeDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.fileSizeDataGridViewTextBoxColumn.Name = "fileSizeDataGridViewTextBoxColumn";
            this.fileSizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileSizeDataGridViewTextBoxColumn.Width = 60;
            // 
            // filePathDataGridViewTextBoxColumn
            // 
            this.filePathDataGridViewTextBoxColumn.DataPropertyName = "filePath";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.filePathDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.filePathDataGridViewTextBoxColumn.FillWeight = 278.1726F;
            this.filePathDataGridViewTextBoxColumn.HeaderText = "文件路径";
            this.filePathDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.filePathDataGridViewTextBoxColumn.Name = "filePathDataGridViewTextBoxColumn";
            this.filePathDataGridViewTextBoxColumn.ReadOnly = true;
            this.filePathDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.filePathDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.filePathDataGridViewTextBoxColumn.Width = 500;
            // 
            // File_classBindingSource
            // 
            this.File_classBindingSource.DataSource = typeof(WindowsFormsFileControl.File_class);
            // 
            // changeFilePath
            // 
            this.changeFilePath.Location = new System.Drawing.Point(704, 403);
            this.changeFilePath.Name = "changeFilePath";
            this.changeFilePath.Size = new System.Drawing.Size(100, 23);
            this.changeFilePath.TabIndex = 5;
            this.changeFilePath.Text = "更换路径";
            this.changeFilePath.UseVisualStyleBackColor = true;
            this.changeFilePath.Click += new System.EventHandler(this.changeFilePath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "当前路径";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(877, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // path_label
            // 
            this.path_label.AutoSize = true;
            this.path_label.Location = new System.Drawing.Point(178, 408);
            this.path_label.Name = "path_label";
            this.path_label.Size = new System.Drawing.Size(65, 12);
            this.path_label.TabIndex = 10;
            this.path_label.Text = "path_label";
            // 
            // search_textBox
            // 
            this.search_textBox.Location = new System.Drawing.Point(877, 12);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(100, 21);
            this.search_textBox.TabIndex = 6;
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Location = new System.Drawing.Point(830, 15);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(29, 12);
            this.search.TabIndex = 7;
            this.search.Text = "查找";
            // 
            // ltems_label
            // 
            this.ltems_label.AutoSize = true;
            this.ltems_label.Location = new System.Drawing.Point(48, 408);
            this.ltems_label.Name = "ltems_label";
            this.ltems_label.Size = new System.Drawing.Size(0, 12);
            this.ltems_label.TabIndex = 11;
            this.ltems_label.TextAlign = ContentAlignment.BottomCenter;
            this.ltems_label.Click += new System.EventHandler(this.ltems_label_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "共";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "项";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(999, 435);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ltems_label);
            this.Controls.Add(this.path_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.search_textBox);
            this.Controls.Add(this.changeFilePath);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_search);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.File_classBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      
        #endregion
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.BindingSource File_classBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button changeFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePathDataGridViewTextBoxColumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label path_label;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.Label ltems_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}