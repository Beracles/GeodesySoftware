namespace MySystem
{
    partial class Get_Parameter_Form
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
            this.Input_gpBx = new System.Windows.Forms.GroupBox();
            this.Get_Parameter_dgv = new System.Windows.Forms.DataGridView();
            this.X1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Get_Parameter_cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Import_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Import_Excel_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Import_txt_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Export_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Export_Excel_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Export_txt_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Calc_btn = new System.Windows.Forms.Button();
            this.tip_lbl = new System.Windows.Forms.Label();
            this.Input_gpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Get_Parameter_dgv)).BeginInit();
            this.Get_Parameter_cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // Input_gpBx
            // 
            this.Input_gpBx.Controls.Add(this.Get_Parameter_dgv);
            this.Input_gpBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Input_gpBx.Location = new System.Drawing.Point(30, 30);
            this.Input_gpBx.Name = "Input_gpBx";
            this.Input_gpBx.Size = new System.Drawing.Size(825, 300);
            this.Input_gpBx.TabIndex = 0;
            this.Input_gpBx.TabStop = false;
            this.Input_gpBx.Text = "输入";
            // 
            // Get_Parameter_dgv
            // 
            this.Get_Parameter_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Get_Parameter_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X1,
            this.Y1,
            this.Z1,
            this.X2,
            this.Y2,
            this.Z2});
            this.Get_Parameter_dgv.ContextMenuStrip = this.Get_Parameter_cms;
            this.Get_Parameter_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Get_Parameter_dgv.Location = new System.Drawing.Point(3, 22);
            this.Get_Parameter_dgv.Name = "Get_Parameter_dgv";
            this.Get_Parameter_dgv.RowTemplate.Height = 23;
            this.Get_Parameter_dgv.Size = new System.Drawing.Size(819, 275);
            this.Get_Parameter_dgv.TabIndex = 0;
            this.Get_Parameter_dgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Get_Parameter_dgv_RowsAdded);
            this.Get_Parameter_dgv.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.Get_Parameter_dgv_RowsRemoved);
            // 
            // X1
            // 
            this.X1.HeaderText = "X1";
            this.X1.Name = "X1";
            this.X1.Width = 120;
            // 
            // Y1
            // 
            this.Y1.HeaderText = "Y1";
            this.Y1.Name = "Y1";
            this.Y1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Y1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Y1.Width = 120;
            // 
            // Z1
            // 
            this.Z1.HeaderText = "Z1";
            this.Z1.Name = "Z1";
            this.Z1.Width = 120;
            // 
            // X2
            // 
            this.X2.HeaderText = "X2";
            this.X2.Name = "X2";
            this.X2.Width = 120;
            // 
            // Y2
            // 
            this.Y2.HeaderText = "Y2";
            this.Y2.Name = "Y2";
            this.Y2.Width = 120;
            // 
            // Z2
            // 
            this.Z2.HeaderText = "Z2";
            this.Z2.Name = "Z2";
            this.Z2.Width = 120;
            // 
            // Get_Parameter_cms
            // 
            this.Get_Parameter_cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Import_tsmi,
            this.Export_tsmi});
            this.Get_Parameter_cms.Name = "Transfer_Parameter_cms";
            this.Get_Parameter_cms.Size = new System.Drawing.Size(149, 48);
            // 
            // Import_tsmi
            // 
            this.Import_tsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Import_Excel_tsmi,
            this.Import_txt_tsmi});
            this.Import_tsmi.Name = "Import_tsmi";
            this.Import_tsmi.Size = new System.Drawing.Size(148, 22);
            this.Import_tsmi.Text = "从文件导入点";
            // 
            // Import_Excel_tsmi
            // 
            this.Import_Excel_tsmi.Name = "Import_Excel_tsmi";
            this.Import_Excel_tsmi.Size = new System.Drawing.Size(105, 22);
            this.Import_Excel_tsmi.Text = "Excel";
            this.Import_Excel_tsmi.Click += new System.EventHandler(this.Import_Excel_tsmi_Click);
            // 
            // Import_txt_tsmi
            // 
            this.Import_txt_tsmi.Name = "Import_txt_tsmi";
            this.Import_txt_tsmi.Size = new System.Drawing.Size(105, 22);
            this.Import_txt_tsmi.Text = "txt";
            // 
            // Export_tsmi
            // 
            this.Export_tsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Export_Excel_tsmi,
            this.Export_txt_tsmi});
            this.Export_tsmi.Name = "Export_tsmi";
            this.Export_tsmi.Size = new System.Drawing.Size(148, 22);
            this.Export_tsmi.Text = "导出点到文件";
            // 
            // Export_Excel_tsmi
            // 
            this.Export_Excel_tsmi.Name = "Export_Excel_tsmi";
            this.Export_Excel_tsmi.Size = new System.Drawing.Size(105, 22);
            this.Export_Excel_tsmi.Text = "Excel";
            // 
            // Export_txt_tsmi
            // 
            this.Export_txt_tsmi.Name = "Export_txt_tsmi";
            this.Export_txt_tsmi.Size = new System.Drawing.Size(105, 22);
            this.Export_txt_tsmi.Text = "txt";
            // 
            // Calc_btn
            // 
            this.Calc_btn.Enabled = false;
            this.Calc_btn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Calc_btn.Location = new System.Drawing.Point(400, 400);
            this.Calc_btn.Name = "Calc_btn";
            this.Calc_btn.Size = new System.Drawing.Size(80, 35);
            this.Calc_btn.TabIndex = 1;
            this.Calc_btn.Text = "计算";
            this.Calc_btn.UseVisualStyleBackColor = true;
            this.Calc_btn.Click += new System.EventHandler(this.Calc_btn_Click);
            // 
            // tip_lbl
            // 
            this.tip_lbl.AutoSize = true;
            this.tip_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tip_lbl.Location = new System.Drawing.Point(30, 333);
            this.tip_lbl.Name = "tip_lbl";
            this.tip_lbl.Size = new System.Drawing.Size(715, 16);
            this.tip_lbl.TabIndex = 3;
            this.tip_lbl.Text = "提示：请分别输入公共点在已知椭球体下的坐标(X1,Y1,Z1)和目标椭球体下的坐标(X2,Y2,Z2)";
            // 
            // Get_Parameter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.tip_lbl);
            this.Controls.Add(this.Calc_btn);
            this.Controls.Add(this.Input_gpBx);
            this.Name = "Get_Parameter_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "求参数";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Get_Parameter_Form_FormClosing);
            this.Input_gpBx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Get_Parameter_dgv)).EndInit();
            this.Get_Parameter_cms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Input_gpBx;
        private System.Windows.Forms.DataGridView Get_Parameter_dgv;
        private System.Windows.Forms.Button Calc_btn;
        private System.Windows.Forms.ContextMenuStrip Get_Parameter_cms;
        private System.Windows.Forms.ToolStripMenuItem Import_tsmi;
        private System.Windows.Forms.ToolStripMenuItem Import_Excel_tsmi;
        private System.Windows.Forms.ToolStripMenuItem Import_txt_tsmi;
        private System.Windows.Forms.ToolStripMenuItem Export_tsmi;
        private System.Windows.Forms.ToolStripMenuItem Export_Excel_tsmi;
        private System.Windows.Forms.ToolStripMenuItem Export_txt_tsmi;
        private System.Windows.Forms.DataGridViewTextBoxColumn X1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z2;
        private System.Windows.Forms.Label tip_lbl;
    }
}