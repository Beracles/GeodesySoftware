namespace 坐标系转换
{
    partial class Coordinate_Transfer_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coordinate_Transfer_Form));
            this.Present_Coordinate_cbBx = new System.Windows.Forms.ComboBox();
            this.Target_Coordinate_cbBx = new System.Windows.Forms.ComboBox();
            this.Present_Coordinate_lbl = new System.Windows.Forms.Label();
            this.Target_Coordinate_lbl = new System.Windows.Forms.Label();
            this.Input_gpBx = new System.Windows.Forms.GroupBox();
            this.z1_Meter_lbl = new System.Windows.Forms.Label();
            this.y1_Min_txtBx = new System.Windows.Forms.TextBox();
            this.x1_Sec_txtBx = new System.Windows.Forms.TextBox();
            this.y1_Sec_txtBx = new System.Windows.Forms.TextBox();
            this.x1_Min_txtBx = new System.Windows.Forms.TextBox();
            this.y1_Min_lbl = new System.Windows.Forms.Label();
            this.y1_Deg_lbl = new System.Windows.Forms.Label();
            this.x1_Sec_lbl = new System.Windows.Forms.Label();
            this.x1_Min_lbl = new System.Windows.Forms.Label();
            this.x1_Deg_lbl = new System.Windows.Forms.Label();
            this.z1_lbl = new System.Windows.Forms.Label();
            this.y1_lbl = new System.Windows.Forms.Label();
            this.x1_lbl = new System.Windows.Forms.Label();
            this.z1_txtBx = new System.Windows.Forms.TextBox();
            this.x1_Meter_lbl = new System.Windows.Forms.Label();
            this.x1_Deg_txtBx = new System.Windows.Forms.TextBox();
            this.x1_txtBx = new System.Windows.Forms.TextBox();
            this.y1_Deg_txtBx = new System.Windows.Forms.TextBox();
            this.y1_txtBx = new System.Windows.Forms.TextBox();
            this.y1_Sec_lbl = new System.Windows.Forms.Label();
            this.y1_Meter_lbl = new System.Windows.Forms.Label();
            this.Output_gpBx = new System.Windows.Forms.GroupBox();
            this.z2_Meter_lbl = new System.Windows.Forms.Label();
            this.y2_Min_txtBx = new System.Windows.Forms.TextBox();
            this.y2_Sec_txtBx = new System.Windows.Forms.TextBox();
            this.y2_Sec_lbl = new System.Windows.Forms.Label();
            this.y2_Min_lbl = new System.Windows.Forms.Label();
            this.y2_Deg_lbl = new System.Windows.Forms.Label();
            this.x2_Sec_lbl = new System.Windows.Forms.Label();
            this.z2_lbl = new System.Windows.Forms.Label();
            this.y2_lbl = new System.Windows.Forms.Label();
            this.x2_lbl = new System.Windows.Forms.Label();
            this.z2_txtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.x2_Sec_txtBx = new System.Windows.Forms.TextBox();
            this.x2_Min_txtBx = new System.Windows.Forms.TextBox();
            this.x2_Min_lbl = new System.Windows.Forms.Label();
            this.x2_Deg_lbl = new System.Windows.Forms.Label();
            this.x2_Meter_lbl = new System.Windows.Forms.Label();
            this.y2_Meter_lbl = new System.Windows.Forms.Label();
            this.x2_Deg_txtBx = new System.Windows.Forms.TextBox();
            this.y2_Deg_txtBx = new System.Windows.Forms.TextBox();
            this.x2_txtBx = new System.Windows.Forms.TextBox();
            this.y2_txtBx = new System.Windows.Forms.TextBox();
            this.Transfer_btn = new System.Windows.Forms.Button();
            this.Input_gpBx.SuspendLayout();
            this.Output_gpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // Present_Coordinate_cbBx
            // 
            this.Present_Coordinate_cbBx.FormattingEnabled = true;
            this.Present_Coordinate_cbBx.Items.AddRange(new object[] {
            "大地坐标系",
            "子午面直角坐标系",
            "空间直角坐标系"});
            this.Present_Coordinate_cbBx.Location = new System.Drawing.Point(93, 23);
            this.Present_Coordinate_cbBx.Margin = new System.Windows.Forms.Padding(2);
            this.Present_Coordinate_cbBx.Name = "Present_Coordinate_cbBx";
            this.Present_Coordinate_cbBx.Size = new System.Drawing.Size(211, 20);
            this.Present_Coordinate_cbBx.TabIndex = 0;
            this.Present_Coordinate_cbBx.TabStop = false;
            this.Present_Coordinate_cbBx.SelectedIndexChanged += new System.EventHandler(this.Present_Coordinate_cbBx_SelectedIndexChanged);
            // 
            // Target_Coordinate_cbBx
            // 
            this.Target_Coordinate_cbBx.FormattingEnabled = true;
            this.Target_Coordinate_cbBx.Items.AddRange(new object[] {
            "大地坐标系",
            "子午面直角坐标系",
            "空间直角坐标系"});
            this.Target_Coordinate_cbBx.Location = new System.Drawing.Point(93, 66);
            this.Target_Coordinate_cbBx.Margin = new System.Windows.Forms.Padding(2);
            this.Target_Coordinate_cbBx.Name = "Target_Coordinate_cbBx";
            this.Target_Coordinate_cbBx.Size = new System.Drawing.Size(211, 20);
            this.Target_Coordinate_cbBx.TabIndex = 1;
            this.Target_Coordinate_cbBx.TabStop = false;
            this.Target_Coordinate_cbBx.SelectedIndexChanged += new System.EventHandler(this.Target_Coordinate_cbBx_SelectedIndexChanged);
            // 
            // Present_Coordinate_lbl
            // 
            this.Present_Coordinate_lbl.AutoSize = true;
            this.Present_Coordinate_lbl.Location = new System.Drawing.Point(16, 26);
            this.Present_Coordinate_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Present_Coordinate_lbl.Name = "Present_Coordinate_lbl";
            this.Present_Coordinate_lbl.Size = new System.Drawing.Size(77, 12);
            this.Present_Coordinate_lbl.TabIndex = 2;
            this.Present_Coordinate_lbl.Text = "已知坐标系：";
            // 
            // Target_Coordinate_lbl
            // 
            this.Target_Coordinate_lbl.AutoSize = true;
            this.Target_Coordinate_lbl.Location = new System.Drawing.Point(16, 68);
            this.Target_Coordinate_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Target_Coordinate_lbl.Name = "Target_Coordinate_lbl";
            this.Target_Coordinate_lbl.Size = new System.Drawing.Size(77, 12);
            this.Target_Coordinate_lbl.TabIndex = 3;
            this.Target_Coordinate_lbl.Text = "目标坐标系：";
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
            this.Input_gpBx.Controls.Add(this.x1_Sec_lbl);
            this.Input_gpBx.Controls.Add(this.x1_Min_lbl);
            this.Input_gpBx.Controls.Add(this.x1_Deg_lbl);
            this.Input_gpBx.Controls.Add(this.z1_lbl);
            this.Input_gpBx.Controls.Add(this.y1_lbl);
            this.Input_gpBx.Controls.Add(this.x1_lbl);
            this.Input_gpBx.Controls.Add(this.z1_txtBx);
            this.Input_gpBx.Controls.Add(this.x1_Meter_lbl);
            this.Input_gpBx.Controls.Add(this.x1_Deg_txtBx);
            this.Input_gpBx.Controls.Add(this.x1_txtBx);
            this.Input_gpBx.Controls.Add(this.y1_Deg_txtBx);
            this.Input_gpBx.Controls.Add(this.y1_txtBx);
            this.Input_gpBx.Controls.Add(this.y1_Sec_lbl);
            this.Input_gpBx.Controls.Add(this.y1_Meter_lbl);
            this.Input_gpBx.Location = new System.Drawing.Point(18, 120);
            this.Input_gpBx.Margin = new System.Windows.Forms.Padding(2);
            this.Input_gpBx.Name = "Input_gpBx";
            this.Input_gpBx.Padding = new System.Windows.Forms.Padding(2);
            this.Input_gpBx.Size = new System.Drawing.Size(315, 144);
            this.Input_gpBx.TabIndex = 10;
            this.Input_gpBx.TabStop = false;
            this.Input_gpBx.Text = "输入";
            // 
            // z1_Meter_lbl
            // 
            this.z1_Meter_lbl.AutoSize = true;
            this.z1_Meter_lbl.Location = new System.Drawing.Point(275, 106);
            this.z1_Meter_lbl.Name = "z1_Meter_lbl";
            this.z1_Meter_lbl.Size = new System.Drawing.Size(35, 12);
            this.z1_Meter_lbl.TabIndex = 32;
            this.z1_Meter_lbl.Text = "米(m)";
            this.z1_Meter_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Coordinate_Transfer_Form_MouseDown);
            // 
            // y1_Min_txtBx
            // 
            this.y1_Min_txtBx.Location = new System.Drawing.Point(150, 63);
            this.y1_Min_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.y1_Min_txtBx.Name = "y1_Min_txtBx";
            this.y1_Min_txtBx.Size = new System.Drawing.Size(40, 21);
            this.y1_Min_txtBx.TabIndex = 25;
            this.y1_Min_txtBx.TabStop = false;
            this.y1_Min_txtBx.Text = "0";
            this.y1_Min_txtBx.Visible = false;
            this.y1_Min_txtBx.Enter += new System.EventHandler(this.InputBx_Got_Focus);
            this.y1_Min_txtBx.Leave += new System.EventHandler(this.InputBx_Lose_Focus);
            // 
            // x1_Sec_txtBx
            // 
            this.x1_Sec_txtBx.Location = new System.Drawing.Point(234, 23);
            this.x1_Sec_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.x1_Sec_txtBx.Name = "x1_Sec_txtBx";
            this.x1_Sec_txtBx.Size = new System.Drawing.Size(40, 21);
            this.x1_Sec_txtBx.TabIndex = 28;
            this.x1_Sec_txtBx.TabStop = false;
            this.x1_Sec_txtBx.Text = "0";
            this.x1_Sec_txtBx.Visible = false;
            this.x1_Sec_txtBx.Enter += new System.EventHandler(this.InputBx_Got_Focus);
            this.x1_Sec_txtBx.Leave += new System.EventHandler(this.InputBx_Lose_Focus);
            // 
            // y1_Sec_txtBx
            // 
            this.y1_Sec_txtBx.Location = new System.Drawing.Point(234, 63);
            this.y1_Sec_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.y1_Sec_txtBx.Name = "y1_Sec_txtBx";
            this.y1_Sec_txtBx.Size = new System.Drawing.Size(40, 21);
            this.y1_Sec_txtBx.TabIndex = 27;
            this.y1_Sec_txtBx.TabStop = false;
            this.y1_Sec_txtBx.Text = "0";
            this.y1_Sec_txtBx.Visible = false;
            this.y1_Sec_txtBx.Enter += new System.EventHandler(this.InputBx_Got_Focus);
            this.y1_Sec_txtBx.Leave += new System.EventHandler(this.InputBx_Lose_Focus);
            // 
            // x1_Min_txtBx
            // 
            this.x1_Min_txtBx.Location = new System.Drawing.Point(150, 23);
            this.x1_Min_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.x1_Min_txtBx.Name = "x1_Min_txtBx";
            this.x1_Min_txtBx.Size = new System.Drawing.Size(40, 21);
            this.x1_Min_txtBx.TabIndex = 26;
            this.x1_Min_txtBx.TabStop = false;
            this.x1_Min_txtBx.Text = "0";
            this.x1_Min_txtBx.Visible = false;
            this.x1_Min_txtBx.Enter += new System.EventHandler(this.InputBx_Got_Focus);
            this.x1_Min_txtBx.Leave += new System.EventHandler(this.InputBx_Lose_Focus);
            // 
            // y1_Min_lbl
            // 
            this.y1_Min_lbl.AutoSize = true;
            this.y1_Min_lbl.Location = new System.Drawing.Point(196, 66);
            this.y1_Min_lbl.Name = "y1_Min_lbl";
            this.y1_Min_lbl.Size = new System.Drawing.Size(35, 12);
            this.y1_Min_lbl.TabIndex = 30;
            this.y1_Min_lbl.Text = "分(\')";
            this.y1_Min_lbl.Visible = false;
            this.y1_Min_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Coordinate_Transfer_Form_MouseDown);
            // 
            // y1_Deg_lbl
            // 
            this.y1_Deg_lbl.AutoSize = true;
            this.y1_Deg_lbl.Location = new System.Drawing.Point(103, 66);
            this.y1_Deg_lbl.Name = "y1_Deg_lbl";
            this.y1_Deg_lbl.Size = new System.Drawing.Size(41, 12);
            this.y1_Deg_lbl.TabIndex = 29;
            this.y1_Deg_lbl.Text = "度(°)";
            this.y1_Deg_lbl.Visible = false;
            this.y1_Deg_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Coordinate_Transfer_Form_MouseDown);
            // 
            // x1_Sec_lbl
            // 
            this.x1_Sec_lbl.AutoSize = true;
            this.x1_Sec_lbl.Location = new System.Drawing.Point(275, 28);
            this.x1_Sec_lbl.Name = "x1_Sec_lbl";
            this.x1_Sec_lbl.Size = new System.Drawing.Size(35, 12);
            this.x1_Sec_lbl.TabIndex = 24;
            this.x1_Sec_lbl.Text = "秒(\")";
            this.x1_Sec_lbl.Visible = false;
            this.x1_Sec_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Coordinate_Transfer_Form_MouseDown);
            // 
            // x1_Min_lbl
            // 
            this.x1_Min_lbl.AutoSize = true;
            this.x1_Min_lbl.Location = new System.Drawing.Point(196, 28);
            this.x1_Min_lbl.Name = "x1_Min_lbl";
            this.x1_Min_lbl.Size = new System.Drawing.Size(35, 12);
            this.x1_Min_lbl.TabIndex = 23;
            this.x1_Min_lbl.Text = "分(\')";
            this.x1_Min_lbl.Visible = false;
            this.x1_Min_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Coordinate_Transfer_Form_MouseDown);
            // 
            // x1_Deg_lbl
            // 
            this.x1_Deg_lbl.AutoSize = true;
            this.x1_Deg_lbl.Location = new System.Drawing.Point(103, 28);
            this.x1_Deg_lbl.Name = "x1_Deg_lbl";
            this.x1_Deg_lbl.Size = new System.Drawing.Size(41, 12);
            this.x1_Deg_lbl.TabIndex = 22;
            this.x1_Deg_lbl.Text = "度(°)";
            this.x1_Deg_lbl.Visible = false;
            this.x1_Deg_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Coordinate_Transfer_Form_MouseDown);
            // 
            // z1_lbl
            // 
            this.z1_lbl.AutoSize = true;
            this.z1_lbl.Location = new System.Drawing.Point(18, 106);
            this.z1_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.z1_lbl.Name = "z1_lbl";
            this.z1_lbl.Size = new System.Drawing.Size(17, 12);
            this.z1_lbl.TabIndex = 21;
            this.z1_lbl.Text = "z1";
            // 
            // y1_lbl
            // 
            this.y1_lbl.AutoSize = true;
            this.y1_lbl.Location = new System.Drawing.Point(18, 66);
            this.y1_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.y1_lbl.Name = "y1_lbl";
            this.y1_lbl.Size = new System.Drawing.Size(17, 12);
            this.y1_lbl.TabIndex = 20;
            this.y1_lbl.Text = "y1";
            // 
            // x1_lbl
            // 
            this.x1_lbl.AutoSize = true;
            this.x1_lbl.Location = new System.Drawing.Point(18, 26);
            this.x1_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x1_lbl.Name = "x1_lbl";
            this.x1_lbl.Size = new System.Drawing.Size(17, 12);
            this.x1_lbl.TabIndex = 19;
            this.x1_lbl.Text = "x1";
            // 
            // z1_txtBx
            // 
            this.z1_txtBx.Location = new System.Drawing.Point(60, 103);
            this.z1_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.z1_txtBx.Name = "z1_txtBx";
            this.z1_txtBx.Size = new System.Drawing.Size(214, 21);
            this.z1_txtBx.TabIndex = 18;
            this.z1_txtBx.TabStop = false;
            this.z1_txtBx.Text = "0";
            this.z1_txtBx.Enter += new System.EventHandler(this.InputBx_Got_Focus);
            this.z1_txtBx.Leave += new System.EventHandler(this.InputBx_Lose_Focus);
            // 
            // x1_Meter_lbl
            // 
            this.x1_Meter_lbl.AutoSize = true;
            this.x1_Meter_lbl.Location = new System.Drawing.Point(276, 28);
            this.x1_Meter_lbl.Name = "x1_Meter_lbl";
            this.x1_Meter_lbl.Size = new System.Drawing.Size(35, 12);
            this.x1_Meter_lbl.TabIndex = 34;
            this.x1_Meter_lbl.Text = "米(m)";
            this.x1_Meter_lbl.Visible = false;
            this.x1_Meter_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Coordinate_Transfer_Form_MouseDown);
            // 
            // x1_Deg_txtBx
            // 
            this.x1_Deg_txtBx.Location = new System.Drawing.Point(60, 23);
            this.x1_Deg_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.x1_Deg_txtBx.Name = "x1_Deg_txtBx";
            this.x1_Deg_txtBx.Size = new System.Drawing.Size(40, 21);
            this.x1_Deg_txtBx.TabIndex = 16;
            this.x1_Deg_txtBx.TabStop = false;
            this.x1_Deg_txtBx.Text = "0";
            this.x1_Deg_txtBx.Visible = false;
            this.x1_Deg_txtBx.Enter += new System.EventHandler(this.InputBx_Got_Focus);
            this.x1_Deg_txtBx.Leave += new System.EventHandler(this.InputBx_Lose_Focus);
            // 
            // x1_txtBx
            // 
            this.x1_txtBx.Location = new System.Drawing.Point(60, 23);
            this.x1_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.x1_txtBx.Name = "x1_txtBx";
            this.x1_txtBx.Size = new System.Drawing.Size(214, 21);
            this.x1_txtBx.TabIndex = 36;
            this.x1_txtBx.TabStop = false;
            this.x1_txtBx.Text = "0";
            this.x1_txtBx.Visible = false;
            this.x1_txtBx.Enter += new System.EventHandler(this.InputBx_Got_Focus);
            this.x1_txtBx.Leave += new System.EventHandler(this.InputBx_Lose_Focus);
            // 
            // y1_Deg_txtBx
            // 
            this.y1_Deg_txtBx.Location = new System.Drawing.Point(60, 63);
            this.y1_Deg_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.y1_Deg_txtBx.Name = "y1_Deg_txtBx";
            this.y1_Deg_txtBx.Size = new System.Drawing.Size(40, 21);
            this.y1_Deg_txtBx.TabIndex = 17;
            this.y1_Deg_txtBx.TabStop = false;
            this.y1_Deg_txtBx.Text = "0";
            this.y1_Deg_txtBx.Visible = false;
            this.y1_Deg_txtBx.Enter += new System.EventHandler(this.InputBx_Got_Focus);
            this.y1_Deg_txtBx.Leave += new System.EventHandler(this.InputBx_Lose_Focus);
            // 
            // y1_txtBx
            // 
            this.y1_txtBx.Location = new System.Drawing.Point(60, 63);
            this.y1_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.y1_txtBx.Name = "y1_txtBx";
            this.y1_txtBx.Size = new System.Drawing.Size(214, 21);
            this.y1_txtBx.TabIndex = 35;
            this.y1_txtBx.TabStop = false;
            this.y1_txtBx.Text = "0";
            this.y1_txtBx.Visible = false;
            this.y1_txtBx.Enter += new System.EventHandler(this.InputBx_Got_Focus);
            this.y1_txtBx.Leave += new System.EventHandler(this.InputBx_Lose_Focus);
            // 
            // y1_Sec_lbl
            // 
            this.y1_Sec_lbl.AutoSize = true;
            this.y1_Sec_lbl.Location = new System.Drawing.Point(275, 66);
            this.y1_Sec_lbl.Name = "y1_Sec_lbl";
            this.y1_Sec_lbl.Size = new System.Drawing.Size(35, 12);
            this.y1_Sec_lbl.TabIndex = 31;
            this.y1_Sec_lbl.Text = "秒(\")";
            this.y1_Sec_lbl.Visible = false;
            this.y1_Sec_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Coordinate_Transfer_Form_MouseDown);
            // 
            // y1_Meter_lbl
            // 
            this.y1_Meter_lbl.AutoSize = true;
            this.y1_Meter_lbl.Location = new System.Drawing.Point(275, 66);
            this.y1_Meter_lbl.Name = "y1_Meter_lbl";
            this.y1_Meter_lbl.Size = new System.Drawing.Size(35, 12);
            this.y1_Meter_lbl.TabIndex = 33;
            this.y1_Meter_lbl.Text = "米(m)";
            this.y1_Meter_lbl.Visible = false;
            this.y1_Meter_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Coordinate_Transfer_Form_MouseDown);
            // 
            // Output_gpBx
            // 
            this.Output_gpBx.Controls.Add(this.z2_Meter_lbl);
            this.Output_gpBx.Controls.Add(this.y2_Min_txtBx);
            this.Output_gpBx.Controls.Add(this.y2_Sec_txtBx);
            this.Output_gpBx.Controls.Add(this.y2_Sec_lbl);
            this.Output_gpBx.Controls.Add(this.y2_Min_lbl);
            this.Output_gpBx.Controls.Add(this.y2_Deg_lbl);
            this.Output_gpBx.Controls.Add(this.x2_Sec_lbl);
            this.Output_gpBx.Controls.Add(this.z2_lbl);
            this.Output_gpBx.Controls.Add(this.y2_lbl);
            this.Output_gpBx.Controls.Add(this.x2_lbl);
            this.Output_gpBx.Controls.Add(this.z2_txtBx);
            this.Output_gpBx.Controls.Add(this.label1);
            this.Output_gpBx.Controls.Add(this.label2);
            this.Output_gpBx.Controls.Add(this.x2_Sec_txtBx);
            this.Output_gpBx.Controls.Add(this.x2_Min_txtBx);
            this.Output_gpBx.Controls.Add(this.x2_Min_lbl);
            this.Output_gpBx.Controls.Add(this.x2_Deg_lbl);
            this.Output_gpBx.Controls.Add(this.x2_Meter_lbl);
            this.Output_gpBx.Controls.Add(this.y2_Meter_lbl);
            this.Output_gpBx.Controls.Add(this.x2_Deg_txtBx);
            this.Output_gpBx.Controls.Add(this.y2_Deg_txtBx);
            this.Output_gpBx.Controls.Add(this.x2_txtBx);
            this.Output_gpBx.Controls.Add(this.y2_txtBx);
            this.Output_gpBx.Location = new System.Drawing.Point(18, 296);
            this.Output_gpBx.Margin = new System.Windows.Forms.Padding(2);
            this.Output_gpBx.Name = "Output_gpBx";
            this.Output_gpBx.Padding = new System.Windows.Forms.Padding(2);
            this.Output_gpBx.Size = new System.Drawing.Size(315, 144);
            this.Output_gpBx.TabIndex = 0;
            this.Output_gpBx.TabStop = false;
            this.Output_gpBx.Text = "输出";
            // 
            // z2_Meter_lbl
            // 
            this.z2_Meter_lbl.AutoSize = true;
            this.z2_Meter_lbl.Location = new System.Drawing.Point(275, 106);
            this.z2_Meter_lbl.Name = "z2_Meter_lbl";
            this.z2_Meter_lbl.Size = new System.Drawing.Size(35, 12);
            this.z2_Meter_lbl.TabIndex = 44;
            this.z2_Meter_lbl.Text = "米(m)";
            this.z2_Meter_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Coordinate_Transfer_Form_MouseDown);
            // 
            // y2_Min_txtBx
            // 
            this.y2_Min_txtBx.Location = new System.Drawing.Point(150, 63);
            this.y2_Min_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.y2_Min_txtBx.Name = "y2_Min_txtBx";
            this.y2_Min_txtBx.ReadOnly = true;
            this.y2_Min_txtBx.Size = new System.Drawing.Size(40, 21);
            this.y2_Min_txtBx.TabIndex = 37;
            this.y2_Min_txtBx.TabStop = false;
            this.y2_Min_txtBx.Visible = false;
            // 
            // y2_Sec_txtBx
            // 
            this.y2_Sec_txtBx.Location = new System.Drawing.Point(234, 63);
            this.y2_Sec_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.y2_Sec_txtBx.Name = "y2_Sec_txtBx";
            this.y2_Sec_txtBx.ReadOnly = true;
            this.y2_Sec_txtBx.Size = new System.Drawing.Size(40, 21);
            this.y2_Sec_txtBx.TabIndex = 39;
            this.y2_Sec_txtBx.TabStop = false;
            this.y2_Sec_txtBx.Visible = false;
            // 
            // y2_Sec_lbl
            // 
            this.y2_Sec_lbl.AutoSize = true;
            this.y2_Sec_lbl.Location = new System.Drawing.Point(275, 66);
            this.y2_Sec_lbl.Name = "y2_Sec_lbl";
            this.y2_Sec_lbl.Size = new System.Drawing.Size(35, 12);
            this.y2_Sec_lbl.TabIndex = 43;
            this.y2_Sec_lbl.Text = "秒(\")";
            this.y2_Sec_lbl.Visible = false;
            this.y2_Sec_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Coordinate_Transfer_Form_MouseDown);
            // 
            // y2_Min_lbl
            // 
            this.y2_Min_lbl.AutoSize = true;
            this.y2_Min_lbl.Location = new System.Drawing.Point(196, 66);
            this.y2_Min_lbl.Name = "y2_Min_lbl";
            this.y2_Min_lbl.Size = new System.Drawing.Size(35, 12);
            this.y2_Min_lbl.TabIndex = 42;
            this.y2_Min_lbl.Text = "分(\')";
            this.y2_Min_lbl.Visible = false;
            this.y2_Min_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Coordinate_Transfer_Form_MouseDown);
            // 
            // y2_Deg_lbl
            // 
            this.y2_Deg_lbl.AutoSize = true;
            this.y2_Deg_lbl.Location = new System.Drawing.Point(103, 66);
            this.y2_Deg_lbl.Name = "y2_Deg_lbl";
            this.y2_Deg_lbl.Size = new System.Drawing.Size(41, 12);
            this.y2_Deg_lbl.TabIndex = 41;
            this.y2_Deg_lbl.Text = "度(°)";
            this.y2_Deg_lbl.Visible = false;
            this.y2_Deg_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Coordinate_Transfer_Form_MouseDown);
            // 
            // x2_Sec_lbl
            // 
            this.x2_Sec_lbl.AutoSize = true;
            this.x2_Sec_lbl.Location = new System.Drawing.Point(275, 28);
            this.x2_Sec_lbl.Name = "x2_Sec_lbl";
            this.x2_Sec_lbl.Size = new System.Drawing.Size(35, 12);
            this.x2_Sec_lbl.TabIndex = 36;
            this.x2_Sec_lbl.Text = "秒(\")";
            this.x2_Sec_lbl.Visible = false;
            this.x2_Sec_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Coordinate_Transfer_Form_MouseDown);
            // 
            // z2_lbl
            // 
            this.z2_lbl.AutoSize = true;
            this.z2_lbl.Location = new System.Drawing.Point(18, 106);
            this.z2_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.z2_lbl.Name = "z2_lbl";
            this.z2_lbl.Size = new System.Drawing.Size(17, 12);
            this.z2_lbl.TabIndex = 24;
            this.z2_lbl.Text = "z2";
            // 
            // y2_lbl
            // 
            this.y2_lbl.AutoSize = true;
            this.y2_lbl.Location = new System.Drawing.Point(18, 66);
            this.y2_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.y2_lbl.Name = "y2_lbl";
            this.y2_lbl.Size = new System.Drawing.Size(17, 12);
            this.y2_lbl.TabIndex = 23;
            this.y2_lbl.Text = "y2";
            // 
            // x2_lbl
            // 
            this.x2_lbl.AutoSize = true;
            this.x2_lbl.Location = new System.Drawing.Point(18, 26);
            this.x2_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.x2_lbl.Name = "x2_lbl";
            this.x2_lbl.Size = new System.Drawing.Size(17, 12);
            this.x2_lbl.TabIndex = 22;
            this.x2_lbl.Text = "x2";
            // 
            // z2_txtBx
            // 
            this.z2_txtBx.Location = new System.Drawing.Point(60, 103);
            this.z2_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.z2_txtBx.Name = "z2_txtBx";
            this.z2_txtBx.ReadOnly = true;
            this.z2_txtBx.Size = new System.Drawing.Size(214, 21);
            this.z2_txtBx.TabIndex = 15;
            this.z2_txtBx.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 48;
            this.label1.Text = "米(m)";
            this.label1.Visible = false;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Coordinate_Transfer_Form_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 47;
            this.label2.Text = "米(m)";
            this.label2.Visible = false;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Coordinate_Transfer_Form_MouseDown);
            // 
            // x2_Sec_txtBx
            // 
            this.x2_Sec_txtBx.Location = new System.Drawing.Point(234, 23);
            this.x2_Sec_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.x2_Sec_txtBx.Name = "x2_Sec_txtBx";
            this.x2_Sec_txtBx.ReadOnly = true;
            this.x2_Sec_txtBx.Size = new System.Drawing.Size(40, 21);
            this.x2_Sec_txtBx.TabIndex = 40;
            this.x2_Sec_txtBx.TabStop = false;
            this.x2_Sec_txtBx.Visible = false;
            // 
            // x2_Min_txtBx
            // 
            this.x2_Min_txtBx.Location = new System.Drawing.Point(150, 23);
            this.x2_Min_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.x2_Min_txtBx.Name = "x2_Min_txtBx";
            this.x2_Min_txtBx.ReadOnly = true;
            this.x2_Min_txtBx.Size = new System.Drawing.Size(40, 21);
            this.x2_Min_txtBx.TabIndex = 38;
            this.x2_Min_txtBx.TabStop = false;
            this.x2_Min_txtBx.Visible = false;
            // 
            // x2_Min_lbl
            // 
            this.x2_Min_lbl.AutoSize = true;
            this.x2_Min_lbl.Location = new System.Drawing.Point(196, 28);
            this.x2_Min_lbl.Name = "x2_Min_lbl";
            this.x2_Min_lbl.Size = new System.Drawing.Size(35, 12);
            this.x2_Min_lbl.TabIndex = 35;
            this.x2_Min_lbl.Text = "分(\')";
            this.x2_Min_lbl.Visible = false;
            this.x2_Min_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Coordinate_Transfer_Form_MouseDown);
            // 
            // x2_Deg_lbl
            // 
            this.x2_Deg_lbl.AutoSize = true;
            this.x2_Deg_lbl.Location = new System.Drawing.Point(103, 28);
            this.x2_Deg_lbl.Name = "x2_Deg_lbl";
            this.x2_Deg_lbl.Size = new System.Drawing.Size(41, 12);
            this.x2_Deg_lbl.TabIndex = 34;
            this.x2_Deg_lbl.Text = "度(°)";
            this.x2_Deg_lbl.Visible = false;
            this.x2_Deg_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Coordinate_Transfer_Form_MouseDown);
            // 
            // x2_Meter_lbl
            // 
            this.x2_Meter_lbl.AutoSize = true;
            this.x2_Meter_lbl.Location = new System.Drawing.Point(275, 28);
            this.x2_Meter_lbl.Name = "x2_Meter_lbl";
            this.x2_Meter_lbl.Size = new System.Drawing.Size(35, 12);
            this.x2_Meter_lbl.TabIndex = 38;
            this.x2_Meter_lbl.Text = "米(m)";
            this.x2_Meter_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Coordinate_Transfer_Form_MouseDown);
            // 
            // y2_Meter_lbl
            // 
            this.y2_Meter_lbl.AutoSize = true;
            this.y2_Meter_lbl.Location = new System.Drawing.Point(275, 66);
            this.y2_Meter_lbl.Name = "y2_Meter_lbl";
            this.y2_Meter_lbl.Size = new System.Drawing.Size(35, 12);
            this.y2_Meter_lbl.TabIndex = 37;
            this.y2_Meter_lbl.Text = "米(m)";
            this.y2_Meter_lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Coordinate_Transfer_Form_MouseDown);
            // 
            // x2_Deg_txtBx
            // 
            this.x2_Deg_txtBx.Location = new System.Drawing.Point(60, 23);
            this.x2_Deg_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.x2_Deg_txtBx.Name = "x2_Deg_txtBx";
            this.x2_Deg_txtBx.ReadOnly = true;
            this.x2_Deg_txtBx.Size = new System.Drawing.Size(40, 21);
            this.x2_Deg_txtBx.TabIndex = 32;
            this.x2_Deg_txtBx.TabStop = false;
            this.x2_Deg_txtBx.Visible = false;
            // 
            // y2_Deg_txtBx
            // 
            this.y2_Deg_txtBx.Location = new System.Drawing.Point(60, 63);
            this.y2_Deg_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.y2_Deg_txtBx.Name = "y2_Deg_txtBx";
            this.y2_Deg_txtBx.ReadOnly = true;
            this.y2_Deg_txtBx.Size = new System.Drawing.Size(40, 21);
            this.y2_Deg_txtBx.TabIndex = 33;
            this.y2_Deg_txtBx.TabStop = false;
            this.y2_Deg_txtBx.Visible = false;
            // 
            // x2_txtBx
            // 
            this.x2_txtBx.Location = new System.Drawing.Point(60, 23);
            this.x2_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.x2_txtBx.Name = "x2_txtBx";
            this.x2_txtBx.ReadOnly = true;
            this.x2_txtBx.Size = new System.Drawing.Size(214, 21);
            this.x2_txtBx.TabIndex = 46;
            this.x2_txtBx.TabStop = false;
            this.x2_txtBx.Visible = false;
            // 
            // y2_txtBx
            // 
            this.y2_txtBx.Location = new System.Drawing.Point(60, 63);
            this.y2_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.y2_txtBx.Name = "y2_txtBx";
            this.y2_txtBx.ReadOnly = true;
            this.y2_txtBx.Size = new System.Drawing.Size(214, 21);
            this.y2_txtBx.TabIndex = 45;
            this.y2_txtBx.TabStop = false;
            this.y2_txtBx.Visible = false;
            // 
            // Transfer_btn
            // 
            this.Transfer_btn.Location = new System.Drawing.Point(135, 270);
            this.Transfer_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Transfer_btn.Name = "Transfer_btn";
            this.Transfer_btn.Size = new System.Drawing.Size(56, 26);
            this.Transfer_btn.TabIndex = 11;
            this.Transfer_btn.TabStop = false;
            this.Transfer_btn.Text = "转换";
            this.Transfer_btn.UseVisualStyleBackColor = true;
            this.Transfer_btn.Click += new System.EventHandler(this.Transfer_btn_Click);
            // 
            // Coordinate_Transfer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(344, 474);
            this.Controls.Add(this.Transfer_btn);
            this.Controls.Add(this.Output_gpBx);
            this.Controls.Add(this.Input_gpBx);
            this.Controls.Add(this.Target_Coordinate_lbl);
            this.Controls.Add(this.Present_Coordinate_lbl);
            this.Controls.Add(this.Target_Coordinate_cbBx);
            this.Controls.Add(this.Present_Coordinate_cbBx);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Coordinate_Transfer_Form";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "坐标系转换";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Coordinate_Transfer_Form_MouseDown);
            this.Input_gpBx.ResumeLayout(false);
            this.Input_gpBx.PerformLayout();
            this.Output_gpBx.ResumeLayout(false);
            this.Output_gpBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Present_Coordinate_cbBx;
        private System.Windows.Forms.ComboBox Target_Coordinate_cbBx;
        private System.Windows.Forms.Label Present_Coordinate_lbl;
        private System.Windows.Forms.Label Target_Coordinate_lbl;
        private System.Windows.Forms.GroupBox Input_gpBx;
        private System.Windows.Forms.Label z1_lbl;
        private System.Windows.Forms.Label y1_lbl;
        private System.Windows.Forms.Label x1_lbl;
        private System.Windows.Forms.TextBox z1_txtBx;
        private System.Windows.Forms.TextBox y1_Deg_txtBx;
        private System.Windows.Forms.TextBox x1_Deg_txtBx;
        private System.Windows.Forms.GroupBox Output_gpBx;
        private System.Windows.Forms.Label z2_lbl;
        private System.Windows.Forms.Label y2_lbl;
        private System.Windows.Forms.Label x2_lbl;
        private System.Windows.Forms.TextBox z2_txtBx;
        private System.Windows.Forms.Button Transfer_btn;
        private System.Windows.Forms.TextBox x1_Min_txtBx;
        private System.Windows.Forms.TextBox y1_Min_txtBx;
        private System.Windows.Forms.Label x1_Sec_lbl;
        private System.Windows.Forms.Label x1_Min_lbl;
        private System.Windows.Forms.Label x1_Deg_lbl;
        private System.Windows.Forms.TextBox x1_Sec_txtBx;
        private System.Windows.Forms.TextBox y1_Sec_txtBx;
        private System.Windows.Forms.Label y1_Sec_lbl;
        private System.Windows.Forms.Label y1_Min_lbl;
        private System.Windows.Forms.Label y1_Deg_lbl;
        private System.Windows.Forms.TextBox y2_Min_txtBx;
        private System.Windows.Forms.TextBox x2_Sec_txtBx;
        private System.Windows.Forms.TextBox y2_Sec_txtBx;
        private System.Windows.Forms.TextBox x2_Min_txtBx;
        private System.Windows.Forms.TextBox y2_Deg_txtBx;
        private System.Windows.Forms.TextBox x2_Deg_txtBx;
        private System.Windows.Forms.Label y2_Sec_lbl;
        private System.Windows.Forms.Label y2_Min_lbl;
        private System.Windows.Forms.Label y2_Deg_lbl;
        private System.Windows.Forms.Label x2_Sec_lbl;
        private System.Windows.Forms.Label x2_Min_lbl;
        private System.Windows.Forms.Label x2_Deg_lbl;
        private System.Windows.Forms.Label z1_Meter_lbl;
        private System.Windows.Forms.Label z2_Meter_lbl;
        private System.Windows.Forms.TextBox x1_txtBx;
        private System.Windows.Forms.TextBox y1_txtBx;
        private System.Windows.Forms.Label x1_Meter_lbl;
        private System.Windows.Forms.Label y1_Meter_lbl;
        private System.Windows.Forms.TextBox x2_txtBx;
        private System.Windows.Forms.TextBox y2_txtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label x2_Meter_lbl;
        private System.Windows.Forms.Label y2_Meter_lbl;
    }
}

