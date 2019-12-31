//配置窗体

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace MySystem
{
    public partial class SettingForm : Form
    {
        /// <summary>
        /// 用于接收父窗体
        /// </summary>
        private MainForm mainform;

        /// <summary>
        /// 参数mainform用于接收父窗体
        /// </summary>
        /// <param name="mainform"></param>
        public SettingForm(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;

            //初始化设置界面
            Ellipsoid_cbBx.SelectedIndex = Setting.Current_Ellipsoid;
            Coordinate_System_cbBx.SelectedIndex = Setting.Current_Coordinate_System;
            Unit_cbBx.SelectedIndex = Setting.Current_Unit;
        }
        
        /// <summary>
        /// 下拉菜单改变的次数
        /// </summary>
        public static int times = 0;

        /// <summary>
        /// 椭球体下拉菜单改变时执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ellipsoid_cbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (times == 3)
                Apply_btn.Enabled = true;
            else
                times++;
        }

        /// <summary>
        /// 坐标系下拉菜单改变时执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Coordinate_cbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (times == 3)
                Apply_btn.Enabled = true;
            else
                times++;
        }

        /// <summary>
        /// 单位下拉菜单改变时执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Unit_cbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (times == 3)
                Apply_btn.Enabled = true;
            else
                times++;
        }

        /// <summary>
        /// 单击取消按钮后执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 单击确认按钮后执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OK_btn_Click(object sender, EventArgs e)
        {
            //若“应用”按钮为灰色，直接退出
            if (Apply_btn.Enabled == false)
            {
                this.Close();
                return;
            }

            Setting.Current_Ellipsoid = Ellipsoid_cbBx.SelectedIndex;
            Setting.Current_Coordinate_System = Coordinate_System_cbBx.SelectedIndex;
            Setting.Current_Unit = Unit_cbBx.SelectedIndex;
            Setting.Save_Setting_Or_Not = Save_Setting_chkBx.Checked;
            if (mainform != null)
            {
                ToolStripContainer MainForm_tlSC = (ToolStripContainer)this.mainform.Controls.Find("MainForm_tlSC", false)[0];
                ToolStrip toolstrip = (ToolStrip)MainForm_tlSC.ContentPanel.Controls.Find("MainForm_ss", false)[0];
                ToolStripStatusLabel Current_Ellipsoid_tssl = (ToolStripStatusLabel)toolstrip.Items.Find("Current_Ellipsoid_tssl", false)[0];
                ToolStripStatusLabel Current_Coordinate_System_tssl = (ToolStripStatusLabel)toolstrip.Items.Find("Current_Coordinate_System_tssl", false)[0];
                ToolStripStatusLabel Current_Unit_tssl = (ToolStripStatusLabel)toolstrip.Items.Find("Current_Unit_tssl", false)[0];
                Current_Ellipsoid_tssl.Text = "椭球体：" + Setting.Ellipsoids[Setting.Current_Ellipsoid];
                Current_Coordinate_System_tssl.Text = "坐标系：" + Setting.Coordinate_Systems[Setting.Current_Coordinate_System];
                Current_Unit_tssl.Text = "单位：" + Setting.Units[Setting.Current_Unit];
            }
            this.Close();
        }

        /// <summary>
        /// 单击应用按钮时执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Apply_btn_Click(object sender, EventArgs e)
        {
            Setting.Current_Ellipsoid = Ellipsoid_cbBx.SelectedIndex;
            Setting.Current_Coordinate_System = Coordinate_System_cbBx.SelectedIndex;
            Setting.Current_Unit = Unit_cbBx.SelectedIndex;
            Setting.Save_Setting_Or_Not = Save_Setting_chkBx.Checked;
            if (mainform != null)
            {
                ToolStripContainer MainForm_tlSC = (ToolStripContainer)this.mainform.Controls.Find("MainForm_tlSC", false)[0];
                ToolStrip toolstrip = (ToolStrip)MainForm_tlSC.ContentPanel.Controls.Find("MainForm_ss", false)[0];
                ToolStripStatusLabel Current_Ellipsoid_tssl = (ToolStripStatusLabel)toolstrip.Items.Find("Current_Ellipsoid_tssl", false)[0];
                ToolStripStatusLabel Current_Coordinate_System_tssl = (ToolStripStatusLabel)toolstrip.Items.Find("Current_Coordinate_System_tssl", false)[0];
                ToolStripStatusLabel Current_Unit_tssl = (ToolStripStatusLabel)toolstrip.Items.Find("Current_Unit_tssl", false)[0];
                Current_Ellipsoid_tssl.Text = "椭球体：" + Setting.Ellipsoids[Setting.Current_Ellipsoid];
                Current_Coordinate_System_tssl.Text = "坐标系：" + Setting.Coordinate_Systems[Setting.Current_Coordinate_System];
                Current_Unit_tssl.Text = "单位：" + Setting.Units[Setting.Current_Unit];
            }
            Apply_btn.Enabled = false;
        }

        /// <summary>
        /// 改变“下次启动仍使用当前配置”选框选中状态时执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Setting_chkBx_CheckedChanged(object sender, EventArgs e)
        {
            Apply_btn.Enabled = true;
        }

        private void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.form = null;
        }
    }

    public class Setting
    {
        #region 坐标系相关属性设置
        private static int current_Coordinate_System = GCS;  //用于表示当前使用坐标系的名称
        /// <summary>
        /// 当前坐标系，默认为大地坐标系
        /// </summary>
        public static int Current_Coordinate_System        //封装字段current_Coordinate
        {
            get
            {
                return current_Coordinate_System;
            }
            set
            {
                current_Coordinate_System = value;
            }
        }

        //定义坐标系名称列表
        /// <summary>
        /// 坐标系名称列表，0-大地坐标系，1-子午面直角坐标系，2-空间直角坐标系
        /// </summary>
        public static string[] Coordinate_Systems = { "大地坐标系", "子午面直角坐标系", "空间直角坐标系" };

        //定义坐标系代号
        /// <summary>
        /// value=0,大地坐标系(Geodetic Coordinate System)
        /// </summary>
        public const int GCS = 0;

        ///<summary>
        /// value=1,子午面直角坐标系(Meridian Right Angle Coordinate System)
        /// </summary>
        public const int MRACS = 1;

        ///<summary>
        /// value=2,空间直角坐标系(Space Rectangular Coordinate System)
        /// </summary>
        public const int SRCS = 2;

        #endregion

        #region 椭球体相关属性

        //定义椭球体名称列表
        /// <summary>
        /// 椭球体名称列表，0-克拉索夫斯基椭球体，1-国际椭球体，2-WGS84椭球体，3-CGCS2000椭球体
        /// </summary>
        public static string[] Ellipsoids = { "克拉索夫斯基椭球体", "1975国际椭球体", "WGS-84椭球体", "2000中国大地坐标系(CGCS)" };

        ///<summary>
        ///克拉索夫斯基椭球体
        ///</summary>
        public static Ellipsoid Krassowski_eliipsoid = new Ellipsoid(6378245.0000000000, 6356863.0187730473, 6399698.9017827110, 1 / 298.3, 0.006693421622966, 0.006738525414683);

        /// <summary>
        /// 1975年国际椭球体
        /// </summary>
        public static Ellipsoid International_ellipsoid = new Ellipsoid(6378140.0000000000, 6356755.2881575287, 6399596.6519880105, 1 / 298.257, 0.006694384999588, 0.006739501819473);

        /// <summary>
        /// WGS-84椭球体
        /// </summary>
        public static Ellipsoid WGS_84_ellipsoid = new Ellipsoid(6378137.0000000000, 6356752.3142, 6399593.6258, 1 / 298.257223563, 0.00669437999013, 0.00673949674227);

        /// <summary>
        /// 2000中国大地坐标系(CGCS2000)
        /// </summary>
        public static Ellipsoid CGCS2000_ellipsoid = new Ellipsoid(6378137.0, 6356752.3141, 6399593.6259, 1 / 298.257222101, 0.00669438002290, 0.00673949677548);

        ///<summary>
        ///椭球体数组;
        ///0-克拉索夫斯基椭球体;
        ///1-国际椭球体;
        ///2-WGS84椭球体;
        ///3-CGCS2000椭球体;
        ///</summary>
        public static Ellipsoid[] ellipsoids = { Krassowski_eliipsoid, International_ellipsoid, WGS_84_ellipsoid, CGCS2000_ellipsoid };

        //定义当前椭球体代号变量
        private static int current_Ellipsoid = 2;
        /// <summary>
        /// 当前椭球体代号，默认为2，即WGS-84椭球体
        /// </summary>
        public static int Current_Ellipsoid { get => current_Ellipsoid; set => current_Ellipsoid = value; }

        #endregion

        #region 单位相关属性

        /// <summary>
        /// 单位属性字段，各索引分别代表：0-mm，1-cm，2-m，3-km，4-mile，5-里
        /// </summary>
        public static string[] Units = { "mm(毫米)", "cm(厘米)", "m(米)", "km(千米,公里)", "mile(英里)", "里" };

        private static int current_Unit = 2;//默认为米
        /// <summary>
        /// 当前使用单位代号，默认为第二个，米
        /// </summary>
        public static int Current_Unit { get => current_Unit; set => current_Unit = value; }//封装

        #endregion

        //是否保存配置
        private static bool save_Setting_Or_Not = false;
        /// <summary>
        /// 是否保存配置，默认为否false
        /// </summary>
        public static bool Save_Setting_Or_Not { get => save_Setting_Or_Not; set => save_Setting_Or_Not = value; }


        //定义函数Get_Current_Setting()
        /// <summary>
        /// 系统初始化时，从配置文件中读取系统的椭球体，坐标系等配置，
        /// </summary>
        public static double Get_Current_Setting()
        {
            //局部变量，保存文件"配置文件.txt"的路径
            string path = Directory.GetCurrentDirectory() + @"\配置文件.txt";

            //判断文件是否存在
            if (!File.Exists(path))
            {
                MessageBox.Show("文件不存在：" + path, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Errors.File_Not_Exist;      //出现错误，返回错误代码File_Not_Exist
            }

            FileStream fs = File.OpenRead(path);    //以只读方式打开文件
            StreamReader sr = new StreamReader(fs); //定义读取器

            //读取文件
            sr.ReadLine();//跳过一行
            Current_Coordinate_System = Convert.ToInt16(sr.ReadLine()); //第二行为坐标系
            sr.ReadLine();//跳过一行
            Current_Ellipsoid = Convert.ToInt16(sr.ReadLine());         //第四行为椭球体
            sr.ReadLine();//跳过一行
            Current_Unit = Convert.ToInt16(sr.ReadLine());              //第六行为单位
            sr.Close();
            fs.Close();

            return 0;
        }
    }

    /// <summary>
    /// 椭球体类，包含椭球体的相关参数和函数
    /// </summary>
    public class Ellipsoid
    {
        /// <summary>
        /// 长半轴
        /// </summary>
        public double a;
        /// <summary>
        /// 短半轴
        /// </summary>
        public double b;
        /// <summary>
        /// 返回椭球在极点处的曲率半径
        /// </summary>
        public double c;
        /// <summary>
        /// 扁率
        /// </summary>
        public double alpha;
        /// <summary>
        /// 第一偏心率平方
        /// </summary>
        public double e1_2;
        /// <summary>
        /// 第二偏心率平方
        /// </summary>
        public double e2_2;

        /// <summary>
        /// 返回椭球在极点处的曲率半径
        /// </summary>
        /// <returns></returns>
        public double C()
        {
            return Math.Pow(a, 2) / b;//c=a^2/b
        }

        /// <summary>
        /// 返回椭圆的扁率
        /// </summary>
        public double Alpha()
        {
            return (a - b) / a;
        }

        /// <summary>
        /// 返回椭圆的第一偏心率的平方
        /// </summary>
        public double E1_2()
        {
            return (Math.Pow(a, 2) - Math.Pow(b, 2)) / Math.Pow(a, 2);
        }
        
        /// <summary>
        /// 返回椭圆的第二偏心率的平方
        /// </summary>
        public double E2_2()
        {
            return (Math.Pow(a, 2) - Math.Pow(b, 2)) / Math.Pow(b, 2);
        }

        /// <summary>
        /// 椭球体有参构造函数
        /// </summary>
        public Ellipsoid(double a1, double b1)
        {
            a = a1;
            b = b1;
        }

        /// <summary>
        /// 椭球体无参构造函数
        /// </summary>
        public Ellipsoid() { }

        /// <summary>
        /// 全参数构造函数
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="b1"></param>
        /// <param name="c1"></param>
        /// <param name="compression1"></param>
        /// <param name="e1_square1"></param>
        /// <param name="e2_square1"></param>
        public Ellipsoid(double a1,double b1,double c1,double alpha1,double e1_square1,double e2_square1)
        {
            a = a1;
            b = b1;
            c = c1;
            alpha = alpha1;
            e1_2 = e1_square1;
            e2_2 = e2_square1;
        }
    }
}
