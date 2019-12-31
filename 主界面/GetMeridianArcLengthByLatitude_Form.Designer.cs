namespace MySystem
{
    partial class GetMeridianArcLengthByLatitude_Form
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
            this.Input_lbl = new System.Windows.Forms.Label();
            this.output_txtBx = new System.Windows.Forms.TextBox();
            this.Calc_btn = new System.Windows.Forms.Button();
            this.B_Min_txtBx = new System.Windows.Forms.TextBox();
            this.X_lbl = new System.Windows.Forms.Label();
            this.Sec_lbl = new System.Windows.Forms.Label();
            this.B_Deg_txtBx = new System.Windows.Forms.TextBox();
            this.B_Sec_txtBx = new System.Windows.Forms.TextBox();
            this.Deg_lbl = new System.Windows.Forms.Label();
            this.Min_lbl = new System.Windows.Forms.Label();
            this.output_gpBx = new System.Windows.Forms.GroupBox();
            this.output_gpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // Input_lbl
            // 
            this.Input_lbl.AutoSize = true;
            this.Input_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Input_lbl.Location = new System.Drawing.Point(37, 67);
            this.Input_lbl.Name = "Input_lbl";
            this.Input_lbl.Size = new System.Drawing.Size(96, 16);
            this.Input_lbl.TabIndex = 44;
            this.Input_lbl.Text = "输入纬度B：";
            // 
            // output_txtBx
            // 
            this.output_txtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.output_txtBx.Location = new System.Drawing.Point(130, 47);
            this.output_txtBx.Name = "output_txtBx";
            this.output_txtBx.ReadOnly = true;
            this.output_txtBx.Size = new System.Drawing.Size(200, 19);
            this.output_txtBx.TabIndex = 43;
            // 
            // Calc_btn
            // 
            this.Calc_btn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Calc_btn.Location = new System.Drawing.Point(170, 120);
            this.Calc_btn.Name = "Calc_btn";
            this.Calc_btn.Size = new System.Drawing.Size(80, 40);
            this.Calc_btn.TabIndex = 42;
            this.Calc_btn.Text = "计算";
            this.Calc_btn.UseVisualStyleBackColor = true;
            this.Calc_btn.Click += new System.EventHandler(this.Calc_btn_Click);
            // 
            // B_Min_txtBx
            // 
            this.B_Min_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.B_Min_txtBx.Location = new System.Drawing.Point(210, 64);
            this.B_Min_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.B_Min_txtBx.Name = "B_Min_txtBx";
            this.B_Min_txtBx.Size = new System.Drawing.Size(40, 26);
            this.B_Min_txtBx.TabIndex = 33;
            this.B_Min_txtBx.TabStop = false;
            this.B_Min_txtBx.Text = "0";
            this.B_Min_txtBx.Enter += new System.EventHandler(this.InputBx_Got_Focus);
            this.B_Min_txtBx.Leave += new System.EventHandler(this.InputBx_Lose_Focus);
            // 
            // X_lbl
            // 
            this.X_lbl.AutoSize = true;
            this.X_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.X_lbl.Location = new System.Drawing.Point(15, 50);
            this.X_lbl.Name = "X_lbl";
            this.X_lbl.Size = new System.Drawing.Size(112, 16);
            this.X_lbl.TabIndex = 4;
            this.X_lbl.Text = "子午线弧长X：";
            // 
            // Sec_lbl
            // 
            this.Sec_lbl.AutoSize = true;
            this.Sec_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Sec_lbl.Location = new System.Drawing.Point(270, 37);
            this.Sec_lbl.Name = "Sec_lbl";
            this.Sec_lbl.Size = new System.Drawing.Size(48, 16);
            this.Sec_lbl.TabIndex = 37;
            this.Sec_lbl.Text = "秒(\")";
            // 
            // B_Deg_txtBx
            // 
            this.B_Deg_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.B_Deg_txtBx.Location = new System.Drawing.Point(150, 64);
            this.B_Deg_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.B_Deg_txtBx.Name = "B_Deg_txtBx";
            this.B_Deg_txtBx.Size = new System.Drawing.Size(40, 26);
            this.B_Deg_txtBx.TabIndex = 32;
            this.B_Deg_txtBx.TabStop = false;
            this.B_Deg_txtBx.Text = "0";
            this.B_Deg_txtBx.Enter += new System.EventHandler(this.InputBx_Got_Focus);
            this.B_Deg_txtBx.Leave += new System.EventHandler(this.InputBx_Lose_Focus);
            // 
            // B_Sec_txtBx
            // 
            this.B_Sec_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.B_Sec_txtBx.Location = new System.Drawing.Point(270, 64);
            this.B_Sec_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.B_Sec_txtBx.Name = "B_Sec_txtBx";
            this.B_Sec_txtBx.Size = new System.Drawing.Size(80, 26);
            this.B_Sec_txtBx.TabIndex = 34;
            this.B_Sec_txtBx.TabStop = false;
            this.B_Sec_txtBx.Text = "0";
            this.B_Sec_txtBx.Enter += new System.EventHandler(this.InputBx_Got_Focus);
            this.B_Sec_txtBx.Leave += new System.EventHandler(this.InputBx_Lose_Focus);
            // 
            // Deg_lbl
            // 
            this.Deg_lbl.AutoSize = true;
            this.Deg_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Deg_lbl.Location = new System.Drawing.Point(150, 37);
            this.Deg_lbl.Name = "Deg_lbl";
            this.Deg_lbl.Size = new System.Drawing.Size(56, 16);
            this.Deg_lbl.TabIndex = 35;
            this.Deg_lbl.Text = "度(°)";
            // 
            // Min_lbl
            // 
            this.Min_lbl.AutoSize = true;
            this.Min_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Min_lbl.Location = new System.Drawing.Point(210, 37);
            this.Min_lbl.Name = "Min_lbl";
            this.Min_lbl.Size = new System.Drawing.Size(48, 16);
            this.Min_lbl.TabIndex = 36;
            this.Min_lbl.Text = "分(\')";
            // 
            // output_gpBx
            // 
            this.output_gpBx.Controls.Add(this.X_lbl);
            this.output_gpBx.Controls.Add(this.output_txtBx);
            this.output_gpBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.output_gpBx.Location = new System.Drawing.Point(40, 180);
            this.output_gpBx.Name = "output_gpBx";
            this.output_gpBx.Size = new System.Drawing.Size(360, 100);
            this.output_gpBx.TabIndex = 45;
            this.output_gpBx.TabStop = false;
            this.output_gpBx.Text = "输出";
            // 
            // GetMeridianArcLengthByLatitude_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 301);
            this.Controls.Add(this.B_Min_txtBx);
            this.Controls.Add(this.Input_lbl);
            this.Controls.Add(this.Sec_lbl);
            this.Controls.Add(this.Calc_btn);
            this.Controls.Add(this.B_Deg_txtBx);
            this.Controls.Add(this.output_gpBx);
            this.Controls.Add(this.B_Sec_txtBx);
            this.Controls.Add(this.Deg_lbl);
            this.Controls.Add(this.Min_lbl);
            this.Name = "GetMeridianArcLengthByLatitude_Form";
            this.Text = "由大地纬度求子午线弧长";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GetMeridianArcLengthByLatitude_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GetMeridianArcLengthByLatitude_Form_MouseDown);
            this.output_gpBx.ResumeLayout(false);
            this.output_gpBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Input_lbl;
        private System.Windows.Forms.TextBox output_txtBx;
        private System.Windows.Forms.Button Calc_btn;
        private System.Windows.Forms.TextBox B_Min_txtBx;
        private System.Windows.Forms.Label X_lbl;
        private System.Windows.Forms.Label Sec_lbl;
        private System.Windows.Forms.TextBox B_Deg_txtBx;
        private System.Windows.Forms.TextBox B_Sec_txtBx;
        private System.Windows.Forms.Label Deg_lbl;
        private System.Windows.Forms.Label Min_lbl;
        private System.Windows.Forms.GroupBox output_gpBx;
    }
}