namespace MySystem
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.Setting_tbCtrl = new System.Windows.Forms.TabControl();
            this.Refer_tbPg = new System.Windows.Forms.TabPage();
            this.Coordinate_System_cbBx = new System.Windows.Forms.ComboBox();
            this.Unit_cbBx = new System.Windows.Forms.ComboBox();
            this.Unit_lbl = new System.Windows.Forms.Label();
            this.Coordinate_lbl = new System.Windows.Forms.Label();
            this.Ellipsoid_lbl = new System.Windows.Forms.Label();
            this.Ellipsoid_cbBx = new System.Windows.Forms.ComboBox();
            this.OK_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Apply_btn = new System.Windows.Forms.Button();
            this.Save_Setting_chkBx = new System.Windows.Forms.CheckBox();
            this.Setting_tbCtrl.SuspendLayout();
            this.Refer_tbPg.SuspendLayout();
            this.SuspendLayout();
            // 
            // Setting_tbCtrl
            // 
            this.Setting_tbCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Setting_tbCtrl.Controls.Add(this.Refer_tbPg);
            this.Setting_tbCtrl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Setting_tbCtrl.ItemSize = new System.Drawing.Size(118, 20);
            this.Setting_tbCtrl.Location = new System.Drawing.Point(3, 0);
            this.Setting_tbCtrl.Multiline = true;
            this.Setting_tbCtrl.Name = "Setting_tbCtrl";
            this.Setting_tbCtrl.SelectedIndex = 0;
            this.Setting_tbCtrl.Size = new System.Drawing.Size(480, 520);
            this.Setting_tbCtrl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Setting_tbCtrl.TabIndex = 4;
            // 
            // Refer_tbPg
            // 
            this.Refer_tbPg.Controls.Add(this.Coordinate_System_cbBx);
            this.Refer_tbPg.Controls.Add(this.Unit_cbBx);
            this.Refer_tbPg.Controls.Add(this.Unit_lbl);
            this.Refer_tbPg.Controls.Add(this.Coordinate_lbl);
            this.Refer_tbPg.Controls.Add(this.Ellipsoid_lbl);
            this.Refer_tbPg.Controls.Add(this.Ellipsoid_cbBx);
            this.Refer_tbPg.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Refer_tbPg.Location = new System.Drawing.Point(4, 24);
            this.Refer_tbPg.Name = "Refer_tbPg";
            this.Refer_tbPg.Padding = new System.Windows.Forms.Padding(3);
            this.Refer_tbPg.Size = new System.Drawing.Size(472, 492);
            this.Refer_tbPg.TabIndex = 0;
            this.Refer_tbPg.Text = "参照";
            this.Refer_tbPg.UseVisualStyleBackColor = true;
            // 
            // Coordinate_System_cbBx
            // 
            this.Coordinate_System_cbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Coordinate_System_cbBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Coordinate_System_cbBx.FormattingEnabled = true;
            this.Coordinate_System_cbBx.Items.AddRange(new object[] {
            "大地坐标系",
            "子午面直角坐标系",
            "空间直角坐标系"});
            this.Coordinate_System_cbBx.Location = new System.Drawing.Point(120, 97);
            this.Coordinate_System_cbBx.Name = "Coordinate_System_cbBx";
            this.Coordinate_System_cbBx.Size = new System.Drawing.Size(294, 24);
            this.Coordinate_System_cbBx.TabIndex = 8;
            this.Coordinate_System_cbBx.SelectedIndexChanged += new System.EventHandler(this.Coordinate_cbBx_SelectedIndexChanged);
            // 
            // Unit_cbBx
            // 
            this.Unit_cbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Unit_cbBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Unit_cbBx.FormattingEnabled = true;
            this.Unit_cbBx.Items.AddRange(new object[] {
            "mm(毫米)",
            "cm(厘米)",
            "m(米)",
            "km(千米，公里)",
            "mile(英里)",
            "里"});
            this.Unit_cbBx.Location = new System.Drawing.Point(120, 147);
            this.Unit_cbBx.Name = "Unit_cbBx";
            this.Unit_cbBx.Size = new System.Drawing.Size(100, 24);
            this.Unit_cbBx.TabIndex = 7;
            this.Unit_cbBx.SelectedIndexChanged += new System.EventHandler(this.Unit_cbBx_SelectedIndexChanged);
            // 
            // Unit_lbl
            // 
            this.Unit_lbl.AutoSize = true;
            this.Unit_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Unit_lbl.Location = new System.Drawing.Point(50, 150);
            this.Unit_lbl.Name = "Unit_lbl";
            this.Unit_lbl.Size = new System.Drawing.Size(40, 16);
            this.Unit_lbl.TabIndex = 6;
            this.Unit_lbl.Text = "单位";
            this.Unit_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Coordinate_lbl
            // 
            this.Coordinate_lbl.AutoSize = true;
            this.Coordinate_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Coordinate_lbl.Location = new System.Drawing.Point(50, 100);
            this.Coordinate_lbl.Name = "Coordinate_lbl";
            this.Coordinate_lbl.Size = new System.Drawing.Size(56, 16);
            this.Coordinate_lbl.TabIndex = 5;
            this.Coordinate_lbl.Text = "坐标系";
            this.Coordinate_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ellipsoid_lbl
            // 
            this.Ellipsoid_lbl.AutoSize = true;
            this.Ellipsoid_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ellipsoid_lbl.Location = new System.Drawing.Point(50, 50);
            this.Ellipsoid_lbl.Name = "Ellipsoid_lbl";
            this.Ellipsoid_lbl.Size = new System.Drawing.Size(56, 16);
            this.Ellipsoid_lbl.TabIndex = 4;
            this.Ellipsoid_lbl.Text = "椭球体";
            this.Ellipsoid_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ellipsoid_cbBx
            // 
            this.Ellipsoid_cbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Ellipsoid_cbBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ellipsoid_cbBx.FormattingEnabled = true;
            this.Ellipsoid_cbBx.Items.AddRange(new object[] {
            "克拉索夫斯基椭球体",
            "1975年国际椭球体",
            "WGS-84椭球体",
            "2000中国大地坐标系(CGS2000)"});
            this.Ellipsoid_cbBx.Location = new System.Drawing.Point(120, 47);
            this.Ellipsoid_cbBx.Name = "Ellipsoid_cbBx";
            this.Ellipsoid_cbBx.Size = new System.Drawing.Size(294, 24);
            this.Ellipsoid_cbBx.TabIndex = 3;
            this.Ellipsoid_cbBx.SelectedIndexChanged += new System.EventHandler(this.Ellipsoid_cbBx_SelectedIndexChanged);
            // 
            // OK_btn
            // 
            this.OK_btn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OK_btn.Location = new System.Drawing.Point(200, 525);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(75, 32);
            this.OK_btn.TabIndex = 0;
            this.OK_btn.Text = "确定";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancel_btn.Location = new System.Drawing.Point(300, 525);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 32);
            this.Cancel_btn.TabIndex = 1;
            this.Cancel_btn.Text = "取消";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Apply_btn
            // 
            this.Apply_btn.Enabled = false;
            this.Apply_btn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Apply_btn.Location = new System.Drawing.Point(400, 525);
            this.Apply_btn.Name = "Apply_btn";
            this.Apply_btn.Size = new System.Drawing.Size(75, 32);
            this.Apply_btn.TabIndex = 2;
            this.Apply_btn.Text = "应用(&A)";
            this.Apply_btn.UseVisualStyleBackColor = true;
            this.Apply_btn.Click += new System.EventHandler(this.Apply_btn_Click);
            // 
            // Save_Setting_chkBx
            // 
            this.Save_Setting_chkBx.AutoSize = true;
            this.Save_Setting_chkBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Save_Setting_chkBx.Location = new System.Drawing.Point(10, 534);
            this.Save_Setting_chkBx.Name = "Save_Setting_chkBx";
            this.Save_Setting_chkBx.Size = new System.Drawing.Size(91, 20);
            this.Save_Setting_chkBx.TabIndex = 5;
            this.Save_Setting_chkBx.Text = "保存配置";
            this.Save_Setting_chkBx.UseVisualStyleBackColor = true;
            this.Save_Setting_chkBx.CheckedChanged += new System.EventHandler(this.Save_Setting_chkBx_CheckedChanged);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.Save_Setting_chkBx);
            this.Controls.Add(this.Setting_tbCtrl);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.OK_btn);
            this.Controls.Add(this.Apply_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingForm_FormClosing);
            this.Setting_tbCtrl.ResumeLayout(false);
            this.Refer_tbPg.ResumeLayout(false);
            this.Refer_tbPg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Setting_tbCtrl;
        private System.Windows.Forms.TabPage Refer_tbPg;
        private System.Windows.Forms.Button Apply_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.ComboBox Coordinate_System_cbBx;
        private System.Windows.Forms.ComboBox Unit_cbBx;
        private System.Windows.Forms.Label Unit_lbl;
        private System.Windows.Forms.Label Coordinate_lbl;
        private System.Windows.Forms.Label Ellipsoid_lbl;
        private System.Windows.Forms.ComboBox Ellipsoid_cbBx;
        private System.Windows.Forms.CheckBox Save_Setting_chkBx;
    }
}