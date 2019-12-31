namespace MySystem
{
    partial class Ellipsoid_Properties_Form
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
            this.ellipsoid_lbl = new System.Windows.Forms.Label();
            this.Ellipsoid_cbBx = new System.Windows.Forms.ComboBox();
            this.b_txtBx = new System.Windows.Forms.TextBox();
            this.a_lbl = new System.Windows.Forms.Label();
            this.compression_lbl = new System.Windows.Forms.Label();
            this.b_lbl = new System.Windows.Forms.Label();
            this.e1_square_lbl = new System.Windows.Forms.Label();
            this.c_lbl = new System.Windows.Forms.Label();
            this.c_txtBx = new System.Windows.Forms.TextBox();
            this.compression_txtBx = new System.Windows.Forms.TextBox();
            this.e1_square_txtBx = new System.Windows.Forms.TextBox();
            this.a_txtBx = new System.Windows.Forms.TextBox();
            this.e2_square_lbl = new System.Windows.Forms.Label();
            this.e2_square_txtBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ellipsoid_lbl
            // 
            this.ellipsoid_lbl.AutoSize = true;
            this.ellipsoid_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ellipsoid_lbl.Location = new System.Drawing.Point(58, 40);
            this.ellipsoid_lbl.Name = "ellipsoid_lbl";
            this.ellipsoid_lbl.Size = new System.Drawing.Size(72, 16);
            this.ellipsoid_lbl.TabIndex = 0;
            this.ellipsoid_lbl.Text = "椭球体：";
            // 
            // Ellipsoid_cbBx
            // 
            this.Ellipsoid_cbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Ellipsoid_cbBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ellipsoid_cbBx.FormattingEnabled = true;
            this.Ellipsoid_cbBx.Items.AddRange(new object[] {
            "克拉索夫斯基椭球体",
            "1975国际椭球体",
            "WGS-84椭球体",
            "2000中国大地坐标系(CGCS2000)"});
            this.Ellipsoid_cbBx.Location = new System.Drawing.Point(148, 37);
            this.Ellipsoid_cbBx.Name = "Ellipsoid_cbBx";
            this.Ellipsoid_cbBx.Size = new System.Drawing.Size(206, 24);
            this.Ellipsoid_cbBx.TabIndex = 1;
            this.Ellipsoid_cbBx.SelectedIndexChanged += new System.EventHandler(this.Ellipsoid_cbBx_SelectedIndexChanged);
            // 
            // b_txtBx
            // 
            this.b_txtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.b_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b_txtBx.Location = new System.Drawing.Point(160, 162);
            this.b_txtBx.Name = "b_txtBx";
            this.b_txtBx.ReadOnly = true;
            this.b_txtBx.Size = new System.Drawing.Size(194, 19);
            this.b_txtBx.TabIndex = 2;
            // 
            // a_lbl
            // 
            this.a_lbl.AutoSize = true;
            this.a_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.a_lbl.Location = new System.Drawing.Point(61, 111);
            this.a_lbl.Name = "a_lbl";
            this.a_lbl.Size = new System.Drawing.Size(96, 16);
            this.a_lbl.TabIndex = 3;
            this.a_lbl.Text = "长半轴(a)：";
            // 
            // compression_lbl
            // 
            this.compression_lbl.AutoSize = true;
            this.compression_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.compression_lbl.Location = new System.Drawing.Point(69, 261);
            this.compression_lbl.Name = "compression_lbl";
            this.compression_lbl.Size = new System.Drawing.Size(88, 16);
            this.compression_lbl.TabIndex = 5;
            this.compression_lbl.Text = "扁率(α)：";
            // 
            // b_lbl
            // 
            this.b_lbl.AutoSize = true;
            this.b_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b_lbl.Location = new System.Drawing.Point(61, 161);
            this.b_lbl.Name = "b_lbl";
            this.b_lbl.Size = new System.Drawing.Size(96, 16);
            this.b_lbl.TabIndex = 4;
            this.b_lbl.Text = "短半轴(b)：";
            // 
            // e1_square_lbl
            // 
            this.e1_square_lbl.AutoSize = true;
            this.e1_square_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.e1_square_lbl.Location = new System.Drawing.Point(21, 311);
            this.e1_square_lbl.Name = "e1_square_lbl";
            this.e1_square_lbl.Size = new System.Drawing.Size(136, 16);
            this.e1_square_lbl.TabIndex = 7;
            this.e1_square_lbl.Text = "第一偏心率(e²)：";
            // 
            // c_lbl
            // 
            this.c_lbl.AutoSize = true;
            this.c_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.c_lbl.Location = new System.Drawing.Point(29, 212);
            this.c_lbl.Name = "c_lbl";
            this.c_lbl.Size = new System.Drawing.Size(128, 16);
            this.c_lbl.TabIndex = 6;
            this.c_lbl.Text = "极点曲率半径c：";
            // 
            // c_txtBx
            // 
            this.c_txtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.c_txtBx.Location = new System.Drawing.Point(160, 212);
            this.c_txtBx.Name = "c_txtBx";
            this.c_txtBx.ReadOnly = true;
            this.c_txtBx.Size = new System.Drawing.Size(194, 19);
            this.c_txtBx.TabIndex = 8;
            // 
            // compression_txtBx
            // 
            this.compression_txtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.compression_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.compression_txtBx.Location = new System.Drawing.Point(160, 262);
            this.compression_txtBx.Name = "compression_txtBx";
            this.compression_txtBx.ReadOnly = true;
            this.compression_txtBx.Size = new System.Drawing.Size(194, 19);
            this.compression_txtBx.TabIndex = 9;
            // 
            // e1_square_txtBx
            // 
            this.e1_square_txtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e1_square_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.e1_square_txtBx.Location = new System.Drawing.Point(160, 312);
            this.e1_square_txtBx.Name = "e1_square_txtBx";
            this.e1_square_txtBx.ReadOnly = true;
            this.e1_square_txtBx.Size = new System.Drawing.Size(194, 19);
            this.e1_square_txtBx.TabIndex = 10;
            // 
            // a_txtBx
            // 
            this.a_txtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.a_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.a_txtBx.Location = new System.Drawing.Point(160, 112);
            this.a_txtBx.Name = "a_txtBx";
            this.a_txtBx.ReadOnly = true;
            this.a_txtBx.Size = new System.Drawing.Size(194, 19);
            this.a_txtBx.TabIndex = 11;
            // 
            // e2_square_lbl
            // 
            this.e2_square_lbl.AutoSize = true;
            this.e2_square_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.e2_square_lbl.Location = new System.Drawing.Point(13, 361);
            this.e2_square_lbl.Name = "e2_square_lbl";
            this.e2_square_lbl.Size = new System.Drawing.Size(144, 16);
            this.e2_square_lbl.TabIndex = 12;
            this.e2_square_lbl.Text = "第二偏心率(e\'²)：";
            // 
            // e2_square_txtBx
            // 
            this.e2_square_txtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.e2_square_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.e2_square_txtBx.Location = new System.Drawing.Point(160, 362);
            this.e2_square_txtBx.Name = "e2_square_txtBx";
            this.e2_square_txtBx.ReadOnly = true;
            this.e2_square_txtBx.Size = new System.Drawing.Size(194, 19);
            this.e2_square_txtBx.TabIndex = 13;
            // 
            // Ellipsoid_Properties_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.e2_square_txtBx);
            this.Controls.Add(this.e2_square_lbl);
            this.Controls.Add(this.a_txtBx);
            this.Controls.Add(this.e1_square_txtBx);
            this.Controls.Add(this.compression_txtBx);
            this.Controls.Add(this.c_txtBx);
            this.Controls.Add(this.e1_square_lbl);
            this.Controls.Add(this.c_lbl);
            this.Controls.Add(this.compression_lbl);
            this.Controls.Add(this.b_lbl);
            this.Controls.Add(this.a_lbl);
            this.Controls.Add(this.b_txtBx);
            this.Controls.Add(this.Ellipsoid_cbBx);
            this.Controls.Add(this.ellipsoid_lbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ellipsoid_Properties_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "椭球体属性";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ellipsoid_Properties_Form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ellipsoid_lbl;
        private System.Windows.Forms.ComboBox Ellipsoid_cbBx;
        private System.Windows.Forms.TextBox b_txtBx;
        private System.Windows.Forms.Label a_lbl;
        private System.Windows.Forms.Label compression_lbl;
        private System.Windows.Forms.Label b_lbl;
        private System.Windows.Forms.Label e1_square_lbl;
        private System.Windows.Forms.Label c_lbl;
        private System.Windows.Forms.TextBox c_txtBx;
        private System.Windows.Forms.TextBox compression_txtBx;
        private System.Windows.Forms.TextBox e1_square_txtBx;
        private System.Windows.Forms.TextBox a_txtBx;
        private System.Windows.Forms.Label e2_square_lbl;
        private System.Windows.Forms.TextBox e2_square_txtBx;
    }
}