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
    public partial class GetLatitudeByMeridianArcLength_Form : Form
    {
        /// <summary>
        /// 子午圈曲率半径公式（4-70）参数列表
        /// </summary>
        double[] m = new double[9];
        /// <summary>
        /// 子午线弧长计算公式参数列表
        /// </summary>
        double a0,a2,a4,a6,a8;
        /// <summary>
        /// 当前椭球体的长半轴长
        /// </summary>
        double a;
        /// <summary>
        /// 当前椭球体的第一偏心率的平方
        /// </summary>
        double e_2;
        
        public GetLatitudeByMeridianArcLength_Form()
        {
            InitializeComponent();
            a = Setting.ellipsoids[Setting.Current_Ellipsoid].a;
            e_2= Setting.ellipsoids[Setting.Current_Ellipsoid].e1_2;

            //求解参数
            m[0] = a * (1 - e_2);
            for(int i = 2; i < 9; i += 2)
            {
                m[i] = (i + 1) * e_2 * m[i - 2] / i;
            }
            a0 = m[0] + m[2] / 2 + m[4] * 3 / 8 + m[6] * 5 / 16 + m[8] * 35 / 128;
            a2 = m[2] / 2 + m[4] / 2 + m[6] * 15 / 32 + m[8] * 7 / 16;
            a4 = m[4] / 8 + m[6] * 3 / 16 + m[8] * 7 / 32;
            a6 = m[6] / 32 + m[8] / 16;
            a8 = m[8] / 128;
        }

        private void Calc_btn_Click(object sender, EventArgs e)
        {
            if (input_txtBx.Text == "")
            {
                return;
            }
            double X;//子午线弧长
            try
            {
                X = double.Parse(input_txtBx.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("输入错误!\n错误信息：" + ex.Message);
                return;
            }

            //迭代求大地纬度
            double B1 = X / a0;//
            double B2;
            double FB1;
            while (true)
            {
                FB1 = -a2 * Math.Sin(2 * B1) / 2 + a4 * Math.Sin(4 * B1) / 4 - a6 * Math.Sin(6 * B1) / 6;
                B2 = (X - FB1) / a0;
                if (B2 - B1 < 0.0000001 && B2 - B1 > -0.0000001)
                {
                    break;
                }
                B1 = B2;
            }

            double B = B1 * 180 / Math.PI;//弧度转角度

            //输出
            double deg, min, sec;
            //其他全部取绝对值
            deg = Math.Truncate(B);//度(°)
            min = Math.Truncate((B - deg) * 60);//分(')
            sec = Coordinate_System_Transfer.Abs1((B - deg - min / 60) * 3600);//秒(")
            min = Coordinate_System_Transfer.Abs1(min);
            deg = Coordinate_System_Transfer.Abs1(deg);
            if (double.Parse(sec.ToString("f2")) == 60)
            {
                sec = 0;
                min++;
            }
            if (double.Parse(min.ToString("f2")) == 60)
            {
                min = 0;
                deg++;
            }
            
            B_Deg_txtBx.Text = (B < 0 ? "-" : "") + deg.ToString();
            B_Min_txtBx.Text = min.ToString();
            B_Sec_txtBx.Text = sec.ToString("f2");

        }

        private void GetLatitudeByMeridianArcLength_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.form = null;
        }
    }
}
