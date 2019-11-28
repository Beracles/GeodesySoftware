using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.Data.Matlab;
using MathNet.Numerics.LinearAlgebra.Double;
using System.IO;

namespace MySystem
{
    public partial class Ellipsoid_Transfer_Form : Form
    {
        public Ellipsoid_Transfer_Form()
        {
            InitializeComponent();

            //刚打开此功能时，无法输入和转换，因为没有确定参数
            foreach (Control c in Input_gpBx.Controls)
                c.Enabled = false;
            Transfer_btn.Enabled = false;

            //“查看参数”和“导出参数”功能初始化为不可用，因为参数为空
            Search_Parameter_tsmi.Enabled = false;
            Export_Parameter_tsmi.Enabled = false;

            //初始化坐标系为空间直角坐标系
            Coordinate_System_cbBx.SelectedIndex = SRCS;

            //初始化椭球体
            Target_Ellipsoid_cbBx.Items.RemoveAt(Known_Ellipsoid_cbBx_SelectedIndex);
            Known_Ellipsoid_cbBx.SelectedIndex = Known_Ellipsoid_cbBx_SelectedIndex;
            Target_Ellipsoid_cbBx.SelectedIndex = Target_Ellipsoid_cbBx_SelectedIndex +
                (Target_Ellipsoid_cbBx_SelectedIndex > Known_Ellipsoid_cbBx.SelectedIndex ? -1 : 0);
            
            //为GroupBox组件添加MouseDown事件
            Input_gpBx.MouseDown += new MouseEventHandler(Ellipsoid_Transfer_Form_MouseDown);
            Output_gpBx.MouseDown += new MouseEventHandler(Ellipsoid_Transfer_Form_MouseDown);

        }

        /// <summary>
        /// 临时窗体变量
        /// </summary>
        public static Form form;

        #region 参数定义

        /// <summary>
        /// 平移参数△Xo，默认为0
        /// </summary>
        public static double dXo = 0;
        /// <summary>
        /// 平移参数△Yo，默认为0
        /// </summary>
        public static double dYo = 0;
        /// <summary>
        /// 平移参数△Zo，默认为0
        /// </summary>
        public static double dZo = 0;
        /// <summary>
        /// 旋转参数εX，默认为0
        /// </summary>
        public static double eX = 0;
        /// <summary>
        /// 旋转参数εY，默认为0
        /// </summary>
        public static double eY = 0;
        /// <summary>
        /// 旋转参数εZ，默认为0
        /// </summary>
        public static double eZ = 0;
        /// <summary>
        /// 尺度变化参数m，默认为0
        /// </summary>
        public static double m = 0;
        /// <summary>
        /// 地球椭球元素变化参数△a，默认为0
        /// </summary>
        public static double da = 0;
        /// <summary>
        /// 地球椭球元素变花参数△α，默认为0
        /// </summary>
        public static double daf = 0;

        /// <summary>
        /// 转换参数所用的坐标系类型,默认为空（值为-1）
        /// </summary>
        public static int Coordinate_System = -1;
        /// <summary>
        /// 与参数对应的已知椭球体，默认为空（值为-1）
        /// </summary>
        public static int Known_Ellipsoid = -1;
        /// <summary>
        /// 与参数对应的目标椭球体，默认为空（值为-1）
        /// </summary>
        public static int Target_Ellipsoid = -1;

        #endregion

        /// <summary>
        /// “已知椭球体”选中的椭球体代号，默认为WGS-84
        /// </summary>
        public static int Known_Ellipsoid_cbBx_SelectedIndex = WGS_84_ellipsoid;
        /// <summary>
        /// “目标椭球体”选中的椭球体代号，默认为克拉索夫斯基椭球体
        /// </summary>
        public static int Target_Ellipsoid_cbBx_SelectedIndex = Krassowski_eliipsoid;

        //定义椭球体代号
        /// <summary>
        /// 克拉索夫斯基椭球体代号，值为0
        /// </summary>
        public const int Krassowski_eliipsoid = 0;
        /// <summary>
        /// 国际椭球体代号，值为1
        /// </summary>
        public const int International_ellipsoid = 1;
        /// <summary>
        /// WGS-84椭球体代号，值为2
        /// </summary>
        public const int WGS_84_ellipsoid = 2;
        /// <summary>
        /// 2000中国大地坐标系代号，值为3
        /// </summary>
        public const int CGCS2000_ellipsoid = 3;

        /// <summary>
        /// 坐标系变量名列表0-B,L,H，1-X,Y,Z
        /// </summary>
        public static string[,] Vars = new string[2, 3] { { "B", "L", "H" }, { "X", "Y", "Z" } };

        /// <summary>
        /// 椭球体名称列表，用于导出参数时文件命名，0-克拉索夫，1-国际，2-WGS-84,3-CGCS2000
        /// </summary>
        public static string[] ellipsoids = new string[4] { "克拉索夫", "国际", "WGS-84", "CGCS2000" };

        /// <summary>
        /// 坐标系名称列表0-GCS，1-SRCS
        /// </summary>
        public static string[] coordinate_systems = new string[2] { "GCS", "SRCS" };

        /// <summary>
        /// 大地坐标系代号0
        /// </summary>
        public const int GCS = 0;

        /// <summary>
        /// 空间直角坐标系代号1
        /// </summary>
        public const int SRCS = 1;

        /// <summary>
        /// 坐标系切换时执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Coordinate_System_cbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //输入
            //切换变量名
            x1_lbl.Text = Vars[Coordinate_System_cbBx.SelectedIndex, 0] + ":";
            y1_lbl.Text = Vars[Coordinate_System_cbBx.SelectedIndex, 1] + ":";
            z1_lbl.Text = Vars[Coordinate_System_cbBx.SelectedIndex, 2] + ":";

            //输入框配置
            #region 通过文本框前面的标签判断应该输入的数据类型，然后配置不同的输入界面

            #region x1
            if (x1_lbl.Text == "B:")
            {
                //角度输入配置
                x1_Deg_lbl.Visible = true;
                x1_Min_lbl.Visible = true;
                x1_Sec_lbl.Visible = true;
                x1_Deg_txtBx.Visible = true;
                x1_Min_txtBx.Visible = true;
                x1_Sec_txtBx.Visible = true;
                //长度输入配置
                x1_txtBx.Visible = false;
                x1_Meter_lbl.Visible = false;
            }
            else
            {
                //角度输入配置
                x1_Deg_lbl.Visible = false;
                x1_Min_lbl.Visible = false;
                x1_Sec_lbl.Visible = false;
                x1_Deg_txtBx.Visible = false;
                x1_Min_txtBx.Visible = false;
                x1_Sec_txtBx.Visible = false;
                //长度输入配置
                x1_txtBx.Visible = true;
                x1_Meter_lbl.Visible = true;
            }
            //原数据置0
            x1_txtBx.Text = "0";
            x1_Deg_txtBx.Text = "0";
            x1_Min_txtBx.Text = "0";
            x1_Sec_txtBx.Text = "0";
            #endregion
            #region y1
            if (y1_lbl.Text == "L:")
            {
                //角度输入配置
                y1_Deg_lbl.Visible = true;
                y1_Min_lbl.Visible = true;
                y1_Sec_lbl.Visible = true;
                y1_Deg_txtBx.Visible = true;
                y1_Min_txtBx.Visible = true;
                y1_Sec_txtBx.Visible = true;
                //长度输入配置
                y1_txtBx.Visible = false;
                y1_Meter_lbl.Visible = false;
            }
            else
            {
                //角度输入配置
                y1_Deg_lbl.Visible = false;
                y1_Min_lbl.Visible = false;
                y1_Sec_lbl.Visible = false;
                y1_Deg_txtBx.Visible = false;
                y1_Min_txtBx.Visible = false;
                y1_Sec_txtBx.Visible = false;
                //长度输入配置
                y1_txtBx.Visible = true;
                y1_Meter_lbl.Visible = true;
            }
            //原数据置0
            y1_txtBx.Text = "0";
            y1_Deg_txtBx.Text = "0";
            y1_Min_txtBx.Text = "0";
            y1_Sec_txtBx.Text = "0";
            #endregion
            #region z1
            //原数据置0
            z1_txtBx.Text = "0";
            #endregion

            #endregion

            //输出
            //切换变量名
            x2_lbl.Text = Vars[Coordinate_System_cbBx.SelectedIndex, 0] + ":";
            y2_lbl.Text = Vars[Coordinate_System_cbBx.SelectedIndex, 1] + ":";
            z2_lbl.Text = Vars[Coordinate_System_cbBx.SelectedIndex, 2] + ":";

            //输出框配置
            #region 通过文本框前面的标签判断应该输出的数据类型，然后配置不同的输出界面

            #region x2
            if (x2_lbl.Text == "B:")
            {
                //角度输入配置
                x2_Deg_lbl.Visible = true;
                x2_Min_lbl.Visible = true;
                x2_Sec_lbl.Visible = true;
                x2_Deg_txtBx.Visible = true;
                x2_Min_txtBx.Visible = true;
                x2_Sec_txtBx.Visible = true;
                //长度输入配置
                x2_txtBx.Visible = false;
                x2_Meter_lbl.Visible = false;
            }
            else
            {
                //角度输入配置
                x2_Deg_lbl.Visible = false;
                x2_Min_lbl.Visible = false;
                x2_Sec_lbl.Visible = false;
                x2_Deg_txtBx.Visible = false;
                x2_Min_txtBx.Visible = false;
                x2_Sec_txtBx.Visible = false;
                //长度输入配置
                x2_txtBx.Visible = true;
                x2_Meter_lbl.Visible = true;
            }
            //清除上次结果
            x2_txtBx.Clear();
            x2_Deg_txtBx.Clear();
            x2_Min_txtBx.Clear();
            x2_Sec_txtBx.Clear();
            #endregion
            #region y2
            if (y2_lbl.Text == "L:")
            {
                //角度输入配置
                y2_Deg_lbl.Visible = true;
                y2_Min_lbl.Visible = true;
                y2_Sec_lbl.Visible = true;
                y2_Deg_txtBx.Visible = true;
                y2_Min_txtBx.Visible = true;
                y2_Sec_txtBx.Visible = true;
                //长度输入配置
                y2_txtBx.Visible = false;
                y2_Meter_lbl.Visible = false;
            }
            else
            {
                //角度输入配置
                y2_Deg_lbl.Visible = false;
                y2_Min_lbl.Visible = false;
                y2_Sec_lbl.Visible = false;
                y2_Deg_txtBx.Visible = false;
                y2_Min_txtBx.Visible = false;
                y2_Sec_txtBx.Visible = false;
                //长度输入配置
                y2_txtBx.Visible = true;
                y2_Meter_lbl.Visible = true;
            }
            //清除上次结果
            y2_txtBx.Clear();
            y2_Deg_txtBx.Clear();
            y2_Min_txtBx.Clear();
            y2_Sec_txtBx.Clear();
            #endregion
            #region z2
            //清除上次结果
            z2_txtBx.Clear();
            #endregion

            #endregion
            
        }

        private void Known_Ellipsoid_cbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Target_Ellipsoid_cbBx.Items.Insert(Known_Ellipsoid_cbBx_SelectedIndex, Setting.Ellipsoids[Known_Ellipsoid_cbBx_SelectedIndex]);
            Known_Ellipsoid_cbBx_SelectedIndex = Known_Ellipsoid_cbBx.SelectedIndex;
            Target_Ellipsoid_cbBx.Items.RemoveAt(Known_Ellipsoid_cbBx_SelectedIndex);
        }

        private void Target_Ellipsoid_cbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Target_Ellipsoid_cbBx_SelectedIndex = Target_Ellipsoid_cbBx.SelectedIndex +
                (Target_Ellipsoid_cbBx.SelectedIndex >= Known_Ellipsoid_cbBx.SelectedIndex ? 1 : 0);
        }

        /// <summary>
        /// 判断选中的坐标系和椭球体是否与参数匹配，若匹配则返回true,否则返回false
        /// </summary>
        /// <returns></returns>
        private bool Parameter_Match_Check()
        {

            if (Known_Ellipsoid_cbBx.SelectedIndex == Known_Ellipsoid &&
                Target_Ellipsoid_cbBx.SelectedIndex == Target_Ellipsoid &&
                Coordinate_System_cbBx.SelectedIndex == Coordinate_System)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 转换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Transfer_btn_Click(object sender, EventArgs e)
        {
            if (!Parameter_Match_Check())
            {
                MessageBox.Show("参数不匹配！\n请通过“查看参数”确定对应的坐标系、已知椭球体和目标椭球体；\n或者通过“求参数”重新计算参数。",
                    "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Coordinate_System_Transfer.Coordinate_Value value_get = new Coordinate_System_Transfer.Coordinate_Value();
            Coordinate_System_Transfer.Coordinate_Value value_show = new Coordinate_System_Transfer.Coordinate_Value();

            value_get = Get_Coordinate();

            //输入有错误时，退出函数
            if (value_get.X == Errors.Input_Illegal || value_get.X == Errors.Input_Out_of_Range ||
                value_get.Y == Errors.Input_Illegal || value_get.Y == Errors.Input_Out_of_Range ||
                value_get.Z == Errors.Input_Illegal)
            {
                return;
            }

            switch (Coordinate_System_cbBx.SelectedIndex)
            {
                case 0://大地坐标系
                    break;
                case 1://空间直角坐标系
                    var B = Get_Parameter_Form.Get_Matrix_B(value_get);
                    var dX = new DenseVector(7);
                    dX[0] = dXo;
                    dX[1] = dYo;
                    dX[2] = dZo;
                    dX[3] = m + 1;
                    dX[4] = dX[3] * eX;
                    dX[5] = dX[3] * eY;
                    dX[6] = dX[3] * eZ;

                    //计算
                    var Result = B * dX;
                    value_show.X = Result[0];
                    value_show.Y = Result[1];
                    value_show.Z = Result[2];

                    //显示结果
                    Coordinate_Show(value_show);
                    break;
            }
        }

        /// <summary>
        /// 求参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Get_Parameter_tsmi_Click(object sender, EventArgs e)
        {
            if (form == null)
            {
                form = new Get_Parameter_Form(this);
                form.Show();
            }
            else
            {
                form.Activate();
                form.Show();
                form.WindowState = FormWindowState.Normal;
            }
        }
        
        /// <summary>
        /// 查看参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_Parameter_tsmi_Click(object sender, EventArgs e)
        {
            if (form == null)
            {
                form = new Search_Parameter_Form();
                form.Show();
            }
            else
            {
                form.Activate();
                form.Show();
                form.WindowState = FormWindowState.Normal;
            }
        }
        
        /// <summary>
        /// 将转换参数保存为*.mat或.txt格式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Export_Parameter_tsmi_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "MatLab文件(*.mat)|*.mat|文本文件(*.txt)|*.txt";
            sfd.FileName = coordinate_systems[Coordinate_System] + "_" + ellipsoids[Known_Ellipsoid] + "_" + ellipsoids[Target_Ellipsoid];
            //sfd.FileOk+=new CancelEventHandler()
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path;
                switch (sfd.FilterIndex)
                {
                    case 1://mat文件
                        //读取
                        var paras = new DenseVector(12);
                        paras[0] = Coordinate_System;//坐标系
                        paras[1] = Known_Ellipsoid;//已知椭球体
                        paras[2] = Target_Ellipsoid;//目标椭球体
                        paras[3] = dXo;
                        paras[4] = dYo;
                        paras[5] = dZo;
                        paras[6] = m;
                        paras[7] = eX;
                        paras[8] = eY;
                        paras[9] = eZ;
                        paras[10] = da;
                        paras[11] = daf;

                        //写入
                        path = sfd.FileName + (sfd.FileName.Contains(".mat") ? "" : ".mat");
                        var mat = paras.ToColumnMatrix();
                        List<MatlabMatrix> parameter = new List<MatlabMatrix>()
                        {
                            MatlabWriter.Pack(mat,"parameters")
                        };
                        MatlabWriter.Store(path, parameter);
                        break;
                    case 2://txt文件
                        //写入
                        path = sfd.FileName + (sfd.FileName.Contains(".txt") ? "" : ".txt");
                        FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);
                        sw.WriteLine(Coordinate_System.ToString());//坐标系
                        sw.WriteLine(Known_Ellipsoid.ToString());//已知椭球体
                        sw.WriteLine(Target_Ellipsoid.ToString());//目标椭球体
                        sw.WriteLine(dXo.ToString());
                        sw.WriteLine(dYo.ToString());
                        sw.WriteLine(dZo.ToString());
                        sw.WriteLine(m.ToString());
                        sw.WriteLine(eX.ToString());
                        sw.WriteLine(eY.ToString());
                        sw.WriteLine(eZ.ToString());
                        sw.WriteLine(da.ToString());
                        sw.WriteLine(daf.ToString());
                        sw.Close();
                        fs.Close();
                        break;
                }
            }
        }

        /// <summary>
        /// 导入参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Import_Parameter_tsmi_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter= "MatLab文件(*.mat)|*.mat|文本文件(*.txt)|*.txt";
            ofd.CheckFileExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                switch (ofd.FilterIndex)
                {
                    case 1:
                        //读取
                        DenseMatrix paras = (DenseMatrix)MatlabReader.Read<double>(ofd.FileName, "parameters");
                        DenseVector parameters = (DenseVector)paras.Column(0);

                        //赋值
                        Coordinate_System = (int)parameters[0];
                        Known_Ellipsoid = (int)parameters[1];
                        Target_Ellipsoid = (int)parameters[2];
                        dXo = parameters[3];
                        dYo = parameters[4];
                        dZo = parameters[5];
                        m = parameters[6];
                        eX = parameters[7];
                        eY = parameters[8];
                        eZ = parameters[9];
                        da = parameters[10];
                        daf = parameters[11];
                        break;
                    case 2:
                        FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                        StreamReader sr = new StreamReader(fs);
                        //读取的同时写入
                        Coordinate_System = Convert.ToInt32(sr.ReadLine());
                        Known_Ellipsoid = Convert.ToInt32(sr.ReadLine());
                        Target_Ellipsoid = Convert.ToInt32(sr.ReadLine());
                        dXo = Convert.ToDouble(sr.ReadLine());
                        dYo = Convert.ToDouble(sr.ReadLine());
                        dZo = Convert.ToDouble(sr.ReadLine());
                        m = Convert.ToDouble(sr.ReadLine());
                        eX = Convert.ToDouble(sr.ReadLine());
                        eY = Convert.ToDouble(sr.ReadLine());
                        eZ = Convert.ToDouble(sr.ReadLine());
                        da = Convert.ToDouble(sr.ReadLine());
                        daf = Convert.ToDouble(sr.ReadLine());

                        sr.Close();
                        fs.Close();
                        break;
                }
                //导入参数成功后激活“查看参数”和“导出参数”按钮
                Search_Parameter_tsmi.Enabled = true;
                Export_Parameter_tsmi.Enabled = true;
                foreach(Control c in Input_gpBx.Controls)
                {
                    c.Enabled = true;
                }
                Transfer_btn.Enabled = true;
            }
        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ellipsoid_Transfer_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.form = null;//关闭窗体时，让form变量回归到空状态
        }

        private void Ellipsoid_Transfer_Form_Activated(object sender, EventArgs e)
        {
            if (form != null)
            {
                form.Activate();
                form.Show();
                form.WindowState = FormWindowState.Normal;
            }
        }
        /// <summary>
        /// 将文本框中的文本坐标数据转换为double类型，并返回三维坐标(X,Y,Z)
        /// </summary>
        private Coordinate_System_Transfer.Coordinate_Value Get_Coordinate()
        {
            Coordinate_System_Transfer.Coordinate_Value cv = new Coordinate_System_Transfer.Coordinate_Value();

            //定义次数变量，记录错误的个数，用于判断对应的错误提示语前是否要加逗号
            int times = 0;
            //保存每种错误的提示语
            string tips = "";

            //x1
            if (x1_lbl.Text == "B:" || x1_lbl.Text == "L:")
            {
                //判断是否为纯数字，并且分和秒输入框中不含负号
                if (Num_Check(x1_Deg_txtBx.Text) &&
                    Num_Check(x1_Min_txtBx.Text) &&
                    Num_Check(x1_Sec_txtBx.Text) &&
                    !x1_Min_txtBx.Text.Contains("-") &&
                    !x1_Sec_txtBx.Text.Contains("-") &&
                    !x1_Min_txtBx.Text.Contains("+") &&
                    !x1_Sec_txtBx.Text.Contains("+"))
                {
                    double deg = Convert.ToDouble(x1_Deg_txtBx.Text);
                    double min = Convert.ToDouble(x1_Min_txtBx.Text);
                    double sec = Convert.ToDouble(x1_Sec_txtBx.Text);

                    //判断度分秒是否分别大于它们的限定值90度，60分，60秒
                    if (x1_lbl.Text == "B:")
                    {
                        if (deg > 90 || deg < -90 || min > 60 || sec > 60)
                        {
                            tips += x1_lbl.Text;
                            if (deg > 90 || deg < -90)
                            {
                                tips += "度值应满足[-90,90]";
                                times++;
                            }
                            if (min > 59)
                            {
                                tips += (times > 0 ? "，" : "") + "分值应满足[0,59]";
                                times++;
                            }
                            if (sec >= 60)
                            {
                                tips += (times > 0 ? "，" : "") + "秒值应满足[0,60)";
                            }
                            tips += "\n";
                            times = 0;//使用后归零
                            cv.X = Errors.Input_Out_of_Range;//输入超出范围
                        }
                        else
                        {
                            cv.X = Coordinate_System_Transfer.Abs1(deg) + min / 60 + sec / 3600; //度分秒转化为度
                            cv.X *= x1_Deg_txtBx.Text[0] == '-' ? -1 : 1;
                            if (cv.X > 90 || cv.X < -90)
                            {
                                tips += x1_lbl.Text + "纬度值应满足[-90,90]";
                                cv.X = Errors.Input_Out_of_Range;//输入超出范围
                            }
                        }
                    }
                    if (x1_lbl.Text == "L:")
                    {
                        if (deg > 180 || deg < -180 || min > 60 || sec > 60)
                        {
                            tips += x1_lbl.Text;
                            if (deg > 180 || deg < -180)
                            {
                                tips += "度值应满足[-180,180]";
                                times++;
                            }
                            if (min > 59)
                            {
                                tips += (times > 0 ? "，" : "") + "分值应满足[0,59]";
                                times++;
                            }
                            if (sec >= 60)
                            {
                                tips += (times > 0 ? "，" : "") + "秒值应满足[0,60)";
                            }
                            tips += "\n";
                            times = 0;//使用后归零
                            cv.X = Errors.Input_Out_of_Range;//输入超出范围
                        }
                        else
                        {
                            cv.X = Coordinate_System_Transfer.Abs1(deg) + min / 60 + sec / 3600; //度分秒转化为度
                            cv.X *= x1_Deg_txtBx.Text[0] == '-' ? -1 : 1;
                            if (cv.X > 180 || cv.X < -180)
                            {
                                tips += x1_lbl.Text + "经度值值应满足[-180,180]";
                                cv.X = Errors.Input_Out_of_Range;//输入超出范围
                            }
                        }
                    }
                }
                else
                {
                    tips += x1_lbl.Text + "不是合法的角度值\n";
                    cv.X = Errors.Input_Illegal;
                }
            }
            else
            {
                if (Num_Check(x1_txtBx.Text))
                    cv.X = Convert.ToDouble(x1_txtBx.Text);
                else
                {
                    tips += x1_lbl.Text + "不是合法的数值\n";
                    cv.X = Errors.Input_Illegal;
                }
            }
            //y1
            if (y1_lbl.Text == "L:")
            {
                //当三个框都为纯数字时，转化为度赋给Y，否则返回错误代码：Not_Pure_Num
                if (Num_Check(y1_Deg_txtBx.Text) &&
                    Num_Check(y1_Min_txtBx.Text) &&
                    Num_Check(y1_Sec_txtBx.Text) &&
                    !y1_Min_txtBx.Text.Contains("-") &&
                    !y1_Sec_txtBx.Text.Contains("-") &&
                    !y1_Min_txtBx.Text.Contains("+") &&
                    !y1_Sec_txtBx.Text.Contains("+"))
                {
                    double deg = Convert.ToDouble(y1_Deg_txtBx.Text);
                    double min = Convert.ToDouble(y1_Min_txtBx.Text);
                    double sec = Convert.ToDouble(y1_Sec_txtBx.Text);

                    if (deg > 180 || deg < -180 || min > 60 || sec > 60)
                    {
                        tips += y1_lbl.Text;
                        if (deg > 180 || deg < -180)
                        {
                            tips += "度值应满足[-180,180]";
                            times++;
                        }
                        if (min > 59)
                        {
                            tips += (times > 0 ? "，" : "") + "分值应满足[0,59]";
                            times++;
                        }
                        if (sec >= 60)
                        {
                            tips += (times > 0 ? "，" : "") + "秒值应满足[0,60)";
                        }
                        tips += "\n";
                        times = 0;//使用后归零
                        cv.Y = Errors.Input_Out_of_Range;//输入超出范围
                    }
                    else
                    {
                        cv.Y = Coordinate_System_Transfer.Abs1(deg) + min / 60 + sec / 3600; //度分秒转化为度
                        cv.Y *= y1_Deg_txtBx.Text[0] == '-' ? -1 : 1;
                        if (cv.Y > 180 || cv.Y < -180)
                        {
                            tips += y1_lbl.Text + "经度值值应满足[-180,180]";
                            cv.Y = Errors.Input_Out_of_Range;//输入超出范围
                        }
                    }
                }
                else
                {
                    tips += y1_lbl.Text + "不是合法的角度值\n";
                    cv.Y = Errors.Input_Illegal;
                }
            }
            else
            {
                if (Num_Check(y1_txtBx.Text))
                    cv.Y = Convert.ToDouble(y1_txtBx.Text);
                else
                {
                    tips += y1_lbl.Text + "不是合法的数值\n";
                    cv.Y = Errors.Input_Illegal;
                }
            }
            //z1
            if (Num_Check(z1_txtBx.Text))
                cv.Z = Convert.ToDouble(z1_txtBx.Text);
            else
            {
                tips += z1_lbl.Text + "不是合法的数值\n";
                cv.Z = Errors.Input_Illegal;
            }

            if (cv.X == Errors.Input_Illegal || cv.X == Errors.Input_Out_of_Range ||
                cv.Y == Errors.Input_Illegal || cv.Y == Errors.Input_Out_of_Range ||
                cv.Z == Errors.Input_Illegal)
            {
                //输入错误时，弹窗提示
                MessageBox.Show("输入错误：\n" + tips, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tips = "";
            }

            return cv;
        }
        
        /// <summary>
        /// 将点的三维坐标数据输出到文本框中
        /// </summary>
        private void Coordinate_Show(Coordinate_System_Transfer.Coordinate_Value cv)
        {
            string tip = "";    //存储输出值不确定坐标对应的坐标变量
            int times = 0;      //记录tip长度增加的次数是否大于0，大于0时则在要添加到tip后面的坐标变量前加一个逗号

            //x2
            if (cv.X == Errors.Cant_Transfer)
            {
                tip += x2_lbl.Text[0];
                times++;
            }
            else
            {
                if (x2_lbl.Text == "B:" || x2_lbl.Text == "L:")
                {
                    double deg, min, sec;
                    //其他全部取绝对值
                    deg = Math.Truncate(cv.X);//度(°)
                    min = Math.Truncate((cv.X - deg) * 60);//分(')
                    sec = Coordinate_System_Transfer.Abs1((cv.X - deg - min / 60) * 3600);//秒(")
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

                    //保留有效数字时，进行角度进制转换
                    x2_Deg_txtBx.Text = (cv.X < 0 ? "-" : "") + deg.ToString();
                    x2_Min_txtBx.Text = min.ToString();
                    x2_Sec_txtBx.Text = sec.ToString("f2");
                }
                else
                    x2_txtBx.Text = cv.X.ToString("G");
            }
            //y2
            if (cv.Y == Errors.Cant_Transfer)
            {
                tip += (times > 0 ? "," : "") + y2_lbl.Text[0];
                times++;
            }
            else
            {
                if (y2_lbl.Text == "L:")
                {
                    double deg, min, sec;

                    //其他全部取绝对值
                    deg = Math.Truncate(cv.Y);              //度(°)
                    min = Math.Truncate((cv.Y - deg) * 60); //分(')
                    sec = Coordinate_System_Transfer.Abs1((cv.Y - deg - min / 60) * 3600);   //秒(")
                    min = Coordinate_System_Transfer.Abs1(min);
                    deg = Coordinate_System_Transfer.Abs1(deg);

                    //保留有效数字时，进行角度进制转换
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

                    y2_Deg_txtBx.Text = (cv.Y < 0 ? "-" : "") + deg.ToString();
                    y2_Min_txtBx.Text = min.ToString();
                    y2_Sec_txtBx.Text = sec.ToString("f2");
                }
                else
                    y2_txtBx.Text = cv.Y.ToString().Length >= 16 ? cv.Y.ToString("f" + (16 - Math.Truncate(cv.Y).ToString().Length).ToString()) : cv.Y.ToString("G");
            }
            //z2
            if (cv.Z == Errors.Cant_Transfer)
                tip += (times > 0 ? "," : "") + y2_lbl.Text[0];
            else
                z2_txtBx.Text = cv.Z.ToString().Length >= 16 ? cv.Z.ToString("f" + (16 - Math.Truncate(cv.Z).ToString().Length).ToString()) : cv.Z.ToString("G");

            //当有坐标值无法确定是弹窗提示
            if (cv.X == Errors.Cant_Transfer || cv.Y == Errors.Cant_Transfer || cv.Z == Errors.Cant_Transfer)
                MessageBox.Show("坐标值：" + tip + "无法确定！", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 判断字符串是否为合法数数值，是则返回true，否则返回false
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static bool Num_Check(string str)
        {
            for (int i = 0; i < str.Length; i++)
                if ((str[i] < '0' || str[i] > '9') && str[i] != '.' && str[i] != '-' && str[i] != '+')//当有数字、正负号和小数点之外的字符时，返回false
                    return false;
            if (Char_Count(str, '.') > 1) return false;
            if (str.Contains("-") && (str.IndexOf('-') != 0 || Char_Count(str, '-') > 1) || str == "-")
                return false;
            if (str.Contains("+") && (str.IndexOf('+') != 0 || Char_Count(str, '+') > 1) || str == "+")
                return false;
            return true;
        }
        
        /// <summary>
        /// 返回字符串中含某个字符的个数
        /// </summary>
        /// <param name="str"></param>
        /// <param name="ch"></param>
        /// <returns></returns>
        private static int Char_Count(string str, char ch)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch) count++;
            }
            return count;
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

        /// <summary>
        /// 当点击窗体可见部分时，使活动控件失去焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ellipsoid_Transfer_Form_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
