namespace MySystem
{
    public partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu_ms = new System.Windows.Forms.MenuStrip();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Setting_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.MainForm_ss = new System.Windows.Forms.StatusStrip();
            this.Current_Ellipsoid_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.Empty_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.Current_Coordinate_System_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.Current_Unit_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainForm_tls = new System.Windows.Forms.ToolStrip();
            this.CS_Transfer_tsbt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.Setting_tsBt = new System.Windows.Forms.ToolStripButton();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.打印PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印预览VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤消UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重复RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.剪切TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.全选AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.内容CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.索引IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜索SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ellipsoid_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Ellipsoid_Transfer_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Ellipsoid_Properties_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Coordinate_System_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Coordinate_System_Transfer_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_ms.SuspendLayout();
            this.MainForm_ss.SuspendLayout();
            this.MainForm_tls.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu_ms
            // 
            this.MainMenu_ms.BackColor = System.Drawing.SystemColors.Menu;
            this.MainMenu_ms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu_ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.工具TToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.MainMenu_ms.Location = new System.Drawing.Point(0, 0);
            this.MainMenu_ms.Name = "MainMenu_ms";
            this.MainMenu_ms.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MainMenu_ms.Size = new System.Drawing.Size(984, 25);
            this.MainMenu_ms.TabIndex = 0;
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Setting_tsmi,
            this.Ellipsoid_tsmi,
            this.Coordinate_System_tsmi});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // Setting_tsmi
            // 
            this.Setting_tsmi.Image = ((System.Drawing.Image)(resources.GetObject("Setting_tsmi.Image")));
            this.Setting_tsmi.Name = "Setting_tsmi";
            this.Setting_tsmi.Size = new System.Drawing.Size(184, 26);
            this.Setting_tsmi.Text = "配置(&S)";
            this.Setting_tsmi.Click += new System.EventHandler(this.Setting_tsmi_Click);
            // 
            // MainForm_ss
            // 
            this.MainForm_ss.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainForm_ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Current_Ellipsoid_tssl,
            this.Empty_tssl,
            this.Current_Coordinate_System_tssl,
            this.Current_Unit_tssl});
            this.MainForm_ss.Location = new System.Drawing.Point(0, 553);
            this.MainForm_ss.Name = "MainForm_ss";
            this.MainForm_ss.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.MainForm_ss.Size = new System.Drawing.Size(984, 26);
            this.MainForm_ss.TabIndex = 1;
            this.MainForm_ss.Text = "statusStrip1";
            // 
            // Current_Ellipsoid_tssl
            // 
            this.Current_Ellipsoid_tssl.AutoSize = false;
            this.Current_Ellipsoid_tssl.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Current_Ellipsoid_tssl.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.Current_Ellipsoid_tssl.Name = "Current_Ellipsoid_tssl";
            this.Current_Ellipsoid_tssl.Size = new System.Drawing.Size(200, 21);
            this.Current_Ellipsoid_tssl.Text = "Current_Ellipsoid";
            this.Current_Ellipsoid_tssl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Empty_tssl
            // 
            this.Empty_tssl.AutoSize = false;
            this.Empty_tssl.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Empty_tssl.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.Empty_tssl.Name = "Empty_tssl";
            this.Empty_tssl.Size = new System.Drawing.Size(455, 21);
            // 
            // Current_Coordinate_System_tssl
            // 
            this.Current_Coordinate_System_tssl.AutoSize = false;
            this.Current_Coordinate_System_tssl.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Current_Coordinate_System_tssl.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.Current_Coordinate_System_tssl.Name = "Current_Coordinate_System_tssl";
            this.Current_Coordinate_System_tssl.Size = new System.Drawing.Size(180, 21);
            this.Current_Coordinate_System_tssl.Text = "Current_Coordinate_System";
            this.Current_Coordinate_System_tssl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Current_Unit_tssl
            // 
            this.Current_Unit_tssl.AutoSize = false;
            this.Current_Unit_tssl.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Current_Unit_tssl.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.Current_Unit_tssl.Name = "Current_Unit_tssl";
            this.Current_Unit_tssl.Size = new System.Drawing.Size(120, 21);
            this.Current_Unit_tssl.Text = "Current_Unit";
            // 
            // MainForm_tls
            // 
            this.MainForm_tls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CS_Transfer_tsbt,
            this.toolStripSeparator9,
            this.Setting_tsBt});
            this.MainForm_tls.Location = new System.Drawing.Point(0, 25);
            this.MainForm_tls.Name = "MainForm_tls";
            this.MainForm_tls.Padding = new System.Windows.Forms.Padding(1);
            this.MainForm_tls.Size = new System.Drawing.Size(984, 25);
            this.MainForm_tls.Stretch = true;
            this.MainForm_tls.TabIndex = 3;
            this.MainForm_tls.Text = "toolStrip1";
            // 
            // CS_Transfer_tsbt
            // 
            this.CS_Transfer_tsbt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CS_Transfer_tsbt.Image = ((System.Drawing.Image)(resources.GetObject("CS_Transfer_tsbt.Image")));
            this.CS_Transfer_tsbt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CS_Transfer_tsbt.Name = "CS_Transfer_tsbt";
            this.CS_Transfer_tsbt.Size = new System.Drawing.Size(23, 20);
            this.CS_Transfer_tsbt.Text = "坐标系转换";
            this.CS_Transfer_tsbt.Click += new System.EventHandler(this.CS_Transfer_tsmi_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 23);
            // 
            // Setting_tsBt
            // 
            this.Setting_tsBt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Setting_tsBt.Image = ((System.Drawing.Image)(resources.GetObject("Setting_tsBt.Image")));
            this.Setting_tsBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Setting_tsBt.Name = "Setting_tsBt";
            this.Setting_tsBt.Size = new System.Drawing.Size(23, 20);
            this.Setting_tsBt.Text = "toolStripButton1";
            this.Setting_tsBt.Click += new System.EventHandler(this.Setting_tsmi_Click);
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripMenuItem,
            this.打开OToolStripMenuItem,
            this.toolStripSeparator,
            this.保存SToolStripMenuItem,
            this.另存为AToolStripMenuItem,
            this.toolStripSeparator1,
            this.打印PToolStripMenuItem,
            this.打印预览VToolStripMenuItem,
            this.toolStripSeparator2,
            this.退出XToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 新建NToolStripMenuItem
            // 
            this.新建NToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("新建NToolStripMenuItem.Image")));
            this.新建NToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem";
            this.新建NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建NToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.新建NToolStripMenuItem.Text = "新建(&N)";
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打开OToolStripMenuItem.Image")));
            this.打开OToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.打开OToolStripMenuItem.Text = "打开(&O)";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(181, 6);
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("保存SToolStripMenuItem.Image")));
            this.保存SToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.保存SToolStripMenuItem.Text = "保存(&S)";
            // 
            // 另存为AToolStripMenuItem
            // 
            this.另存为AToolStripMenuItem.Name = "另存为AToolStripMenuItem";
            this.另存为AToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.另存为AToolStripMenuItem.Text = "另存为(&A)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // 打印PToolStripMenuItem
            // 
            this.打印PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打印PToolStripMenuItem.Image")));
            this.打印PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打印PToolStripMenuItem.Name = "打印PToolStripMenuItem";
            this.打印PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.打印PToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.打印PToolStripMenuItem.Text = "打印(&P)";
            // 
            // 打印预览VToolStripMenuItem
            // 
            this.打印预览VToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打印预览VToolStripMenuItem.Image")));
            this.打印预览VToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打印预览VToolStripMenuItem.Name = "打印预览VToolStripMenuItem";
            this.打印预览VToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.打印预览VToolStripMenuItem.Text = "打印预览(&V)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤消UToolStripMenuItem,
            this.重复RToolStripMenuItem,
            this.toolStripSeparator3,
            this.剪切TToolStripMenuItem,
            this.复制CToolStripMenuItem,
            this.粘贴PToolStripMenuItem,
            this.toolStripSeparator4,
            this.全选AToolStripMenuItem});
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.编辑EToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 撤消UToolStripMenuItem
            // 
            this.撤消UToolStripMenuItem.Name = "撤消UToolStripMenuItem";
            this.撤消UToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.撤消UToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.撤消UToolStripMenuItem.Text = "撤消(&U)";
            // 
            // 重复RToolStripMenuItem
            // 
            this.重复RToolStripMenuItem.Name = "重复RToolStripMenuItem";
            this.重复RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.重复RToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.重复RToolStripMenuItem.Text = "重复(&R)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(181, 6);
            // 
            // 剪切TToolStripMenuItem
            // 
            this.剪切TToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("剪切TToolStripMenuItem.Image")));
            this.剪切TToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪切TToolStripMenuItem.Name = "剪切TToolStripMenuItem";
            this.剪切TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.剪切TToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.剪切TToolStripMenuItem.Text = "剪切(&T)";
            // 
            // 复制CToolStripMenuItem
            // 
            this.复制CToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("复制CToolStripMenuItem.Image")));
            this.复制CToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem";
            this.复制CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.复制CToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.复制CToolStripMenuItem.Text = "复制(&C)";
            // 
            // 粘贴PToolStripMenuItem
            // 
            this.粘贴PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("粘贴PToolStripMenuItem.Image")));
            this.粘贴PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.粘贴PToolStripMenuItem.Name = "粘贴PToolStripMenuItem";
            this.粘贴PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.粘贴PToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.粘贴PToolStripMenuItem.Text = "粘贴(&P)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(181, 6);
            // 
            // 全选AToolStripMenuItem
            // 
            this.全选AToolStripMenuItem.Name = "全选AToolStripMenuItem";
            this.全选AToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.全选AToolStripMenuItem.Text = "全选(&A)";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.内容CToolStripMenuItem,
            this.索引IToolStripMenuItem,
            this.搜索SToolStripMenuItem,
            this.toolStripSeparator5,
            this.关于AToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 内容CToolStripMenuItem
            // 
            this.内容CToolStripMenuItem.Name = "内容CToolStripMenuItem";
            this.内容CToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.内容CToolStripMenuItem.Text = "内容(&C)";
            // 
            // 索引IToolStripMenuItem
            // 
            this.索引IToolStripMenuItem.Name = "索引IToolStripMenuItem";
            this.索引IToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.索引IToolStripMenuItem.Text = "索引(&I)";
            // 
            // 搜索SToolStripMenuItem
            // 
            this.搜索SToolStripMenuItem.Name = "搜索SToolStripMenuItem";
            this.搜索SToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.搜索SToolStripMenuItem.Text = "搜索(&S)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.关于AToolStripMenuItem.Text = "关于(&A)...";
            // 
            // Ellipsoid_tsmi
            // 
            this.Ellipsoid_tsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ellipsoid_Properties_tsmi,
            this.Ellipsoid_Transfer_tsmi});
            this.Ellipsoid_tsmi.Name = "Ellipsoid_tsmi";
            this.Ellipsoid_tsmi.Size = new System.Drawing.Size(184, 26);
            this.Ellipsoid_tsmi.Text = "椭球体(&E)";
            // 
            // Ellipsoid_Transfer_tsmi
            // 
            this.Ellipsoid_Transfer_tsmi.Name = "Ellipsoid_Transfer_tsmi";
            this.Ellipsoid_Transfer_tsmi.Size = new System.Drawing.Size(180, 22);
            this.Ellipsoid_Transfer_tsmi.Text = "转换(&T)";
            this.Ellipsoid_Transfer_tsmi.Click += new System.EventHandler(this.Ellipsoid_Transfer_tsmi_Click);
            // 
            // Ellipsoid_Properties_tsmi
            // 
            this.Ellipsoid_Properties_tsmi.Name = "Ellipsoid_Properties_tsmi";
            this.Ellipsoid_Properties_tsmi.Size = new System.Drawing.Size(180, 22);
            this.Ellipsoid_Properties_tsmi.Text = "查看参数(&S)";
            this.Ellipsoid_Properties_tsmi.Click += new System.EventHandler(this.Ellipsoid_Properties_tsmi_Click);
            // 
            // Coordinate_System_tsmi
            // 
            this.Coordinate_System_tsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Coordinate_System_Transfer_tsmi});
            this.Coordinate_System_tsmi.Name = "Coordinate_System_tsmi";
            this.Coordinate_System_tsmi.Size = new System.Drawing.Size(184, 26);
            this.Coordinate_System_tsmi.Text = "坐标系(&C)";
            // 
            // Coordinate_System_Transfer_tsmi
            // 
            this.Coordinate_System_Transfer_tsmi.Image = ((System.Drawing.Image)(resources.GetObject("Coordinate_System_Transfer_tsmi.Image")));
            this.Coordinate_System_Transfer_tsmi.Name = "Coordinate_System_Transfer_tsmi";
            this.Coordinate_System_Transfer_tsmi.Size = new System.Drawing.Size(184, 26);
            this.Coordinate_System_Transfer_tsmi.Text = "转换(&T)";
            this.Coordinate_System_Transfer_tsmi.Click += new System.EventHandler(this.CS_Transfer_tsmi_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 579);
            this.Controls.Add(this.MainForm_tls);
            this.Controls.Add(this.MainForm_ss);
            this.Controls.Add(this.MainMenu_ms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu_ms;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "大地测量学软件系统";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.MainMenu_ms.ResumeLayout(false);
            this.MainMenu_ms.PerformLayout();
            this.MainForm_ss.ResumeLayout(false);
            this.MainForm_ss.PerformLayout();
            this.MainForm_tls.ResumeLayout(false);
            this.MainForm_tls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu_ms;

        //底部消息栏
        private System.Windows.Forms.StatusStrip MainForm_ss;
        private System.Windows.Forms.ToolStripStatusLabel Current_Ellipsoid_tssl;
        private System.Windows.Forms.ToolStripStatusLabel Current_Coordinate_System_tssl;
        private System.Windows.Forms.ToolStripStatusLabel Empty_tssl;
        private System.Windows.Forms.ToolStripStatusLabel Current_Unit_tssl;
        private System.Windows.Forms.ToolStrip MainForm_tls;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Setting_tsmi;
        private System.Windows.Forms.ToolStripButton CS_Transfer_tsbt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton Setting_tsBt;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 打印PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印预览VToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤消UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重复RToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 剪切TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴PToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 全选AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 内容CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 索引IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搜索SToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Ellipsoid_tsmi;
        private System.Windows.Forms.ToolStripMenuItem Ellipsoid_Properties_tsmi;
        private System.Windows.Forms.ToolStripMenuItem Ellipsoid_Transfer_tsmi;
        private System.Windows.Forms.ToolStripMenuItem Coordinate_System_tsmi;
        private System.Windows.Forms.ToolStripMenuItem Coordinate_System_Transfer_tsmi;
    }
}

