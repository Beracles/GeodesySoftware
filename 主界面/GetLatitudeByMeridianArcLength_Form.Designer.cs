namespace MySystem
{
    partial class GetLatitudeByMeridianArcLength_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetLatitudeByMeridianArcLength_Form));
            this.Calc_btn = new System.Windows.Forms.Button();
            this.input_txtBx = new System.Windows.Forms.TextBox();
            this.Input_lbl = new System.Windows.Forms.Label();
            this.B_lbl = new System.Windows.Forms.Label();
            this.B_Min_txtBx = new System.Windows.Forms.TextBox();
            this.B_Sec_txtBx = new System.Windows.Forms.TextBox();
            this.Min_lbl = new System.Windows.Forms.Label();
            this.Deg_lbl = new System.Windows.Forms.Label();
            this.B_Deg_txtBx = new System.Windows.Forms.TextBox();
            this.Sec_lbl = new System.Windows.Forms.Label();
            this.output_gpBx = new System.Windows.Forms.GroupBox();
            this.output_gpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calc_btn
            // 
            this.Calc_btn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Calc_btn.Location = new System.Drawing.Point(170, 120);
            this.Calc_btn.Name = "Calc_btn";
            this.Calc_btn.Size = new System.Drawing.Size(80, 40);
            this.Calc_btn.TabIndex = 0;
            this.Calc_btn.Text = "计算";
            this.Calc_btn.UseVisualStyleBackColor = true;
            this.Calc_btn.Click += new System.EventHandler(this.Calc_btn_Click);
            // 
            // input_txtBx
            // 
            this.input_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_txtBx.Location = new System.Drawing.Point(180, 37);
            this.input_txtBx.Name = "input_txtBx";
            this.input_txtBx.Size = new System.Drawing.Size(200, 26);
            this.input_txtBx.TabIndex = 1;
            // 
            // Input_lbl
            // 
            this.Input_lbl.AutoSize = true;
            this.Input_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Input_lbl.Location = new System.Drawing.Point(30, 40);
            this.Input_lbl.Name = "Input_lbl";
            this.Input_lbl.Size = new System.Drawing.Size(144, 16);
            this.Input_lbl.TabIndex = 2;
            this.Input_lbl.Text = "输入子午线弧长X：";
            // 
            // B_lbl
            // 
            this.B_lbl.AutoSize = true;
            this.B_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.B_lbl.Location = new System.Drawing.Point(13, 57);
            this.B_lbl.Name = "B_lbl";
            this.B_lbl.Size = new System.Drawing.Size(32, 16);
            this.B_lbl.TabIndex = 4;
            this.B_lbl.Text = "B：";
            // 
            // B_Min_txtBx
            // 
            this.B_Min_txtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.B_Min_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.B_Min_txtBx.Location = new System.Drawing.Point(133, 54);
            this.B_Min_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.B_Min_txtBx.Name = "B_Min_txtBx";
            this.B_Min_txtBx.ReadOnly = true;
            this.B_Min_txtBx.Size = new System.Drawing.Size(40, 19);
            this.B_Min_txtBx.TabIndex = 33;
            this.B_Min_txtBx.TabStop = false;
            // 
            // B_Sec_txtBx
            // 
            this.B_Sec_txtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.B_Sec_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.B_Sec_txtBx.Location = new System.Drawing.Point(193, 54);
            this.B_Sec_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.B_Sec_txtBx.Name = "B_Sec_txtBx";
            this.B_Sec_txtBx.ReadOnly = true;
            this.B_Sec_txtBx.Size = new System.Drawing.Size(80, 19);
            this.B_Sec_txtBx.TabIndex = 34;
            this.B_Sec_txtBx.TabStop = false;
            // 
            // Min_lbl
            // 
            this.Min_lbl.AutoSize = true;
            this.Min_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Min_lbl.Location = new System.Drawing.Point(133, 27);
            this.Min_lbl.Name = "Min_lbl";
            this.Min_lbl.Size = new System.Drawing.Size(48, 16);
            this.Min_lbl.TabIndex = 36;
            this.Min_lbl.Text = "分(\')";
            // 
            // Deg_lbl
            // 
            this.Deg_lbl.AutoSize = true;
            this.Deg_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Deg_lbl.Location = new System.Drawing.Point(73, 27);
            this.Deg_lbl.Name = "Deg_lbl";
            this.Deg_lbl.Size = new System.Drawing.Size(56, 16);
            this.Deg_lbl.TabIndex = 35;
            this.Deg_lbl.Text = "度(°)";
            // 
            // B_Deg_txtBx
            // 
            this.B_Deg_txtBx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.B_Deg_txtBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.B_Deg_txtBx.Location = new System.Drawing.Point(73, 54);
            this.B_Deg_txtBx.Margin = new System.Windows.Forms.Padding(2);
            this.B_Deg_txtBx.Name = "B_Deg_txtBx";
            this.B_Deg_txtBx.ReadOnly = true;
            this.B_Deg_txtBx.Size = new System.Drawing.Size(40, 19);
            this.B_Deg_txtBx.TabIndex = 32;
            this.B_Deg_txtBx.TabStop = false;
            // 
            // Sec_lbl
            // 
            this.Sec_lbl.AutoSize = true;
            this.Sec_lbl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Sec_lbl.Location = new System.Drawing.Point(193, 27);
            this.Sec_lbl.Name = "Sec_lbl";
            this.Sec_lbl.Size = new System.Drawing.Size(48, 16);
            this.Sec_lbl.TabIndex = 37;
            this.Sec_lbl.Text = "秒(\")";
            // 
            // output_gpBx
            // 
            this.output_gpBx.Controls.Add(this.B_Min_txtBx);
            this.output_gpBx.Controls.Add(this.B_lbl);
            this.output_gpBx.Controls.Add(this.Sec_lbl);
            this.output_gpBx.Controls.Add(this.B_Deg_txtBx);
            this.output_gpBx.Controls.Add(this.B_Sec_txtBx);
            this.output_gpBx.Controls.Add(this.Deg_lbl);
            this.output_gpBx.Controls.Add(this.Min_lbl);
            this.output_gpBx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.output_gpBx.Location = new System.Drawing.Point(70, 180);
            this.output_gpBx.Name = "output_gpBx";
            this.output_gpBx.Size = new System.Drawing.Size(300, 100);
            this.output_gpBx.TabIndex = 41;
            this.output_gpBx.TabStop = false;
            this.output_gpBx.Text = "输出";
            // 
            // GetLatitudeByMeridianArcLength_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 301);
            this.Controls.Add(this.output_gpBx);
            this.Controls.Add(this.Input_lbl);
            this.Controls.Add(this.input_txtBx);
            this.Controls.Add(this.Calc_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetLatitudeByMeridianArcLength_Form";
            this.Text = "由子午线弧长求大地纬度";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GetLatitudeByMeridianArcLength_Form_FormClosing);
            this.output_gpBx.ResumeLayout(false);
            this.output_gpBx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calc_btn;
        private System.Windows.Forms.TextBox input_txtBx;
        private System.Windows.Forms.Label Input_lbl;
        private System.Windows.Forms.Label B_lbl;
        private System.Windows.Forms.TextBox B_Min_txtBx;
        private System.Windows.Forms.TextBox B_Sec_txtBx;
        private System.Windows.Forms.Label Min_lbl;
        private System.Windows.Forms.Label Deg_lbl;
        private System.Windows.Forms.TextBox B_Deg_txtBx;
        private System.Windows.Forms.Label Sec_lbl;
        private System.Windows.Forms.GroupBox output_gpBx;
    }
}