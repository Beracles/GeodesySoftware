using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySystem
{
    public partial class GetMeridianArcLengthByLatitude_Form : Form
    {
        /// <summary>
        /// 子午圈曲率半径公式（4-70）参数列表
        /// </summary>
        double[] m = new double[9];
        /// <summary>
        /// 子午线弧长计算公式参数列表
        /// </summary>
        double a0, a2, a4, a6, a8;

        private void Calc_btn_Click(object sender, EventArgs e)
        {
            double B_deg;//角度制纬度
            try
            {
                B_deg = Convert.ToDouble(B_Deg_txtBx.Text)+Convert.ToDouble(B_Min_txtBx.Text)/60+Convert.ToDouble(B_Sec_txtBx.Text)/3600;
            }
            catch(Exception ex)
            {
                MessageBox.Show("输入错误！\n错误信息：" + ex.Message);
                return;
            }
            double B = B_deg * Math.PI / 180;//弧度制纬度

            double X;//子午线弧长
            //计算
            X = a0 * B - a2 * Math.Sin(2 * B) / 2 + a4 * Math.Sin(4 * B) / 4 - a6 * Math.Sin(6 * B) / 6 + a8 * Math.Sin(8 * B) / 8;

            output_txtBx.Text = X.ToString("f4");

        }

        /// <summary>
        /// 当前椭球体的长半轴长
        /// </summary>
        double a;
        /// <summary>
        /// 当前椭球体的第一偏心率的平方
        /// </summary>
        double e_2;

        private void GetMeridianArcLengthByLatitude_Form_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        public GetMeridianArcLengthByLatitude_Form()
        {
            InitializeComponent();

            this.output_gpBx.MouseDown += new MouseEventHandler(GetMeridianArcLengthByLatitude_Form_MouseDown);

            a = Setting.ellipsoids[Setting.Current_Ellipsoid].a;
            e_2 = Setting.ellipsoids[Setting.Current_Ellipsoid].e1_2;

            //求解参数
            m[0] = a * (1 - e_2);
            for (int i = 2; i < 9; i += 2)
            {
                m[i] = (i + 1) * e_2 * m[i - 2] / i;
            }
            a0 = m[0] + m[2] / 2 + m[4] * 3 / 8 + m[6] * 5 / 16 + m[8] * 35 / 128;
            a2 = m[2] / 2 + m[4] / 2 + m[6] * 15 / 32 + m[8] * 7 / 16;
            a4 = m[4] / 8 + m[6] * 3 / 16 + m[8] * 7 / 32;
            a6 = m[6] / 32 + m[8] / 16;
            a8 = m[8] / 128;
        }

        private void GetMeridianArcLengthByLatitude_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.form = null;
        }

        /// <summary>
        /// 当输入框获得输入焦点时，将其置空（原来为"0"）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputBx_Got_Focus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "0")
                ((TextBox)sender).Text = "";
        }

        /// <summary>
        /// 当输入框失去输入焦点时，判断是否为空，是则置0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputBx_Lose_Focus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
                tb.Text = "0";
            if (tb.Text == "-" || tb.Text == "+")
                tb.Text += "0";
        }
    }
}
