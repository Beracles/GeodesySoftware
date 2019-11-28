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
    public partial class MainForm : Form
    {
        /// <summary>
        /// 窗体变量，作为被打开子窗体的对象引用
        /// </summary>
        public static Form form;
        
        public MainForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// 启动坐标系转换功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CS_Transfer_tsmi_Click(object sender, EventArgs e)
        {
            if (form==null)
            {
                form = new Coordinate_System_Transfer_Form();
                form.Show();
            }
            else
            {
                form.Activate();
                form.WindowState = FormWindowState.Normal;
                form.Show();
            }
        }
        
        /// <summary>
        /// 主窗体大小改变时执行，如果最小化，则将子窗体也最小化（如果有的话）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (form != null && this.WindowState == FormWindowState.Minimized)
                form.WindowState = FormWindowState.Minimized;
            if (form != null && this.WindowState == FormWindowState.Normal)
            {
                form.WindowState = FormWindowState.Normal;
                form.Activate();
            }
        }
       
        /// <summary>
        /// 主窗体关闭时，进行配置的保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Setting.Save_Setting_Or_Not)
            {
                //文件路径
                string path = Directory.GetCurrentDirectory() + @"\..\..\..\配置文件.txt";

                //判断文件是否存在
                if (!File.Exists(path))
                {
                    MessageBox.Show("文件不存在：" + path + "\n设置无法保存！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                
                sw.WriteLine("Current_Coordinate_System");
                sw.WriteLine(Setting.Current_Coordinate_System);
                sw.WriteLine("Current_Ellipsoid");
                sw.WriteLine(Setting.Current_Ellipsoid);
                sw.WriteLine("Current_Unit");
                sw.WriteLine(Setting.Current_Unit);

                sw.Close();
                fs.Close();
            }
        }

        /// <summary>
        /// 打开配置窗口，设置系统属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Setting_tsmi_Click(object sender, EventArgs e)
        {
            if (form==null)
            {
                form = new SettingForm(this);
                form.Show();
            }
            else
            {
                form.Activate();
                form.WindowState = FormWindowState.Normal;
                form.Show();
            }
        }
        
        /// <summary>
        /// 主窗体加载时执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //读取配置文件
            double get = Setting.Get_Current_Setting();
            if (get == Errors.File_Not_Exist)//如果返回文件不存在错误，弹窗提示是否使用默认配置，是则继续，否则退出程序
            {
                DialogResult = MessageBox.Show("将使用默认配置\n是否继续？", "Tip", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (DialogResult == DialogResult.No)//
                    Application.Exit();
            }

            //显示当前椭球体
            Current_Ellipsoid_tssl.Text = "椭球体：" + Setting.Ellipsoids[Setting.Current_Ellipsoid];

            //显示当前坐标系
            Current_Coordinate_System_tssl.Text = "坐标系：" + Setting.Coordinate_Systems[Setting.Current_Coordinate_System];

            //显示当前使用单位
            Current_Unit_tssl.Text = "单位：" + Setting.Units[Setting.Current_Unit];
        }

        /// <summary>
        /// 主窗体被激活时，如果有子窗体之前被打开，则将子窗体也激活
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (form != null)
            {
                form.Activate();
                form.WindowState = FormWindowState.Normal;
            }
        }
        
        /// <summary>
        /// 当单击“椭球体-查看参数”按钮时，执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ellipsoid_Properties_tsmi_Click(object sender, EventArgs e)
        {
            if (form==null)
            {
                form = new Ellipsoid_Properties_Form();
                form.Show();
            }
            else
            {
                form.Activate();
                form.WindowState = FormWindowState.Normal;
                form.Show();
            }
        }
        
        /// <summary>
        /// 椭球体-转换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ellipsoid_Transfer_tsmi_Click(object sender, EventArgs e)
        {
            if (form==null)
            {
                form = new Ellipsoid_Transfer_Form();
                form.Show();
            }
            else
            {
                form.Activate();
                form.WindowState = FormWindowState.Normal;
                form.Show();
            }
        }
    }
}
