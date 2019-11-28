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
    public partial class Ellipsoid_Properties_Form : Form
    {
        public Ellipsoid_Properties_Form()
        {
            InitializeComponent();

            //初始化坐标系属性窗体
            Ellipsoid_cbBx.SelectedIndex = Setting.Current_Ellipsoid;
        }
        
        /// <summary>
        /// 当椭球体下拉菜单改变时执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ellipsoid_cbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ellipsoid ellipsoid = Setting.ellipsoids[Ellipsoid_cbBx.SelectedIndex];
            a_txtBx.Text = ellipsoid.a.ToString() + "(m)";//长半轴
            b_txtBx.Text = ellipsoid.b.ToString() + "(m)";//短半轴
            c_txtBx.Text = ellipsoid.c.ToString() + "(m)";//半焦距
            compression_txtBx.Text = ellipsoid.compression.ToString();//扁率
            e1_square_txtBx.Text = ellipsoid.e1_square.ToString();//第一偏心率
            e2_square_txtBx.Text = ellipsoid.e2_square.ToString();//第二偏心率
        }

        private void Ellipsoid_Properties_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.form = null;
        }
    }
}
