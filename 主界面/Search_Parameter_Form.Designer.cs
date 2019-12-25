namespace MySystem
{
    partial class Search_Parameter_Form
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
            this.Coordinate_System_lbl = new System.Windows.Forms.Label();
            this.Coordinate_System_txtBx = new System.Windows.Forms.TextBox();
            this.Known_Ellipsoid_txtBx = new System.Windows.Forms.TextBox();
            this.Known_Ellipsoid_lbl = new System.Windows.Forms.Label();
            this.Target_Ellipsoid_txtBx = new System.Windows.Forms.TextBox();
            this.Target_Ellipsoid_lbl = new System.Windows.Forms.Label();
            this.dXo_txtBx = new System.Windows.Forms.TextBox();
            this.dXo_lbl = new System.Windows.Forms.Label();
            this.dYo_txtBx = new System.Windows.Forms.TextBox();
            this.dYo_lbl = new System.Windows.Forms.Label();
            this.dZo_txtBx = new System.Windows.Forms.TextBox();
            this.dZo_lbl = new System.Windows.Forms.Label();
            this.m_txtBx = new System.Windows.Forms.TextBox();
            this.m_lbl = new System.Windows.Forms.Label();
            this.eX_txtBx = new System.Windows.Forms.TextBox();
            this.eX_lbl = new System.Windows.Forms.Label();
            this.eY_txtBx = new System.Windows.Forms.TextBox();
            this.eY_lbl = new System.Windows.Forms.Label();
            this.eZ_txtBx = new System.Windows.Forms.TextBox();
            this.eZ_lbl = new System.Windows.Forms.Label();
            this.da_txtBx = new System.Windows.Forms.TextBox();
            this.da_lbl = new System.Windows.Forms.Label();
            this.daf_txtBx = new System.Windows.Forms.TextBox();
            this.daf_lbl = new System.Windows.Forms.Label();
            this.Common_Points_dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Common_Points_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Coordinate_System_lbl
            // 
            this.Coordinate_System_lbl.AutoSize = true;
            this.Coordinate_System_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Coordinate_System_lbl.Location = new System.Drawing.Point(300, 14);
            this.Coordinate_System_lbl.Name = "Coordinate_System_lbl";
            this.Coordinate_System_lbl.Size = new System.Drawing.Size(72, 16);
            this.Coordinate_System_lbl.TabIndex = 0;
            this.Coordinate_System_lbl.Text = "坐标系：";
            // 
            // Coordinate_System_txtBx
            // 
            this.Coordinate_System_txtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Coordinate_System_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Coordinate_System_txtBx.Location = new System.Drawing.Point(378, 12);
            this.Coordinate_System_txtBx.Name = "Coordinate_System_txtBx";
            this.Coordinate_System_txtBx.ReadOnly = true;
            this.Coordinate_System_txtBx.Size = new System.Drawing.Size(200, 19);
            this.Coordinate_System_txtBx.TabIndex = 2;
            // 
            // Known_Ellipsoid_txtBx
            // 
            this.Known_Ellipsoid_txtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Known_Ellipsoid_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Known_Ellipsoid_txtBx.Location = new System.Drawing.Point(190, 59);
            this.Known_Ellipsoid_txtBx.Name = "Known_Ellipsoid_txtBx";
            this.Known_Ellipsoid_txtBx.ReadOnly = true;
            this.Known_Ellipsoid_txtBx.Size = new System.Drawing.Size(200, 19);
            this.Known_Ellipsoid_txtBx.TabIndex = 4;
            // 
            // Known_Ellipsoid_lbl
            // 
            this.Known_Ellipsoid_lbl.AutoSize = true;
            this.Known_Ellipsoid_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Known_Ellipsoid_lbl.Location = new System.Drawing.Point(80, 59);
            this.Known_Ellipsoid_lbl.Name = "Known_Ellipsoid_lbl";
            this.Known_Ellipsoid_lbl.Size = new System.Drawing.Size(104, 16);
            this.Known_Ellipsoid_lbl.TabIndex = 3;
            this.Known_Ellipsoid_lbl.Text = "已知椭球体：";
            // 
            // Target_Ellipsoid_txtBx
            // 
            this.Target_Ellipsoid_txtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Target_Ellipsoid_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Target_Ellipsoid_txtBx.Location = new System.Drawing.Point(582, 59);
            this.Target_Ellipsoid_txtBx.Name = "Target_Ellipsoid_txtBx";
            this.Target_Ellipsoid_txtBx.ReadOnly = true;
            this.Target_Ellipsoid_txtBx.Size = new System.Drawing.Size(200, 19);
            this.Target_Ellipsoid_txtBx.TabIndex = 6;
            // 
            // Target_Ellipsoid_lbl
            // 
            this.Target_Ellipsoid_lbl.AutoSize = true;
            this.Target_Ellipsoid_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Target_Ellipsoid_lbl.Location = new System.Drawing.Point(460, 59);
            this.Target_Ellipsoid_lbl.Name = "Target_Ellipsoid_lbl";
            this.Target_Ellipsoid_lbl.Size = new System.Drawing.Size(104, 16);
            this.Target_Ellipsoid_lbl.TabIndex = 5;
            this.Target_Ellipsoid_lbl.Text = "目标椭球体：";
            // 
            // dXo_txtBx
            // 
            this.dXo_txtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dXo_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dXo_txtBx.Location = new System.Drawing.Point(97, 110);
            this.dXo_txtBx.Name = "dXo_txtBx";
            this.dXo_txtBx.ReadOnly = true;
            this.dXo_txtBx.Size = new System.Drawing.Size(180, 19);
            this.dXo_txtBx.TabIndex = 8;
            // 
            // dXo_lbl
            // 
            this.dXo_lbl.AutoSize = true;
            this.dXo_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dXo_lbl.Location = new System.Drawing.Point(33, 113);
            this.dXo_lbl.Name = "dXo_lbl";
            this.dXo_lbl.Size = new System.Drawing.Size(56, 16);
            this.dXo_lbl.TabIndex = 7;
            this.dXo_lbl.Text = "△Xo：";
            // 
            // dYo_txtBx
            // 
            this.dYo_txtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dYo_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dYo_txtBx.Location = new System.Drawing.Point(97, 155);
            this.dYo_txtBx.Name = "dYo_txtBx";
            this.dYo_txtBx.ReadOnly = true;
            this.dYo_txtBx.Size = new System.Drawing.Size(180, 19);
            this.dYo_txtBx.TabIndex = 10;
            // 
            // dYo_lbl
            // 
            this.dYo_lbl.AutoSize = true;
            this.dYo_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dYo_lbl.Location = new System.Drawing.Point(33, 158);
            this.dYo_lbl.Name = "dYo_lbl";
            this.dYo_lbl.Size = new System.Drawing.Size(56, 16);
            this.dYo_lbl.TabIndex = 9;
            this.dYo_lbl.Text = "△Yo：";
            // 
            // dZo_txtBx
            // 
            this.dZo_txtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dZo_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dZo_txtBx.Location = new System.Drawing.Point(97, 200);
            this.dZo_txtBx.Name = "dZo_txtBx";
            this.dZo_txtBx.ReadOnly = true;
            this.dZo_txtBx.Size = new System.Drawing.Size(180, 19);
            this.dZo_txtBx.TabIndex = 12;
            // 
            // dZo_lbl
            // 
            this.dZo_lbl.AutoSize = true;
            this.dZo_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dZo_lbl.Location = new System.Drawing.Point(33, 203);
            this.dZo_lbl.Name = "dZo_lbl";
            this.dZo_lbl.Size = new System.Drawing.Size(56, 16);
            this.dZo_lbl.TabIndex = 11;
            this.dZo_lbl.Text = "△Zo：";
            // 
            // m_txtBx
            // 
            this.m_txtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_txtBx.Location = new System.Drawing.Point(385, 111);
            this.m_txtBx.Name = "m_txtBx";
            this.m_txtBx.ReadOnly = true;
            this.m_txtBx.Size = new System.Drawing.Size(180, 19);
            this.m_txtBx.TabIndex = 14;
            // 
            // m_lbl
            // 
            this.m_lbl.AutoSize = true;
            this.m_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_lbl.Location = new System.Drawing.Point(345, 114);
            this.m_lbl.Name = "m_lbl";
            this.m_lbl.Size = new System.Drawing.Size(32, 16);
            this.m_lbl.TabIndex = 13;
            this.m_lbl.Text = "m：";
            // 
            // eX_txtBx
            // 
            this.eX_txtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eX_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.eX_txtBx.Location = new System.Drawing.Point(385, 156);
            this.eX_txtBx.Name = "eX_txtBx";
            this.eX_txtBx.ReadOnly = true;
            this.eX_txtBx.Size = new System.Drawing.Size(180, 19);
            this.eX_txtBx.TabIndex = 16;
            // 
            // eX_lbl
            // 
            this.eX_lbl.AutoSize = true;
            this.eX_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.eX_lbl.Location = new System.Drawing.Point(327, 159);
            this.eX_lbl.Name = "eX_lbl";
            this.eX_lbl.Size = new System.Drawing.Size(48, 16);
            this.eX_lbl.TabIndex = 15;
            this.eX_lbl.Text = "εX：";
            // 
            // eY_txtBx
            // 
            this.eY_txtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eY_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.eY_txtBx.Location = new System.Drawing.Point(385, 201);
            this.eY_txtBx.Name = "eY_txtBx";
            this.eY_txtBx.ReadOnly = true;
            this.eY_txtBx.Size = new System.Drawing.Size(180, 19);
            this.eY_txtBx.TabIndex = 18;
            // 
            // eY_lbl
            // 
            this.eY_lbl.AutoSize = true;
            this.eY_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.eY_lbl.Location = new System.Drawing.Point(327, 204);
            this.eY_lbl.Name = "eY_lbl";
            this.eY_lbl.Size = new System.Drawing.Size(48, 16);
            this.eY_lbl.TabIndex = 17;
            this.eY_lbl.Text = "εY：";
            // 
            // eZ_txtBx
            // 
            this.eZ_txtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eZ_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.eZ_txtBx.Location = new System.Drawing.Point(692, 112);
            this.eZ_txtBx.Name = "eZ_txtBx";
            this.eZ_txtBx.ReadOnly = true;
            this.eZ_txtBx.Size = new System.Drawing.Size(180, 19);
            this.eZ_txtBx.TabIndex = 20;
            // 
            // eZ_lbl
            // 
            this.eZ_lbl.AutoSize = true;
            this.eZ_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.eZ_lbl.Location = new System.Drawing.Point(634, 115);
            this.eZ_lbl.Name = "eZ_lbl";
            this.eZ_lbl.Size = new System.Drawing.Size(48, 16);
            this.eZ_lbl.TabIndex = 19;
            this.eZ_lbl.Text = "εZ：";
            // 
            // da_txtBx
            // 
            this.da_txtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.da_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.da_txtBx.Location = new System.Drawing.Point(692, 157);
            this.da_txtBx.Name = "da_txtBx";
            this.da_txtBx.ReadOnly = true;
            this.da_txtBx.Size = new System.Drawing.Size(180, 19);
            this.da_txtBx.TabIndex = 22;
            // 
            // da_lbl
            // 
            this.da_lbl.AutoSize = true;
            this.da_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.da_lbl.Location = new System.Drawing.Point(634, 160);
            this.da_lbl.Name = "da_lbl";
            this.da_lbl.Size = new System.Drawing.Size(48, 16);
            this.da_lbl.TabIndex = 21;
            this.da_lbl.Text = "△a：";
            // 
            // daf_txtBx
            // 
            this.daf_txtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.daf_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.daf_txtBx.Location = new System.Drawing.Point(692, 202);
            this.daf_txtBx.Name = "daf_txtBx";
            this.daf_txtBx.ReadOnly = true;
            this.daf_txtBx.Size = new System.Drawing.Size(180, 19);
            this.daf_txtBx.TabIndex = 24;
            // 
            // daf_lbl
            // 
            this.daf_lbl.AutoSize = true;
            this.daf_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.daf_lbl.Location = new System.Drawing.Point(628, 205);
            this.daf_lbl.Name = "daf_lbl";
            this.daf_lbl.Size = new System.Drawing.Size(56, 16);
            this.daf_lbl.TabIndex = 23;
            this.daf_lbl.Text = "△α：";
            // 
            // Common_Points_dgv
            // 
            this.Common_Points_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Common_Points_dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Common_Points_dgv.Location = new System.Drawing.Point(0, 298);
            this.Common_Points_dgv.Name = "Common_Points_dgv";
            this.Common_Points_dgv.RowTemplate.Height = 23;
            this.Common_Points_dgv.Size = new System.Drawing.Size(884, 263);
            this.Common_Points_dgv.TabIndex = 25;
            // 
            // Search_Parameter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.Common_Points_dgv);
            this.Controls.Add(this.daf_txtBx);
            this.Controls.Add(this.daf_lbl);
            this.Controls.Add(this.da_txtBx);
            this.Controls.Add(this.da_lbl);
            this.Controls.Add(this.eZ_txtBx);
            this.Controls.Add(this.eZ_lbl);
            this.Controls.Add(this.eY_txtBx);
            this.Controls.Add(this.eY_lbl);
            this.Controls.Add(this.eX_txtBx);
            this.Controls.Add(this.eX_lbl);
            this.Controls.Add(this.m_txtBx);
            this.Controls.Add(this.m_lbl);
            this.Controls.Add(this.dZo_txtBx);
            this.Controls.Add(this.dZo_lbl);
            this.Controls.Add(this.dYo_txtBx);
            this.Controls.Add(this.dYo_lbl);
            this.Controls.Add(this.dXo_txtBx);
            this.Controls.Add(this.dXo_lbl);
            this.Controls.Add(this.Target_Ellipsoid_txtBx);
            this.Controls.Add(this.Target_Ellipsoid_lbl);
            this.Controls.Add(this.Known_Ellipsoid_txtBx);
            this.Controls.Add(this.Known_Ellipsoid_lbl);
            this.Controls.Add(this.Coordinate_System_txtBx);
            this.Controls.Add(this.Coordinate_System_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search_Parameter_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看参数";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Search_Parameter_Form_FormClosing);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Search_Parameter_Form_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.Common_Points_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Coordinate_System_lbl;
        private System.Windows.Forms.TextBox Coordinate_System_txtBx;
        private System.Windows.Forms.TextBox Known_Ellipsoid_txtBx;
        private System.Windows.Forms.Label Known_Ellipsoid_lbl;
        private System.Windows.Forms.TextBox Target_Ellipsoid_txtBx;
        private System.Windows.Forms.Label Target_Ellipsoid_lbl;
        private System.Windows.Forms.TextBox dXo_txtBx;
        private System.Windows.Forms.Label dXo_lbl;
        private System.Windows.Forms.TextBox dYo_txtBx;
        private System.Windows.Forms.Label dYo_lbl;
        private System.Windows.Forms.TextBox dZo_txtBx;
        private System.Windows.Forms.Label dZo_lbl;
        private System.Windows.Forms.TextBox m_txtBx;
        private System.Windows.Forms.Label m_lbl;
        private System.Windows.Forms.TextBox eX_txtBx;
        private System.Windows.Forms.Label eX_lbl;
        private System.Windows.Forms.TextBox eY_txtBx;
        private System.Windows.Forms.Label eY_lbl;
        private System.Windows.Forms.TextBox eZ_txtBx;
        private System.Windows.Forms.Label eZ_lbl;
        private System.Windows.Forms.TextBox da_txtBx;
        private System.Windows.Forms.Label da_lbl;
        private System.Windows.Forms.TextBox daf_txtBx;
        private System.Windows.Forms.Label daf_lbl;
        private System.Windows.Forms.DataGridView Common_Points_dgv;
    }
}