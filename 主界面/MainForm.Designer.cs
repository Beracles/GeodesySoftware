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
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ellipsoid_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Ellipsoid_Properties_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Ellipsoid_Transfer_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.GetLatitudeByMeridianArcLength_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.GetMeridianArcLengthByLatitude_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.MainForm_ss = new System.Windows.Forms.StatusStrip();
            this.Current_Ellipsoid_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.Empty_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.Current_Coordinate_System_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.Current_Unit_tssl = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainForm_tls = new System.Windows.Forms.ToolStrip();
            this.CS_Transfer_tsbt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.Setting_tsBt = new System.Windows.Forms.ToolStripButton();
            this.MainForm_tlSC = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.GetLatitudeByMeridianArcLength_tsbt = new System.Windows.Forms.ToolStripButton();
            this.Setting_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Coordinate_System_Transfer_tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_ms.SuspendLayout();
            this.MainForm_ss.SuspendLayout();
            this.MainForm_tls.SuspendLayout();
            this.MainForm_tlSC.ContentPanel.SuspendLayout();
            this.MainForm_tlSC.TopToolStripPanel.SuspendLayout();
            this.MainForm_tlSC.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu_ms
            // 
            this.MainMenu_ms.AllowMerge = false;
            this.MainMenu_ms.AutoSize = false;
            this.MainMenu_ms.BackColor = System.Drawing.SystemColors.Menu;
            this.MainMenu_ms.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.MainMenu_ms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu_ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.工具TToolStripMenuItem});
            this.MainMenu_ms.Location = new System.Drawing.Point(0, 0);
            this.MainMenu_ms.Name = "MainMenu_ms";
            this.MainMenu_ms.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MainMenu_ms.Size = new System.Drawing.Size(984, 38);
            this.MainMenu_ms.TabIndex = 0;
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Setting_tsmi});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 工具TToolStripMenuItem
            // 
            this.工具TToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ellipsoid_tsmi,
            this.Coordinate_System_Transfer_tsmi,
            this.GetLatitudeByMeridianArcLength_tsmi,
            this.GetMeridianArcLengthByLatitude_tsmi});
            this.工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            this.工具TToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // Ellipsoid_tsmi
            // 
            this.Ellipsoid_tsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ellipsoid_Properties_tsmi,
            this.Ellipsoid_Transfer_tsmi});
            this.Ellipsoid_tsmi.Name = "Ellipsoid_tsmi";
            this.Ellipsoid_tsmi.Size = new System.Drawing.Size(212, 26);
            this.Ellipsoid_tsmi.Text = "椭球体(&E)";
            // 
            // Ellipsoid_Properties_tsmi
            // 
            this.Ellipsoid_Properties_tsmi.Name = "Ellipsoid_Properties_tsmi";
            this.Ellipsoid_Properties_tsmi.Size = new System.Drawing.Size(180, 22);
            this.Ellipsoid_Properties_tsmi.Text = "查看参数(&S)";
            this.Ellipsoid_Properties_tsmi.Click += new System.EventHandler(this.Ellipsoid_Properties_tsmi_Click);
            // 
            // Ellipsoid_Transfer_tsmi
            // 
            this.Ellipsoid_Transfer_tsmi.Name = "Ellipsoid_Transfer_tsmi";
            this.Ellipsoid_Transfer_tsmi.Size = new System.Drawing.Size(180, 22);
            this.Ellipsoid_Transfer_tsmi.Text = "转换(&T)";
            this.Ellipsoid_Transfer_tsmi.Click += new System.EventHandler(this.Ellipsoid_Transfer_tsmi_Click);
            // 
            // GetLatitudeByMeridianArcLength_tsmi
            // 
            this.GetLatitudeByMeridianArcLength_tsmi.Name = "GetLatitudeByMeridianArcLength_tsmi";
            this.GetLatitudeByMeridianArcLength_tsmi.Size = new System.Drawing.Size(212, 26);
            this.GetLatitudeByMeridianArcLength_tsmi.Text = "由子午线弧长求大地纬度";
            this.GetLatitudeByMeridianArcLength_tsmi.Click += new System.EventHandler(this.GetLatitudeByMeridianArcLength_tsmi_Click);
            // 
            // GetMeridianArcLengthByLatitude_tsmi
            // 
            this.GetMeridianArcLengthByLatitude_tsmi.Name = "GetMeridianArcLengthByLatitude_tsmi";
            this.GetMeridianArcLengthByLatitude_tsmi.Size = new System.Drawing.Size(212, 26);
            this.GetMeridianArcLengthByLatitude_tsmi.Text = "由大地纬度求子午线弧长";
            this.GetMeridianArcLengthByLatitude_tsmi.Click += new System.EventHandler(this.GetMeridianArcLengthByLatitude_tsmi_Click);
            // 
            // MainForm_ss
            // 
            this.MainForm_ss.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.MainForm_ss.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainForm_ss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Current_Ellipsoid_tssl,
            this.Empty_tssl,
            this.Current_Coordinate_System_tssl,
            this.Current_Unit_tssl});
            this.MainForm_ss.Location = new System.Drawing.Point(0, 495);
            this.MainForm_ss.Name = "MainForm_ss";
            this.MainForm_ss.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.MainForm_ss.Size = new System.Drawing.Size(982, 26);
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
            this.Current_Ellipsoid_tssl.Size = new System.Drawing.Size(215, 21);
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
            this.Empty_tssl.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Empty_tssl.Name = "Empty_tssl";
            this.Empty_tssl.Size = new System.Drawing.Size(420, 21);
            // 
            // Current_Coordinate_System_tssl
            // 
            this.Current_Coordinate_System_tssl.AutoSize = false;
            this.Current_Coordinate_System_tssl.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.Current_Coordinate_System_tssl.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.Current_Coordinate_System_tssl.Name = "Current_Coordinate_System_tssl";
            this.Current_Coordinate_System_tssl.Size = new System.Drawing.Size(190, 21);
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
            this.Current_Unit_tssl.Size = new System.Drawing.Size(135, 21);
            this.Current_Unit_tssl.Text = "Current_Unit";
            this.Current_Unit_tssl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm_tls
            // 
            this.MainForm_tls.Dock = System.Windows.Forms.DockStyle.None;
            this.MainForm_tls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CS_Transfer_tsbt,
            this.toolStripSeparator9,
            this.Setting_tsBt});
            this.MainForm_tls.Location = new System.Drawing.Point(3, 0);
            this.MainForm_tls.Name = "MainForm_tls";
            this.MainForm_tls.Padding = new System.Windows.Forms.Padding(1);
            this.MainForm_tls.Size = new System.Drawing.Size(65, 25);
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
            this.Setting_tsBt.Text = "配置";
            this.Setting_tsBt.Click += new System.EventHandler(this.Setting_tsmi_Click);
            // 
            // MainForm_tlSC
            // 
            this.MainForm_tlSC.BottomToolStripPanelVisible = false;
            // 
            // MainForm_tlSC.ContentPanel
            // 
            this.MainForm_tlSC.ContentPanel.AutoScroll = true;
            this.MainForm_tlSC.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainForm_tlSC.ContentPanel.Controls.Add(this.MainForm_ss);
            this.MainForm_tlSC.ContentPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainForm_tlSC.ContentPanel.Size = new System.Drawing.Size(984, 523);
            this.MainForm_tlSC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainForm_tlSC.LeftToolStripPanelVisible = false;
            this.MainForm_tlSC.Location = new System.Drawing.Point(0, 41);
            this.MainForm_tlSC.Name = "MainForm_tlSC";
            this.MainForm_tlSC.RightToolStripPanelVisible = false;
            this.MainForm_tlSC.Size = new System.Drawing.Size(984, 548);
            this.MainForm_tlSC.TabIndex = 5;
            this.MainForm_tlSC.Text = "toolStripContainer1";
            // 
            // MainForm_tlSC.TopToolStripPanel
            // 
            this.MainForm_tlSC.TopToolStripPanel.Controls.Add(this.MainForm_tls);
            this.MainForm_tlSC.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GetLatitudeByMeridianArcLength_tsbt});
            this.toolStrip1.Location = new System.Drawing.Point(68, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(35, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // GetLatitudeByMeridianArcLength_tsbt
            // 
            this.GetLatitudeByMeridianArcLength_tsbt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GetLatitudeByMeridianArcLength_tsbt.Image = ((System.Drawing.Image)(resources.GetObject("GetLatitudeByMeridianArcLength_tsbt.Image")));
            this.GetLatitudeByMeridianArcLength_tsbt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GetLatitudeByMeridianArcLength_tsbt.Name = "GetLatitudeByMeridianArcLength_tsbt";
            this.GetLatitudeByMeridianArcLength_tsbt.Size = new System.Drawing.Size(23, 22);
            this.GetLatitudeByMeridianArcLength_tsbt.Text = "由子午线弧长求大地纬度";
            this.GetLatitudeByMeridianArcLength_tsbt.Click += new System.EventHandler(this.GetLatitudeByMeridianArcLength_tsmi_Click);
            // 
            // Setting_tsmi
            // 
            this.Setting_tsmi.Image = ((System.Drawing.Image)(resources.GetObject("Setting_tsmi.Image")));
            this.Setting_tsmi.Name = "Setting_tsmi";
            this.Setting_tsmi.Size = new System.Drawing.Size(184, 26);
            this.Setting_tsmi.Text = "配置(&S)";
            this.Setting_tsmi.Click += new System.EventHandler(this.Setting_tsmi_Click);
            // 
            // Coordinate_System_Transfer_tsmi
            // 
            this.Coordinate_System_Transfer_tsmi.Image = ((System.Drawing.Image)(resources.GetObject("Coordinate_System_Transfer_tsmi.Image")));
            this.Coordinate_System_Transfer_tsmi.Name = "Coordinate_System_Transfer_tsmi";
            this.Coordinate_System_Transfer_tsmi.Size = new System.Drawing.Size(212, 26);
            this.Coordinate_System_Transfer_tsmi.Text = "坐标系转换(&T)";
            this.Coordinate_System_Transfer_tsmi.Click += new System.EventHandler(this.CS_Transfer_tsmi_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 589);
            this.Controls.Add(this.MainMenu_ms);
            this.Controls.Add(this.MainForm_tlSC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.MainForm_tlSC.ContentPanel.ResumeLayout(false);
            this.MainForm_tlSC.ContentPanel.PerformLayout();
            this.MainForm_tlSC.TopToolStripPanel.ResumeLayout(false);
            this.MainForm_tlSC.TopToolStripPanel.PerformLayout();
            this.MainForm_tlSC.ResumeLayout(false);
            this.MainForm_tlSC.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ToolStripButton CS_Transfer_tsbt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton Setting_tsBt;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Ellipsoid_tsmi;
        private System.Windows.Forms.ToolStripMenuItem Ellipsoid_Properties_tsmi;
        private System.Windows.Forms.ToolStripMenuItem Ellipsoid_Transfer_tsmi;
        private System.Windows.Forms.ToolStripContainer MainForm_tlSC;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton GetLatitudeByMeridianArcLength_tsbt;
        private System.Windows.Forms.ToolStripMenuItem GetLatitudeByMeridianArcLength_tsmi;
        private System.Windows.Forms.ToolStripMenuItem GetMeridianArcLengthByLatitude_tsmi;
        private System.Windows.Forms.ToolStripMenuItem Setting_tsmi;
        private System.Windows.Forms.ToolStripMenuItem Coordinate_System_Transfer_tsmi;
    }
}

