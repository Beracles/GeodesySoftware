namespace MySystem
{
    partial class Ellipsoid_Transfer_Form
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
            this.Target_Ellipsoid_lbl = new System.Windows.Forms.Label();
            this.Known_Ellipsoid_lbl = new System.Windows.Forms.Label();
            this.Target_Ellipsoid_cbBx = new System.Windows.Forms.ComboBox();
            this.Known_Ellipsoid_cbBx = new System.Windows.Forms.ComboBox();
            this.Transfer_btn = new System.Windows.Forms.Button();
            this.Ellipsoid_Transfer_ms = new System.Windows.Forms.MenuStrip();
            this.Menu_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Get_Parameter_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Search_Parameter_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Import_Parameter_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Export_Parameter_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Coordinate_System_lbl = new System.Windows.Forms.Label();
            this.Coordinate_System_cbBx = new System.Windows.Forms.ComboBox();
            this.Output_gpBx = new System.Windows.Forms.GroupBox();
            this.z2_Meter_lbl = new System.Windows.Forms.Label();
            this.y2_Min_txtBx = new System.Windows.Forms.TextBox();
            this.y2_Sec_txtBx = new System.Windows.Forms.TextBox();
            this.y2_Min_lbl = new System.Windows.Forms.Label();
            this.y2_Deg_lbl = new System.Windows.Forms.Label();
            this.z2_lbl = new System.Windows.Forms.Label();
            this.y2_lbl = new System.Windows.Forms.Label();
            this.x2_lbl = new System.Windows.Forms.Label();
            this.z2_txtBx = new System.Windows.Forms.TextBox();
            this.x2_Sec_txtBx = new System.Windows.Forms.TextBox();
            this.x2_Min_txtBx = new System.Windows.Forms.TextBox();
            this.x2_Min_lbl = new System.Windows.Forms.Label();
            this.x2_Deg_lbl = new System.Windows.Forms.Label();
            this.x2_Deg_txtBx = new System.Windows.Forms.TextBox();
            this.y2_Deg_txtBx = new System.Windows.Forms.TextBox();
            this.x2_txtBx = new System.Windows.Forms.TextBox();
            this.y2_txtBx = new System.Windows.Forms.TextBox();
            this.y2_Sec_lbl = new System.Windows.Forms.Label();
            this.x2_Sec_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.y2_Meter_lbl = new System.Windows.Forms.Label();
            this.x2_Meter_lbl = new System.Windows.Forms.Label();
            this.z1_Meter_lbl = new System.Windows.Forms.Label();
            this.Input_gpBx = new System.Windows.Forms.GroupBox();
            this.y1_Min_txtBx = new System.Windows.Forms.TextBox();
            this.x1_Sec_txtBx = new System.Windows.Forms.TextBox();
            this.y1_Sec_txtBx = new System.Windows.Forms.TextBox();
            this.x1_Min_txtBx = new System.Windows.Forms.TextBox();
            this.y1_Min_lbl = new System.Windows.Forms.Label();
            this.y1_Deg_lbl = new System.Windows.Forms.Label();
            this.x1_Min_lbl = new System.Windows.Forms.Label();
            this.x1_Deg_lbl = new System.Windows.Forms.Label();
            this.z1_lbl = new System.Windows.Forms.Label();
            this.y1_lbl = new System.Windows.Forms.Label();
            this.x1_lbl = new System.Windows.Forms.Label();
            this.z1_txtBx = new System.Windows.Forms.TextBox();
            this.x1_Deg_txtBx = new System.Windows.Forms.TextBox();
            this.x1_txtBx = new System.Windows.Forms.TextBox();
            this.y1_Deg_txtBx = new System.Windows.Forms.TextBox();
            this.y1_txtBx = new System.Windows.Forms.TextBox();
            this.x1_Sec_lbl = new System.Windows.Forms.Label();
            this.y1_Sec_lbl = new System.Windows.Forms.Label();
            this.y1_Meter_lbl = new System.Windows.Forms.Label();
            this.x1_Meter_lbl = new System.Windows.Forms.Label();
            this.Ellipsoid_Transfer_ms.SuspendLayout();
            this.Output_gpBx.SuspendLayout();
            this.Input_gpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // Target_Ellipsoid_lbl
            // 
            this.Target_Ellipsoid_lbl.AutoSize = true;
            this.Target_Ellipsoid_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Target_Ellipsoid_lbl.Location = new System.Drawing.Point(44, 145);
            this.Target_Ellipsoid_lbl.Name = "Target_Ellipsoid_lbl";
            this.Target_Ellipsoid_lbl.Size = new System.Drawing.Size(104, 16);
            this.Target_Ellipsoid_lbl.TabIndex = 8;
            this.Target_Ellipsoid_lbl.Text = "目标椭球体：";
            // 
            // Known_Ellipsoid_lbl
            // 
            this.Known_Ellipsoid_lbl.AutoSize = true;
            this.Known_Ellipsoid_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Known_Ellipsoid_lbl.Location = new System.Drawing.Point(44, 95);
            this.Known_Ellipsoid_lbl.Name = "Known_Ellipsoid_lbl";
            this.Known_Ellipsoid_lbl.Size = new System.Drawing.Size(104, 16);
            this.Known_Ellipsoid_lbl.TabIndex = 7;
            this.Known_Ellipsoid_lbl.Text = "已知椭球体：";
            // 
            // Target_Ellipsoid_cbBx
            // 
            this.Target_Ellipsoid_cbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Target_Ellipsoid_cbBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Target_Ellipsoid_cbBx.FormattingEnabled = true;
            this.Target_Ellipsoid_cbBx.Items.AddRange(new object[] {
            "克拉索夫斯基椭球体",
            "1975国际椭球体",
            "WGS-84椭球体",
            "2000中国大地坐标系(GCS2000)"});
            this.Target_Ellipsoid_cbBx.Location = new System.Drawing.Point(154, 142);
            this.Target_Ellipsoid_cbBx.Name = "Target_Ellipsoid_cbBx";
            this.Target_Ellipsoid_cbBx.Size = new System.Drawing.Size(250, 24);
            this.Target_Ellipsoid_cbBx.TabIndex = 6;
            this.Target_Ellipsoid_cbBx.SelectedIndexChanged += new System.EventHandler(this.Target_Ellipsoid_cbBx_SelectedIndexChanged);
            // 
            // Known_Ellipsoid_cbBx
            // 
            this.Known_Ellipsoid_cbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Known_Ellipsoid_cbBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Known_Ellipsoid_cbBx.FormattingEnabled = true;
            this.Known_Ellipsoid_cbBx.Items.AddRange(new object[] {
            "克拉索夫斯基椭球体",
            "1975国际椭球体",
            "WGS-84椭球体",
            "2000中国大地坐标系(GCS2000)"});
            this.Known_Ellipsoid_cbBx.Location = new System.Drawing.Point(154, 92);
            this.Known_Ellipsoid_cbBx.Name = "Known_Ellipsoid_cbBx";
            this.Known_Ellipsoid_cbBx.Size = new System.Drawing.Size(250, 24);
            this.Known_Ellipsoid_cbBx.TabIndex = 5;
            this.Known_Ellipsoid_cbBx.SelectedIndexChanged += new System.EventHandler(this.Known_Ellipsoid_cbBx_SelectedIndexChanged);
            // 
            // Transfer_btn
            // 
            this.Transfer_btn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Transfer_btn.Location = new System.Drawing.Point(215, 411);
            this.Transfer_btn.Name = "Transfer_btn";
            this.Transfer_btn.Size = new System.Drawing.Size(80, 40);
            this.Transfer_btn.TabIndex = 10;
            this.Transfer_btn.Text = "转换";
            this.Transfer_btn.UseVisualStyleBackColor = true;
            this.Transfer_btn.Click += new System.EventHandler(this.Transfer_btn_Click);
            // 
            // Ellipsoid_Transfer_ms
            // 
            this.Ellipsoid_Transfer_ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_tsmi});
            this.Ellipsoid_Transfer_ms.Location = new System.Drawing.Point(0, 0);
            this.Ellipsoid_Transfer_ms.Name = "Ellipsoid_Transfer_ms";
            this.Ellipsoid_Transfer_ms.Size = new System.Drawing.Size(504, 25);
            this.Ellipsoid_Transfer_ms.TabIndex = 12;
            this.Ellipsoid_Transfer_ms.Text = "menuStrip1";
            // 
            // Menu_tsmi
            // 
            this.Menu_tsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Get_Parameter_tsmi,
            this.Search_Parameter_tsmi,
            this.Import_Parameter_tsmi,
            this.Export_Parameter_tsmi});
            this.Menu_tsmi.Name = "Menu_tsmi";
            this.Menu_tsmi.Size = new System.Drawing.Size(64, 21);
            this.Menu_tsmi.Text = "菜单(&M)";
            // 
            // Get_Parameter_tsmi
            // 
            this.Get_Parameter_tsmi.Name = "Get_Parameter_tsmi";
            this.Get_Parameter_tsmi.Size = new System.Drawing.Size(124, 22);
            this.Get_Parameter_tsmi.Text = "求参数";
            this.Get_Parameter_tsmi.Click += new System.EventHandler(this.Get_Parameter_tsmi_Click);
            // 
            // Search_Parameter_tsmi
            // 
            this.Search_Parameter_tsmi.Name = "Search_Parameter_tsmi";
            this.Search_Parameter_tsmi.Size = new System.Drawing.Size(124, 22);
            this.Search_Parameter_tsmi.Text = "查看参数";
            this.Search_Parameter_tsmi.Click += new System.EventHandler(this.Search_Parameter_tsmi_Click);
            // 
            // Import_Parameter_tsmi
            // 
            this.Import_Parameter_tsmi.Name = "Import_Parameter_tsmi";
            this.Import_Parameter_tsmi.Size = new System.Drawing.Size(124, 22);
            this.Import_Parameter_tsmi.Text = "导入参数";
            this.Import_Parameter_tsmi.Click += new System.EventHandler(this.Import_Parameter_tsmi_Click);
            // 
            // Export_Parameter_tsmi
            // 
            this.Export_Parameter_tsmi.Name = "Export_Parameter_tsmi";
            this.Export_Parameter_tsmi.Size = new System.Drawing.Size(124, 22);
            this.Export_Parameter_tsmi.Text = "导出参数";
            this.Export_Parameter_tsmi.Click += new System.EventHandler(this.Export_Parameter_tsmi_Click);
            // 
            // Coordinate_System_lbl
            // 
            this.Coordinate_System_lbl.AutoSize = true;
            this.Coordinate_System_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Coordinate_System_lbl.Location = new System.Drawing.Point(28, 45);
            this.Coordinate_System_lbl.Name = "Coordinate_System_lbl";
            this.Coordinate_System_lbl.Size = new System.Drawing.Size(120, 16);
            this.Coordinate_System_lbl.TabIndex = 13;
            this.Coordinate_System_lbl.Text = "使用的坐标系：";
            // 
            // Coordinate_System_cbBx
            // 
            this.Coordinate_System_cbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Coordinate_System_cbBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Coordinate_System_cbBx.FormattingEnabled = true;
            this.Coordinate_System_cbBx.Items.AddRange(new object[] {
            "大地坐标系",
            "空间直角坐标系"});
            this.Coordinate_System_cbBx.Location = new System.Drawing.Point(154, 42);
            this.Coordinate_System_cbBx.Name = "Coordinate_System_cbBx";
            this.Coordinate_System_cbBx.Size = new System.Drawing.Size(250, 24);
            this.Coordinate_System_cbBx.TabIndex = 14;
            this.Coordinate_System_cbBx.SelectedIndexChanged += new System.EventHandler(this.Coordinate_System_cbBx_SelectedIndexChanged);
            // 
            // Output_gpBx
            // 
            this.Output_gpBx.Controls.Add(this.z2_Meter_lbl);
            this.Output_gpBx.Controls.Add(this.y2_Min_txtBx);
            this.Output_gpBx.Controls.Add(this.y2_Sec_txtBx);
            this.Output_gpBx.Controls.Add(this.y2_Min_lbl);
            this.Output_gpBx.Controls.Add(this.y2_Deg_lbl);
            this.Output_gpBx.Controls.Add(this.z2_lbl);
            this.Output_gpBx.Controls.Add(this.y2_lbl);
            this.Output_gpBx.Controls.Add(this.x2_lbl);
            this.Output_gpBx.Controls.Add(this.z2_txtBx);
            this.Output_gpBx.Controls.Add(this.x2_Sec_txtBx);
            this.Output_gpBx.Controls.Add(this.x2_Min_txtBx);
            this.Output_gpBx.Controls.Add(this.x2_Min_lbl);
            this.Output_gpBx.Controls.Add(this.x2_Deg_lbl);
            this.Output_gpBx.Controls.Add(this.x2_Deg_txtBx);
            this.Output_gpBx.Controls.Add(this.y2_Deg_txtBx);
            this.Output_gpBx.Controls.Add(this.x2_txtBx);
            this.Output_gpBx.Controls.Add(this.y2_txtBx);
            this.Output_gpBx.Controls.Add(this.y2_Sec_lbl);
            this.Output_gpBx.Controls.Add(this.x2_Sec_lbl);
            this.Output_gpBx.Controls.Add(this.label1);
            this.Output_gpBx.Controls.Add(this.label2);
            this.Output_gpBx.Controls.Add(this.y2_Meter_lbl);
            this.Output_gpBx.Controls.Add(this.x2_Meter_lbl);
            this.Output_gpBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Output_gpBx.Location = new System.Drawing.Point(40, 456);
            this.Output_gpBx.Margin = new System.Windows.Forms.Padding(2);
            this.Output_gpBx.Name = "Output_gpBx";
            this.Output_gpBx.Padding = new System.Windows.Forms.Padding(2);
            this.Output_gpBx.Size = new System.Drawing.Size(430, 200);
            this.Output_gpBx.TabIndex = 15;
            this.Output_gpBx.TabStop = false;
            this.Output_gpBx.Text = "输出";
            // 
            // z2_Meter_lbl
            // 
            this.z2_Meter_lbl.AutoSize = true;
            this.z2_Meter_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.z2_Meter_lbl.Location = new System.Drawing.Point(360, 140);
            this.z2_Meter_lbl.Name = "z2_Meter_lbl";
            this.z2_Meter_lbl.Size = new System.Drawing.Size(48, 16);
            this.z2_Meter_lbl.TabIndex = 44;
            this.z2_Meter_lbl.Text = "米(m)";
            // 
            // y2_Min_txtBx
            // 
            this.y2_Min_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.y2_Min_txtBx.Location = new System.Drawing.Point(175, 86);
            this.y2_Min_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.y2_Min_txtBx.Name = "y2_Min_txtBx";
            this.y2_Min_txtBx.ReadOnly = true;
            this.y2_Min_txtBx.Size = new System.Drawing.Size(40, 26);
            this.y2_Min_txtBx.TabIndex = 37;
            this.y2_Min_txtBx.TabStop = false;
            this.y2_Min_txtBx.Visible = false;
            // 
            // y2_Sec_txtBx
            // 
            this.y2_Sec_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.y2_Sec_txtBx.Location = new System.Drawing.Point(270, 86);
            this.y2_Sec_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.y2_Sec_txtBx.Name = "y2_Sec_txtBx";
            this.y2_Sec_txtBx.ReadOnly = true;
            this.y2_Sec_txtBx.Size = new System.Drawing.Size(80, 26);
            this.y2_Sec_txtBx.TabIndex = 39;
            this.y2_Sec_txtBx.TabStop = false;
            this.y2_Sec_txtBx.Visible = false;
            // 
            // y2_Min_lbl
            // 
            this.y2_Min_lbl.AutoSize = true;
            this.y2_Min_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.y2_Min_lbl.Location = new System.Drawing.Point(218, 89);
            this.y2_Min_lbl.Name = "y2_Min_lbl";
            this.y2_Min_lbl.Size = new System.Drawing.Size(48, 16);
            this.y2_Min_lbl.TabIndex = 42;
            this.y2_Min_lbl.Text = "分(\')";
            this.y2_Min_lbl.Visible = false;
            // 
            // y2_Deg_lbl
            // 
            this.y2_Deg_lbl.AutoSize = true;
            this.y2_Deg_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.y2_Deg_lbl.Location = new System.Drawing.Point(115, 89);
            this.y2_Deg_lbl.Name = "y2_Deg_lbl";
            this.y2_Deg_lbl.Size = new System.Drawing.Size(56, 16);
            this.y2_Deg_lbl.TabIndex = 41;
            this.y2_Deg_lbl.Text = "度(°)";
            this.y2_Deg_lbl.Visible = false;
            // 
            // z2_lbl
            // 
            this.z2_lbl.AutoSize = true;
            this.z2_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.z2_lbl.Location = new System.Drawing.Point(30, 140);
            this.z2_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.z2_lbl.Name = "z2_lbl";
            this.z2_lbl.Size = new System.Drawing.Size(24, 16);
            this.z2_lbl.TabIndex = 24;
            this.z2_lbl.Text = "z2";
            // 
            // y2_lbl
            // 
            this.y2_lbl.AutoSize = true;
            this.y2_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.y2_lbl.Location = new System.Drawing.Point(30, 89);
            this.y2_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.y2_lbl.Name = "y2_lbl";
            this.y2_lbl.Size = new System.Drawing.Size(24, 16);
            this.y2_lbl.TabIndex = 23;
            this.y2_lbl.Text = "y2";
            // 
            // x2_lbl
            // 
            this.x2_lbl.AutoSize = true;
            this.x2_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.x2_lbl.Location = new System.Drawing.Point(30, 40);
            this.x2_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x2_lbl.Name = "x2_lbl";
            this.x2_lbl.Size = new System.Drawing.Size(24, 16);
            this.x2_lbl.TabIndex = 22;
            this.x2_lbl.Text = "x2";
            // 
            // z2_txtBx
            // 
            this.z2_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.z2_txtBx.Location = new System.Drawing.Point(72, 137);
            this.z2_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.z2_txtBx.Name = "z2_txtBx";
            this.z2_txtBx.ReadOnly = true;
            this.z2_txtBx.Size = new System.Drawing.Size(270, 26);
            this.z2_txtBx.TabIndex = 15;
            this.z2_txtBx.TabStop = false;
            // 
            // x2_Sec_txtBx
            // 
            this.x2_Sec_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.x2_Sec_txtBx.Location = new System.Drawing.Point(270, 37);
            this.x2_Sec_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.x2_Sec_txtBx.Name = "x2_Sec_txtBx";
            this.x2_Sec_txtBx.ReadOnly = true;
            this.x2_Sec_txtBx.Size = new System.Drawing.Size(80, 26);
            this.x2_Sec_txtBx.TabIndex = 40;
            this.x2_Sec_txtBx.TabStop = false;
            this.x2_Sec_txtBx.Visible = false;
            // 
            // x2_Min_txtBx
            // 
            this.x2_Min_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.x2_Min_txtBx.Location = new System.Drawing.Point(175, 37);
            this.x2_Min_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.x2_Min_txtBx.Name = "x2_Min_txtBx";
            this.x2_Min_txtBx.ReadOnly = true;
            this.x2_Min_txtBx.Size = new System.Drawing.Size(40, 26);
            this.x2_Min_txtBx.TabIndex = 38;
            this.x2_Min_txtBx.TabStop = false;
            this.x2_Min_txtBx.Visible = false;
            // 
            // x2_Min_lbl
            // 
            this.x2_Min_lbl.AutoSize = true;
            this.x2_Min_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.x2_Min_lbl.Location = new System.Drawing.Point(218, 42);
            this.x2_Min_lbl.Name = "x2_Min_lbl";
            this.x2_Min_lbl.Size = new System.Drawing.Size(48, 16);
            this.x2_Min_lbl.TabIndex = 35;
            this.x2_Min_lbl.Text = "分(\')";
            this.x2_Min_lbl.Visible = false;
            // 
            // x2_Deg_lbl
            // 
            this.x2_Deg_lbl.AutoSize = true;
            this.x2_Deg_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.x2_Deg_lbl.Location = new System.Drawing.Point(115, 42);
            this.x2_Deg_lbl.Name = "x2_Deg_lbl";
            this.x2_Deg_lbl.Size = new System.Drawing.Size(56, 16);
            this.x2_Deg_lbl.TabIndex = 34;
            this.x2_Deg_lbl.Text = "度(°)";
            this.x2_Deg_lbl.Visible = false;
            // 
            // x2_Deg_txtBx
            // 
            this.x2_Deg_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.x2_Deg_txtBx.Location = new System.Drawing.Point(72, 37);
            this.x2_Deg_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.x2_Deg_txtBx.Name = "x2_Deg_txtBx";
            this.x2_Deg_txtBx.ReadOnly = true;
            this.x2_Deg_txtBx.Size = new System.Drawing.Size(40, 26);
            this.x2_Deg_txtBx.TabIndex = 32;
            this.x2_Deg_txtBx.TabStop = false;
            this.x2_Deg_txtBx.Visible = false;
            // 
            // y2_Deg_txtBx
            // 
            this.y2_Deg_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.y2_Deg_txtBx.Location = new System.Drawing.Point(72, 86);
            this.y2_Deg_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.y2_Deg_txtBx.Name = "y2_Deg_txtBx";
            this.y2_Deg_txtBx.ReadOnly = true;
            this.y2_Deg_txtBx.Size = new System.Drawing.Size(40, 26);
            this.y2_Deg_txtBx.TabIndex = 33;
            this.y2_Deg_txtBx.TabStop = false;
            this.y2_Deg_txtBx.Visible = false;
            // 
            // x2_txtBx
            // 
            this.x2_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.x2_txtBx.Location = new System.Drawing.Point(72, 37);
            this.x2_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.x2_txtBx.Name = "x2_txtBx";
            this.x2_txtBx.ReadOnly = true;
            this.x2_txtBx.Size = new System.Drawing.Size(268, 26);
            this.x2_txtBx.TabIndex = 46;
            this.x2_txtBx.TabStop = false;
            this.x2_txtBx.Visible = false;
            // 
            // y2_txtBx
            // 
            this.y2_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.y2_txtBx.Location = new System.Drawing.Point(72, 86);
            this.y2_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.y2_txtBx.Name = "y2_txtBx";
            this.y2_txtBx.ReadOnly = true;
            this.y2_txtBx.Size = new System.Drawing.Size(268, 26);
            this.y2_txtBx.TabIndex = 45;
            this.y2_txtBx.TabStop = false;
            this.y2_txtBx.Visible = false;
            // 
            // y2_Sec_lbl
            // 
            this.y2_Sec_lbl.AutoSize = true;
            this.y2_Sec_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.y2_Sec_lbl.Location = new System.Drawing.Point(360, 89);
            this.y2_Sec_lbl.Name = "y2_Sec_lbl";
            this.y2_Sec_lbl.Size = new System.Drawing.Size(48, 16);
            this.y2_Sec_lbl.TabIndex = 43;
            this.y2_Sec_lbl.Text = "秒(\")";
            this.y2_Sec_lbl.Visible = false;
            // 
            // x2_Sec_lbl
            // 
            this.x2_Sec_lbl.AutoSize = true;
            this.x2_Sec_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.x2_Sec_lbl.Location = new System.Drawing.Point(360, 42);
            this.x2_Sec_lbl.Name = "x2_Sec_lbl";
            this.x2_Sec_lbl.Size = new System.Drawing.Size(48, 16);
            this.x2_Sec_lbl.TabIndex = 36;
            this.x2_Sec_lbl.Text = "秒(\")";
            this.x2_Sec_lbl.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(361, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "米(m)";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(361, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "米(m)";
            this.label2.Visible = false;
            // 
            // y2_Meter_lbl
            // 
            this.y2_Meter_lbl.AutoSize = true;
            this.y2_Meter_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.y2_Meter_lbl.Location = new System.Drawing.Point(360, 89);
            this.y2_Meter_lbl.Name = "y2_Meter_lbl";
            this.y2_Meter_lbl.Size = new System.Drawing.Size(48, 16);
            this.y2_Meter_lbl.TabIndex = 37;
            this.y2_Meter_lbl.Text = "米(m)";
            // 
            // x2_Meter_lbl
            // 
            this.x2_Meter_lbl.AutoSize = true;
            this.x2_Meter_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.x2_Meter_lbl.Location = new System.Drawing.Point(360, 42);
            this.x2_Meter_lbl.Name = "x2_Meter_lbl";
            this.x2_Meter_lbl.Size = new System.Drawing.Size(48, 16);
            this.x2_Meter_lbl.TabIndex = 38;
            this.x2_Meter_lbl.Text = "米(m)";
            // 
            // z1_Meter_lbl
            // 
            this.z1_Meter_lbl.AutoSize = true;
            this.z1_Meter_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.z1_Meter_lbl.Location = new System.Drawing.Point(360, 140);
            this.z1_Meter_lbl.Name = "z1_Meter_lbl";
            this.z1_Meter_lbl.Size = new System.Drawing.Size(48, 16);
            this.z1_Meter_lbl.TabIndex = 32;
            this.z1_Meter_lbl.Text = "米(m)";
            // 
            // Input_gpBx
            // 
            this.Input_gpBx.Controls.Add(this.z1_Meter_lbl);
            this.Input_gpBx.Controls.Add(this.y1_Min_txtBx);
            this.Input_gpBx.Controls.Add(this.x1_Sec_txtBx);
            this.Input_gpBx.Controls.Add(this.y1_Sec_txtBx);
            this.Input_gpBx.Controls.Add(this.x1_Min_txtBx);
            this.Input_gpBx.Controls.Add(this.y1_Min_lbl);
            this.Input_gpBx.Controls.Add(this.y1_Deg_lbl);
            this.Input_gpBx.Controls.Add(this.x1_Min_lbl);
            this.Input_gpBx.Controls.Add(this.x1_Deg_lbl);
            this.Input_gpBx.Controls.Add(this.z1_lbl);
            this.Input_gpBx.Controls.Add(this.y1_lbl);
            this.Input_gpBx.Controls.Add(this.x1_lbl);
            this.Input_gpBx.Controls.Add(this.z1_txtBx);
            this.Input_gpBx.Controls.Add(this.x1_Deg_txtBx);
            this.Input_gpBx.Controls.Add(this.x1_txtBx);
            this.Input_gpBx.Controls.Add(this.y1_Deg_txtBx);
            this.Input_gpBx.Controls.Add(this.y1_txtBx);
            this.Input_gpBx.Controls.Add(this.x1_Sec_lbl);
            this.Input_gpBx.Controls.Add(this.y1_Sec_lbl);
            this.Input_gpBx.Controls.Add(this.y1_Meter_lbl);
            this.Input_gpBx.Controls.Add(this.x1_Meter_lbl);
            this.Input_gpBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Input_gpBx.Location = new System.Drawing.Point(40, 204);
            this.Input_gpBx.Margin = new System.Windows.Forms.Padding(2);
            this.Input_gpBx.Name = "Input_gpBx";
            this.Input_gpBx.Padding = new System.Windows.Forms.Padding(2);
            this.Input_gpBx.Size = new System.Drawing.Size(430, 200);
            this.Input_gpBx.TabIndex = 16;
            this.Input_gpBx.TabStop = false;
            this.Input_gpBx.Text = "输入";
            // 
            // y1_Min_txtBx
            // 
            this.y1_Min_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.y1_Min_txtBx.Location = new System.Drawing.Point(175, 87);
            this.y1_Min_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.y1_Min_txtBx.Name = "y1_Min_txtBx";
            this.y1_Min_txtBx.Size = new System.Drawing.Size(40, 26);
            this.y1_Min_txtBx.TabIndex = 25;
            this.y1_Min_txtBx.TabStop = false;
            this.y1_Min_txtBx.Text = "0";
            this.y1_Min_txtBx.Visible = false;
            this.y1_Min_txtBx.Click += new System.EventHandler(this.InputBx_Got_Focus);
            this.y1_Min_txtBx.Leave += new System.EventHandler(this.InputBx_Lose_Focus);
            // 
            // x1_Sec_txtBx
            // 
            this.x1_Sec_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.x1_Sec_txtBx.Location = new System.Drawing.Point(270, 37);
            this.x1_Sec_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.x1_Sec_txtBx.Name = "x1_Sec_txtBx";
            this.x1_Sec_txtBx.Size = new System.Drawing.Size(80, 26);
            this.x1_Sec_txtBx.TabIndex = 28;
            this.x1_Sec_txtBx.TabStop = false;
            this.x1_Sec_txtBx.Text = "0";
            this.x1_Sec_txtBx.Visible = false;
            this.x1_Sec_txtBx.Click += new System.EventHandler(this.InputBx_Got_Focus);
            this.x1_Sec_txtBx.Leave += new System.EventHandler(this.InputBx_Lose_Focus);
            // 
            // y1_Sec_txtBx
            // 
            this.y1_Sec_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.y1_Sec_txtBx.Location = new System.Drawing.Point(270, 87);
            this.y1_Sec_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.y1_Sec_txtBx.Name = "y1_Sec_txtBx";
            this.y1_Sec_txtBx.Size = new System.Drawing.Size(80, 26);
            this.y1_Sec_txtBx.TabIndex = 27;
            this.y1_Sec_txtBx.TabStop = false;
            this.y1_Sec_txtBx.Text = "0";
            this.y1_Sec_txtBx.Visible = false;
            this.y1_Sec_txtBx.Click += new System.EventHandler(this.InputBx_Got_Focus);
            this.y1_Sec_txtBx.Leave += new System.EventHandler(this.InputBx_Lose_Focus);
            // 
            // x1_Min_txtBx
            // 
            this.x1_Min_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.x1_Min_txtBx.Location = new System.Drawing.Point(175, 37);
            this.x1_Min_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.x1_Min_txtBx.Name = "x1_Min_txtBx";
            this.x1_Min_txtBx.Size = new System.Drawing.Size(40, 26);
            this.x1_Min_txtBx.TabIndex = 26;
            this.x1_Min_txtBx.TabStop = false;
            this.x1_Min_txtBx.Text = "0";
            this.x1_Min_txtBx.Visible = false;
            this.x1_Min_txtBx.Click += new System.EventHandler(this.InputBx_Got_Focus);
            this.x1_Min_txtBx.Leave += new System.EventHandler(this.InputBx_Lose_Focus);
            // 
            // y1_Min_lbl
            // 
            this.y1_Min_lbl.AutoSize = true;
            this.y1_Min_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.y1_Min_lbl.Location = new System.Drawing.Point(218, 90);
            this.y1_Min_lbl.Name = "y1_Min_lbl";
            this.y1_Min_lbl.Size = new System.Drawing.Size(48, 16);
            this.y1_Min_lbl.TabIndex = 30;
            this.y1_Min_lbl.Text = "分(\')";
            this.y1_Min_lbl.Visible = false;
            // 
            // y1_Deg_lbl
            // 
            this.y1_Deg_lbl.AutoSize = true;
            this.y1_Deg_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.y1_Deg_lbl.Location = new System.Drawing.Point(115, 90);
            this.y1_Deg_lbl.Name = "y1_Deg_lbl";
            this.y1_Deg_lbl.Size = new System.Drawing.Size(56, 16);
            this.y1_Deg_lbl.TabIndex = 29;
            this.y1_Deg_lbl.Text = "度(°)";
            this.y1_Deg_lbl.Visible = false;
            // 
            // x1_Min_lbl
            // 
            this.x1_Min_lbl.AutoSize = true;
            this.x1_Min_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.x1_Min_lbl.Location = new System.Drawing.Point(218, 42);
            this.x1_Min_lbl.Name = "x1_Min_lbl";
            this.x1_Min_lbl.Size = new System.Drawing.Size(48, 16);
            this.x1_Min_lbl.TabIndex = 23;
            this.x1_Min_lbl.Text = "分(\')";
            this.x1_Min_lbl.Visible = false;
            // 
            // x1_Deg_lbl
            // 
            this.x1_Deg_lbl.AutoSize = true;
            this.x1_Deg_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.x1_Deg_lbl.Location = new System.Drawing.Point(115, 42);
            this.x1_Deg_lbl.Name = "x1_Deg_lbl";
            this.x1_Deg_lbl.Size = new System.Drawing.Size(56, 16);
            this.x1_Deg_lbl.TabIndex = 22;
            this.x1_Deg_lbl.Text = "度(°)";
            this.x1_Deg_lbl.Visible = false;
            // 
            // z1_lbl
            // 
            this.z1_lbl.AutoSize = true;
            this.z1_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.z1_lbl.Location = new System.Drawing.Point(30, 140);
            this.z1_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.z1_lbl.Name = "z1_lbl";
            this.z1_lbl.Size = new System.Drawing.Size(24, 16);
            this.z1_lbl.TabIndex = 21;
            this.z1_lbl.Text = "z1";
            // 
            // y1_lbl
            // 
            this.y1_lbl.AutoSize = true;
            this.y1_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.y1_lbl.Location = new System.Drawing.Point(30, 90);
            this.y1_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.y1_lbl.Name = "y1_lbl";
            this.y1_lbl.Size = new System.Drawing.Size(24, 16);
            this.y1_lbl.TabIndex = 20;
            this.y1_lbl.Text = "y1";
            // 
            // x1_lbl
            // 
            this.x1_lbl.AutoSize = true;
            this.x1_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.x1_lbl.Location = new System.Drawing.Point(30, 40);
            this.x1_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x1_lbl.Name = "x1_lbl";
            this.x1_lbl.Size = new System.Drawing.Size(24, 16);
            this.x1_lbl.TabIndex = 19;
            this.x1_lbl.Text = "x1";
            // 
            // z1_txtBx
            // 
            this.z1_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.z1_txtBx.Location = new System.Drawing.Point(72, 137);
            this.z1_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.z1_txtBx.Name = "z1_txtBx";
            this.z1_txtBx.Size = new System.Drawing.Size(270, 26);
            this.z1_txtBx.TabIndex = 18;
            this.z1_txtBx.TabStop = false;
            this.z1_txtBx.Text = "0";
            this.z1_txtBx.Click += new System.EventHandler(this.InputBx_Got_Focus);
            this.z1_txtBx.Leave += new System.EventHandler(this.InputBx_Lose_Focus);
            // 
            // x1_Deg_txtBx
            // 
            this.x1_Deg_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.x1_Deg_txtBx.Location = new System.Drawing.Point(72, 37);
            this.x1_Deg_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.x1_Deg_txtBx.Name = "x1_Deg_txtBx";
            this.x1_Deg_txtBx.Size = new System.Drawing.Size(40, 26);
            this.x1_Deg_txtBx.TabIndex = 16;
            this.x1_Deg_txtBx.TabStop = false;
            this.x1_Deg_txtBx.Text = "0";
            this.x1_Deg_txtBx.Visible = false;
            this.x1_Deg_txtBx.Click += new System.EventHandler(this.InputBx_Got_Focus);
            this.x1_Deg_txtBx.Leave += new System.EventHandler(this.InputBx_Lose_Focus);
            // 
            // x1_txtBx
            // 
            this.x1_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.x1_txtBx.Location = new System.Drawing.Point(72, 37);
            this.x1_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.x1_txtBx.Name = "x1_txtBx";
            this.x1_txtBx.Size = new System.Drawing.Size(270, 26);
            this.x1_txtBx.TabIndex = 36;
            this.x1_txtBx.TabStop = false;
            this.x1_txtBx.Text = "0";
            this.x1_txtBx.Visible = false;
            this.x1_txtBx.Click += new System.EventHandler(this.InputBx_Got_Focus);
            this.x1_txtBx.Leave += new System.EventHandler(this.InputBx_Lose_Focus);
            // 
            // y1_Deg_txtBx
            // 
            this.y1_Deg_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.y1_Deg_txtBx.Location = new System.Drawing.Point(72, 87);
            this.y1_Deg_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.y1_Deg_txtBx.Name = "y1_Deg_txtBx";
            this.y1_Deg_txtBx.Size = new System.Drawing.Size(40, 26);
            this.y1_Deg_txtBx.TabIndex = 17;
            this.y1_Deg_txtBx.TabStop = false;
            this.y1_Deg_txtBx.Text = "0";
            this.y1_Deg_txtBx.Visible = false;
            this.y1_Deg_txtBx.Click += new System.EventHandler(this.InputBx_Got_Focus);
            this.y1_Deg_txtBx.Leave += new System.EventHandler(this.InputBx_Lose_Focus);
            // 
            // y1_txtBx
            // 
            this.y1_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.y1_txtBx.Location = new System.Drawing.Point(72, 87);
            this.y1_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.y1_txtBx.Name = "y1_txtBx";
            this.y1_txtBx.Size = new System.Drawing.Size(270, 26);
            this.y1_txtBx.TabIndex = 35;
            this.y1_txtBx.TabStop = false;
            this.y1_txtBx.Text = "0";
            this.y1_txtBx.Visible = false;
            this.y1_txtBx.Click += new System.EventHandler(this.InputBx_Got_Focus);
            this.y1_txtBx.Leave += new System.EventHandler(this.InputBx_Lose_Focus);
            // 
            // x1_Sec_lbl
            // 
            this.x1_Sec_lbl.AutoSize = true;
            this.x1_Sec_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.x1_Sec_lbl.Location = new System.Drawing.Point(360, 42);
            this.x1_Sec_lbl.Name = "x1_Sec_lbl";
            this.x1_Sec_lbl.Size = new System.Drawing.Size(48, 16);
            this.x1_Sec_lbl.TabIndex = 24;
            this.x1_Sec_lbl.Text = "秒(\")";
            this.x1_Sec_lbl.Visible = false;
            // 
            // y1_Sec_lbl
            // 
            this.y1_Sec_lbl.AutoSize = true;
            this.y1_Sec_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.y1_Sec_lbl.Location = new System.Drawing.Point(360, 90);
            this.y1_Sec_lbl.Name = "y1_Sec_lbl";
            this.y1_Sec_lbl.Size = new System.Drawing.Size(48, 16);
            this.y1_Sec_lbl.TabIndex = 31;
            this.y1_Sec_lbl.Text = "秒(\")";
            this.y1_Sec_lbl.Visible = false;
            // 
            // y1_Meter_lbl
            // 
            this.y1_Meter_lbl.AutoSize = true;
            this.y1_Meter_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.y1_Meter_lbl.Location = new System.Drawing.Point(360, 90);
            this.y1_Meter_lbl.Name = "y1_Meter_lbl";
            this.y1_Meter_lbl.Size = new System.Drawing.Size(48, 16);
            this.y1_Meter_lbl.TabIndex = 33;
            this.y1_Meter_lbl.Text = "米(m)";
            this.y1_Meter_lbl.Visible = false;
            // 
            // x1_Meter_lbl
            // 
            this.x1_Meter_lbl.AutoSize = true;
            this.x1_Meter_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.x1_Meter_lbl.Location = new System.Drawing.Point(361, 42);
            this.x1_Meter_lbl.Name = "x1_Meter_lbl";
            this.x1_Meter_lbl.Size = new System.Drawing.Size(48, 16);
            this.x1_Meter_lbl.TabIndex = 34;
            this.x1_Meter_lbl.Text = "米(m)";
            this.x1_Meter_lbl.Visible = false;
            // 
            // Ellipsoid_Transfer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 681);
            this.Controls.Add(this.Output_gpBx);
            this.Controls.Add(this.Input_gpBx);
            this.Controls.Add(this.Coordinate_System_cbBx);
            this.Controls.Add(this.Coordinate_System_lbl);
            this.Controls.Add(this.Ellipsoid_Transfer_ms);
            this.Controls.Add(this.Transfer_btn);
            this.Controls.Add(this.Target_Ellipsoid_lbl);
            this.Controls.Add(this.Known_Ellipsoid_lbl);
            this.Controls.Add(this.Target_Ellipsoid_cbBx);
            this.Controls.Add(this.Known_Ellipsoid_cbBx);
            this.MainMenuStrip = this.Ellipsoid_Transfer_ms;
            this.Name = "Ellipsoid_Transfer_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "椭球体转换";
            this.Activated += new System.EventHandler(this.Ellipsoid_Transfer_Form_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ellipsoid_Transfer_Form_FormClosing);
            this.Ellipsoid_Transfer_ms.ResumeLayout(false);
            this.Ellipsoid_Transfer_ms.PerformLayout();
            this.Output_gpBx.ResumeLayout(false);
            this.Output_gpBx.PerformLayout();
            this.Input_gpBx.ResumeLayout(false);
            this.Input_gpBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Target_Ellipsoid_lbl;
        private System.Windows.Forms.Label Known_Ellipsoid_lbl;
        private System.Windows.Forms.ComboBox Known_Ellipsoid_cbBx;
        private System.Windows.Forms.ComboBox Target_Ellipsoid_cbBx;
        private System.Windows.Forms.Button Transfer_btn;
        private System.Windows.Forms.MenuStrip Ellipsoid_Transfer_ms;
        private System.Windows.Forms.Label Coordinate_System_lbl;
        private System.Windows.Forms.ComboBox Coordinate_System_cbBx;
        private System.Windows.Forms.ToolStripMenuItem Menu_tsmi;
        private System.Windows.Forms.ToolStripMenuItem Get_Parameter_tsmi;
        private System.Windows.Forms.ToolStripMenuItem Search_Parameter_tsmi;
        private System.Windows.Forms.GroupBox Output_gpBx;
        private System.Windows.Forms.Label z2_Meter_lbl;
        private System.Windows.Forms.TextBox y2_Min_txtBx;
        private System.Windows.Forms.TextBox y2_Sec_txtBx;
        private System.Windows.Forms.Label y2_Min_lbl;
        private System.Windows.Forms.Label y2_Deg_lbl;
        private System.Windows.Forms.Label z2_lbl;
        private System.Windows.Forms.Label y2_lbl;
        private System.Windows.Forms.Label x2_lbl;
        private System.Windows.Forms.TextBox z2_txtBx;
        private System.Windows.Forms.TextBox x2_Sec_txtBx;
        private System.Windows.Forms.TextBox x2_Min_txtBx;
        private System.Windows.Forms.Label x2_Min_lbl;
        private System.Windows.Forms.Label x2_Deg_lbl;
        private System.Windows.Forms.TextBox x2_Deg_txtBx;
        private System.Windows.Forms.TextBox y2_Deg_txtBx;
        private System.Windows.Forms.TextBox x2_txtBx;
        private System.Windows.Forms.TextBox y2_txtBx;
        private System.Windows.Forms.Label y2_Sec_lbl;
        private System.Windows.Forms.Label x2_Sec_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label y2_Meter_lbl;
        private System.Windows.Forms.Label x2_Meter_lbl;
        private System.Windows.Forms.Label z1_Meter_lbl;
        private System.Windows.Forms.GroupBox Input_gpBx;
        private System.Windows.Forms.TextBox y1_Min_txtBx;
        private System.Windows.Forms.TextBox x1_Sec_txtBx;
        private System.Windows.Forms.TextBox y1_Sec_txtBx;
        private System.Windows.Forms.TextBox x1_Min_txtBx;
        private System.Windows.Forms.Label y1_Min_lbl;
        private System.Windows.Forms.Label y1_Deg_lbl;
        private System.Windows.Forms.Label x1_Min_lbl;
        private System.Windows.Forms.Label x1_Deg_lbl;
        private System.Windows.Forms.Label z1_lbl;
        private System.Windows.Forms.Label y1_lbl;
        private System.Windows.Forms.Label x1_lbl;
        private System.Windows.Forms.TextBox z1_txtBx;
        private System.Windows.Forms.TextBox x1_Deg_txtBx;
        private System.Windows.Forms.TextBox x1_txtBx;
        private System.Windows.Forms.TextBox y1_Deg_txtBx;
        private System.Windows.Forms.TextBox y1_txtBx;
        private System.Windows.Forms.Label x1_Sec_lbl;
        private System.Windows.Forms.Label y1_Sec_lbl;
        private System.Windows.Forms.Label y1_Meter_lbl;
        private System.Windows.Forms.Label x1_Meter_lbl;
        private System.Windows.Forms.ToolStripMenuItem Import_Parameter_tsmi;
        private System.Windows.Forms.ToolStripMenuItem Export_Parameter_tsmi;
    }
}