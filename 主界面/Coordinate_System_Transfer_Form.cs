using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MathNet.Numerics.LinearAlgebra.Double;

namespace MySystem
{
    public partial class Coordinate_System_Transfer_Form : Form
    {
        public Coordinate_System_Transfer_Form()
        {
            InitializeComponent();

            //初始化下拉菜单数组
            this.Target_Coordinate_cbBxs = new ComboBox[3] { Target_Coordinate_cbBx0, Target_Coordinate_cbBx1, Target_Coordinate_cbBx2 };
            
            //初始化已知坐标系
            Present_Coordinate_cbBx.SelectedIndex = Setting.Current_Coordinate_System;    //GCS代表大地坐标系

            //为GroupBox组件添加MouseDown事件
            Input_gpBx.MouseDown += new MouseEventHandler(Coordinate_System_Transfer_Form_MouseDown);
            Output_gpBx.MouseDown += new MouseEventHandler(Coordinate_System_Transfer_Form_MouseDown);
        }

        /// <summary>
        /// ComBox数组，保存当已知坐标系选择不同时目标坐标系的三种不同状态
        /// </summary>
        private System.Windows.Forms.ComboBox[] Target_Coordinate_cbBxs;

        /// <summary>
        /// “已知坐标系”下拉菜单发生改变时执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Present_Coordinate_cbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            //切换标签
            x1_lbl.Text = Coordinate_System_Transfer.Variable_names[Present_Coordinate_cbBx.SelectedIndex, 0] + ":";
            y1_lbl.Text = Coordinate_System_Transfer.Variable_names[Present_Coordinate_cbBx.SelectedIndex, 1] + ":";
            z1_lbl.Text = Coordinate_System_Transfer.Variable_names[Present_Coordinate_cbBx.SelectedIndex, 2] + ":";

            //显示特定的下拉菜单,隐藏其他下拉菜单
            this.Target_Coordinate_cbBxs[Present_Coordinate_cbBx.SelectedIndex].Visible = true;
            for(int i=0;i<3;i++)
            {
                if (i != Present_Coordinate_cbBx.SelectedIndex)
                {
                    this.Target_Coordinate_cbBxs[i].Visible = false;
                }
            }
            int selectedIndex = this.Target_Coordinate_cbBxs[Present_Coordinate_cbBx.SelectedIndex].SelectedIndex;
            this.Target_Coordinate_cbBxs[Present_Coordinate_cbBx.SelectedIndex].SelectedIndex = 0;
            //如果目标坐标系索引没有变化，仍执行变化事件函数一次
            if(selectedIndex == this.Target_Coordinate_cbBxs[Present_Coordinate_cbBx.SelectedIndex].SelectedIndex)
                Target_Coordinate_cbBx_SelectedIndexChanged(sender, e);

            #region 通过文本框前面的标签判断应该输入的数据类型，然后配置不同的输入界面
            //x1
            if (x1_lbl.Text == "B:" || x1_lbl.Text == "L:")
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

            //y1
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

            //z1
            //原数据置0
            z1_txtBx.Text = "0";

            //将上次的计算结果清空
            x2_txtBx.Clear();
            x2_Deg_txtBx.Clear();
            x2_Min_txtBx.Clear();
            x2_Sec_txtBx.Clear();
            y2_txtBx.Clear();
            y2_Deg_txtBx.Clear();
            y2_Min_txtBx.Clear();
            y2_Sec_txtBx.Clear();
            z2_txtBx.Clear();

            #endregion
        }

        /// <summary>
        /// “目标坐标系”下拉菜单发生改变时执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Target_Coordinate_cbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            int var = 1;//用于保存坐标变量标签的下标
            //获取目标坐标系对应于已知坐标系下拉菜单中的索引
            for(int i = 0; i < 3; i++)
            {
                if (Present_Coordinate_cbBx.Items[i] == this.Target_Coordinate_cbBxs[Present_Coordinate_cbBx.SelectedIndex].SelectedItem)
                {
                    var = i;
                    break;
                }
            }
            //切换标签
            x2_lbl.Text = Coordinate_System_Transfer.Variable_names[var, 0] + ":";
            y2_lbl.Text = Coordinate_System_Transfer.Variable_names[var, 1] + ":";
            z2_lbl.Text = Coordinate_System_Transfer.Variable_names[var, 2] + ":";
            
            #region 通过文本框前面的标签判断应该输出的数据类型，然后配置不同的输出界面
            //x2
            if (x2_lbl.Text == "B:" || x2_lbl.Text == "L:")
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
            //清除原数据
            x2_txtBx.Clear();
            x2_Deg_txtBx.Clear();
            x2_Min_txtBx.Clear();
            x2_Sec_txtBx.Clear();

            //y2
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
            //清除原数据
            y2_txtBx.Clear();
            y2_Deg_txtBx.Clear();
            y2_Min_txtBx.Clear();
            y2_Sec_txtBx.Clear();

            //z2
            //原数据置0
            z2_txtBx.Clear();

            #endregion
        }

        /// <summary>
        /// 点击“转换”按钮时执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Transfer_btn_Click(object sender, EventArgs e)
        {
            //当“已知坐标系”或“目标坐标系”下拉菜单为空或为其他值时，不执行转换而直接返回
            if (Present_Coordinate_cbBx.SelectedIndex < 0 || Target_Coordinate_cbBxs[Present_Coordinate_cbBx.SelectedIndex].SelectedIndex < 0)
                return;

            //临时变量,p1存储由文本框转换来的坐标数据，p2存储坐标转换后的坐标数据
            Point p_get = new Point();
            Point p_show = new Point();

            //获取当前文本框中输入的坐标值
            p_get = Get_Coordinate();

            //输入有错误时，退出函数
            if (p_get.X == Errors.Input_Illegal || p_get.X == Errors.Input_Out_of_Range ||
                p_get.Y == Errors.Input_Illegal || p_get.Y == Errors.Input_Out_of_Range ||
                p_get.Z == Errors.Input_Illegal)
            {
                return;
            }

            //输入没有问题时，执行坐标转换
            //坐标转换核心代码
            switch (Present_Coordinate_cbBx.SelectedIndex)          //判断已知坐标系是列表中的第几个，0-大地，1-子午，2-空间
            {
                case 0://大地坐标系
                    switch (Target_Coordinate_cbBxs[0].SelectedIndex)   //判断目标坐标系是第几个，0-大地，1-子午，2-空间
                    {
                        case 0:
                            p_show = Coordinate_System_Transfer.GCStoMRACS(p_get, Setting.ellipsoids[Setting.Current_Ellipsoid]); //大地坐标系转子午面直角坐标系
                            break;
                        case 1:
                            p_show = Coordinate_System_Transfer.GCStoSRCS(p_get, Setting.ellipsoids[Setting.Current_Ellipsoid]);  //大地坐标系转空间坐标系
                            break;
                    }
                    break;
                case 1://子午面直角坐标
                    switch (Target_Coordinate_cbBxs[1].SelectedIndex)
                    {
                        case 0:
                            //子午面直角坐标系转大地坐标系:先子午转空间，再空间转大地
                            p_show = Coordinate_System_Transfer.SRCStoGCS(Coordinate_System_Transfer.MRACStoSRCS(p_get), Setting.ellipsoids[Setting.Current_Ellipsoid]);
                            break;
                        case 1:
                            p_show = Coordinate_System_Transfer.MRACStoSRCS(p_get);           //子午面直角坐标系转空间坐标系
                            break;
                    }
                    break;
                case 2://空间坐标系
                    switch (Target_Coordinate_cbBxs[2].SelectedIndex)
                    {
                        case 0:
                            p_show = Coordinate_System_Transfer.SRCStoGCS(p_get, Setting.ellipsoids[Setting.Current_Ellipsoid]);  //空间坐标系转大地坐标系
                            break;
                        case 1:
                            p_show = Coordinate_System_Transfer.SRCStoMRACS(p_get);           //空间坐标系转子午面直角坐标系
                            break;
                    }
                    break;
            }
            Coordinate_Show(p_show);
        }

        /// <summary>
        /// 将文本框中的文本坐标数据转换为double类型，并返回三维坐标(X,Y,Z)
        /// </summary>
        private Point Get_Coordinate()
        {
            Point p =new Point();
            
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
                            p.X = Errors.Input_Out_of_Range;//输入超出范围
                        }
                        else
                        {
                            p.X = Coordinate_System_Transfer.Abs1(deg) + min / 60 + sec / 3600; //度分秒转化为度
                            p.X *= x1_Deg_txtBx.Text[0] == '-' ? -1 : 1;
                            if (p.X > 90 || p.X < -90)
                            {
                                tips += x1_lbl.Text + "纬度值应满足[-90,90]";
                                p.X = Errors.Input_Out_of_Range;//输入超出范围
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
                            p.X = Errors.Input_Out_of_Range;//输入超出范围
                        }
                        else
                        {
                            p.X = Coordinate_System_Transfer.Abs1(deg) + min / 60 + sec / 3600; //度分秒转化为度
                            p.X *= x1_Deg_txtBx.Text[0] == '-' ? -1 : 1;
                            if (p.X > 180 || p.X < -180)
                            {
                                tips += x1_lbl.Text + "经度值值应满足[-180,180]";
                                p.X = Errors.Input_Out_of_Range;//输入超出范围
                            }
                        }
                    }
                }
                else
                {
                    tips += x1_lbl.Text + "不是合法的角度值\n";
                    p.X = Errors.Input_Illegal;
                }
            }
            else
            {
                if (Num_Check(x1_txtBx.Text))
                    p.X = Convert.ToDouble(x1_txtBx.Text);
                else
                {
                    tips += x1_lbl.Text + "不是合法的数值\n";
                    p.X = Errors.Input_Illegal;
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
                        p.Y = Errors.Input_Out_of_Range;//输入超出范围
                    }
                    else
                    {
                        p.Y = Coordinate_System_Transfer.Abs1(deg) + min / 60 + sec / 3600; //度分秒转化为度
                        p.Y *= y1_Deg_txtBx.Text[0] == '-' ? -1 : 1;
                        if (p.Y > 180 || p.Y < -180)
                        {
                            tips += y1_lbl.Text + "经度值值应满足[-180,180]";
                            p.Y = Errors.Input_Out_of_Range;//输入超出范围
                        }
                    }
                }
                else
                {
                    tips += y1_lbl.Text + "不是合法的角度值\n";
                    p.Y = Errors.Input_Illegal;
                }
            }
            else
            {
                if (Num_Check(y1_txtBx.Text))
                    p.Y = Convert.ToDouble(y1_txtBx.Text);
                else
                {
                    tips += y1_lbl.Text + "不是合法的数值\n";
                    p.Y = Errors.Input_Illegal;
                }
            }
            //z1
            if (Num_Check(z1_txtBx.Text))
                p.Z = Convert.ToDouble(z1_txtBx.Text);
            else
            {
                tips += z1_lbl.Text + "不是合法的数值\n";
                p.Z = Errors.Input_Illegal;
            }

            if (p.X == Errors.Input_Illegal || p.X==Errors.Input_Out_of_Range || 
                p.Y == Errors.Input_Illegal || p.Y==Errors.Input_Out_of_Range || 
                p.Z == Errors.Input_Illegal)
            {
                //输入错误时，弹窗提示
                MessageBox.Show("输入错误：\n" + tips, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tips = "";
            }  

            return p;
        }

        /// <summary>
        /// 将点的三维坐标数据输出到文本框中
        /// </summary>
        private void Coordinate_Show(Point p)
        {
            string tip = "";    //存储输出值不确定坐标对应的坐标变量
            int times = 0;      //记录tip长度增加的次数是否大于0，大于0时则在要添加到tip后面的坐标变量前加一个逗号

            //x2
            if (p.X == Errors.Cant_Transfer)
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
                    deg = Math.Truncate(p.X);//度(°)
                    min = Math.Truncate((p.X - deg) * 60);//分(')
                    sec = Coordinate_System_Transfer.Abs1((p.X - deg - min / 60) * 3600);//秒(")
                    min = Coordinate_System_Transfer.Abs1(min);
                    deg = Coordinate_System_Transfer.Abs1(deg);
                    if(double.Parse(sec.ToString("f2"))==60)
                    {
                        sec = 0;
                        min++;
                    }
                    if(double.Parse(min.ToString("f2"))==60)
                    {
                        min = 0;
                        deg++;
                    }

                    //保留有效数字时，进行角度进制转换
                    x2_Deg_txtBx.Text = (p.X < 0 ? "-" : "") + deg.ToString();
                    x2_Min_txtBx.Text = min.ToString();
                    x2_Sec_txtBx.Text = sec.ToString("f2");
                }
                else
                    x2_txtBx.Text = p.X.ToString("G");
            }
            //y2
            if (p.Y == Errors.Cant_Transfer)
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
                    deg = Math.Truncate(p.Y);              //度(°)
                    min = Math.Truncate((p.Y - deg) * 60); //分(')
                    sec = Coordinate_System_Transfer.Abs1((p.Y - deg - min / 60) * 3600);   //秒(")
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

                    y2_Deg_txtBx.Text = (p.Y < 0 ? "-" : "") + deg.ToString();
                    y2_Min_txtBx.Text = min.ToString();
                    y2_Sec_txtBx.Text = sec.ToString("f2");
                }
                else
                    y2_txtBx.Text = p.Y.ToString().Length >= 16 ? p.Y.ToString("f" + (16 - Math.Truncate(p.Y).ToString().Length).ToString()) : p.Y.ToString("G");
            }
            //z2
            if (p.Z == Errors.Cant_Transfer)
                tip += (times > 0 ? "," : "") + y2_lbl.Text[0];
            else
                z2_txtBx.Text = p.Z.ToString().Length >= 16 ? p.Z.ToString("f" + (16 - Math.Truncate(p.Z).ToString().Length).ToString()) : p.Z.ToString("G");

            //当有坐标值无法确定是弹窗提示
            if (p.X == Errors.Cant_Transfer || p.Y == Errors.Cant_Transfer || p.Z == Errors.Cant_Transfer)
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
                if ((str[i] < '0' || str[i] > '9') && str[i] != '.' && str[i] != '-'&&str[i]!='+')//当有数字、正负号和小数点之外的字符时，返回false
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
        private static int Char_Count(string str,char ch)
        {
            int count = 0;
            for(int i = 0; i < str.Length; i++)
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
        private void InputBx_Got_Focus(object sender,EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if(tb.Text=="0")
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
        private void Coordinate_System_Transfer_Form_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        private void Coordinate_System_Transfer_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.form = null;
        }
    }

    /// <summary>
    /// double点类型
    /// </summary>
    public class Point
    {
        #region 属性
        private double x;
        private double y;
        private double z;
        //封装
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public double Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }
        /// <summary>
        /// 点的坐标值列表
        /// </summary>
        public double this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0:return x;
                    case 1:return y;
                    case 2:return z;
                    default:throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (i)
                {
                    case 0: x = value;break;
                    case 1: y = value;break;
                    case 2: z = value;break;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }
        #endregion

        #region 构造函数
        /// <summary>
        /// 定义一个坐标为(0,0,0)的点
        /// </summary>
        public Point()
        {
            X = 0;Y = 0;Z = 0;
        }
        /// <summary>
        /// 定义一个坐标为(x,y,z)的点
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Point(double x,double y,double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        #endregion

        #region 方法
        /// <summary>
        /// 两点p1,p2间距离
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static double Distance(Point p1,Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2) + Math.Pow(p1.Z - p2.Z, 2));
        }
        /// <summary>
        /// 两点间(x1,y1,z1), (x2,y2,z2)间的距离
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="z1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="z2"></param>
        /// <returns></returns>
        public static double Distance(double x1,double y1,double z1,double x2,double y2,double z2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        }

        /// <summary>
        /// 到点p的距离
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public double DistanceTo(Point p)
        {
            return Math.Sqrt(Math.Pow(X - p.X, 2) + Math.Pow(Y - p.Y, 2) + Math.Pow(Z - p.Z, 2));
        }

        /// <summary>
        /// 到原点的距离
        /// </summary>
        /// <returns></returns>
        public double Distance_To_Origin()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
        }

        /// <summary>
        /// 返回两个点是否相等的布尔值
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var point = obj as Point;
            return point != null &&
                   X == point.X &&
                   Y == point.Y &&
                   Z == point.Z;
        }

        public override int GetHashCode()
        {
            var hashCode = -237065584;
            hashCode = hashCode * -1521134295 + x.GetHashCode();
            hashCode = hashCode * -1521134295 + y.GetHashCode();
            hashCode = hashCode * -1521134295 + z.GetHashCode();
            return hashCode;
        }

        //将点坐标转换为列向量
        public DenseMatrix ToColumnVector()
        {
            DenseMatrix matrix = new DenseMatrix(3, 1);
            for(int i = 0; i < 3; i++)
            {
                matrix[i, 0] = this[i];
            }
            return matrix;
        }

        //将点坐标转换为行向量
        public DenseMatrix ToRowVector()
        {
            DenseMatrix matrix = new DenseMatrix(1, 3);
            for (int i = 0; i < 3; i++)
            {
                matrix[0, i] = this[i];
            }
            return matrix;
        }

        #endregion

        #region 运算符
        //重载运算符“==”，定义Point类型相等运算符
        public static bool operator ==(Point p1, Point p2)
        {
            if (p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z)
                return true;
            else
                return false;
        }

        //重写运算符“!=”
        public static bool operator !=(Point p1, Point p2)
        {
            if (p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z)
                return false;
            else
                return true;
        }
        #endregion
    }

    public class Coordinate_System_Transfer
    {
        /// <summary>
        /// 各坐标系统所使用的坐标变量名称：第一行代表大地(B,L,H)，第二行代表子午(L,x,y)，第三行代表空间(X,Y,Z)
        /// </summary>
        public static string[,] Variable_names = { { "B", "L", "H" }, { "L", "x", "y" }, { "X", "Y", "Z" } };

        ///// <summary>
        ///// 三维坐标，用于保存坐标数据，表示坐标(X,Y,Z)，默认为(0,0,0)
        ///// </summary>
        //public struct Coordinate_Value
        //{
        //    public double X;
        //    public double Y;
        //    public double Z;

        //    ////封装字段
        //    //public double X { get => x; set => x = value; }
        //    //public double Y { get => y; set => y = value; }
        //    //public double Z { get => z; set => z = value; }

        //    //重载运算符“==”，定义结构体相等运算符
        //    public static bool operator ==(Coordinate_Value cv1, Coordinate_Value cv2)
        //    {
        //        if (cv1.X == cv2.X && cv1.Y == cv2.Y && cv1.Z == cv2.Z)
        //            return true;
        //        else
        //            return false;
        //    }

        //    //重写函数Equals()
        //    public override bool Equals(object obj)
        //    {
        //        if (!(obj is Coordinate_Value))
        //        {
        //            return false;
        //        }

        //        var value = (Coordinate_Value)obj;
        //        return X == value.X &&
        //               Y == value.Y &&
        //               Z == value.Z;
        //    }

        //    //重写函数GetHashCode()
        //    public override int GetHashCode()
        //    {
        //        var hashCode = -307843816;
        //        hashCode = hashCode * -1521134295 + X.GetHashCode();
        //        hashCode = hashCode * -1521134295 + Y.GetHashCode();
        //        hashCode = hashCode * -1521134295 + Z.GetHashCode();
        //        return hashCode;
        //    }

        //    //重写运算符“!=”
        //    public static bool operator !=(Coordinate_Value cv1, Coordinate_Value cv2)
        //    {
        //        if (cv1.X == cv2.X && cv1.Y == cv2.Y && cv1.Z == cv2.Z)
        //            return false;
        //        else
        //            return true;
        //    }
        //}

        //定义函数坐标系转换函数

        ///<summary>
        ///将大地坐标系坐标转换为子午面直角坐标；
        ///p.X代表X，p.Y代表Y，p.Z代表Z；
        ///ellipsoid 当前椭球体
        ///</summary>
        public static Point GCStoMRACS(Point p, Ellipsoid ellipsoid)
        {
            Point MRACS = new Point();             //存储子午面直角坐标系坐标

            //将变量名与公式一致，便于理解
            double B = p.X;
            double L = p.Y;
            double H = p.Z;

            double x, y;

            //定义变量N，计算N=a/W，代表内法线长
            double N = ellipsoid.a / W(B, ellipsoid.e1_2);

            //MRACS.X = L;
            //MRACS.Y = ellipsoid.a * Math.Cos(B * Math.PI / 180) / W(B, ellipsoid.Eccentricity_1());//a*cosB/W
            //MRACS.Z = ellipsoid.b * Math.Sin(B * Math.PI / 180) / V(B, ellipsoid.Eccentricity_2());//b*sinB/V

            x = (N + H) * Math.Cos(B * Math.PI / 180);//(N+H)*cosB
            y = (N * (1 - ellipsoid.e1_2) + H) * Math.Sin(B * Math.PI / 180);//(N*(1-e^2)+H)*sinB

            MRACS.X = L;
            MRACS.Y = x;
            MRACS.Z = y;
            return MRACS;
        }

        ///<summary>
        ///大地坐标系转空间直角坐标系；
        ///p.X代表B，p.Y代表L，p.Z代表H；
        ///ellipsoid 当前椭球体
        ///</summary>
        public static Point GCStoSRCS(Point p, Ellipsoid ellipsoid)
        {
            Point SRCS = new Point();//存储空间直角坐标系

            //将变量名尽量与公式一致，便于理解
            double B = p.X;
            double L = p.Y;
            double H = p.Z;

            //定义变量N，计算N=a/W，代表内法线长
            double N = ellipsoid.a / W(B, ellipsoid.e1_2);

            SRCS.X = (N + H) * Math.Cos(B * Math.PI / 180) * Math.Cos(L * Math.PI / 180); //(N+H)*cosBcosL
            SRCS.Y = (N + H) * Math.Cos(B * Math.PI / 180) * Math.Sin(L * Math.PI / 180);                   //(N+H)*cosBsinL
            SRCS.Z = (N * (1 - ellipsoid.e1_2) + H) * Math.Sin(B * Math.PI / 180); //(N*(1-e^2)+H)*sinB
            return SRCS;

        }

        ///<summary>
        ///子午面直角坐标系转空间直角坐标系；
        ///p.X代表L，p.Y代表x，p.Z，代表y
        /// </summary>
        public static Point MRACStoSRCS(Point p)
        {
            Point SRCS = new Point
            {
                X = p.Y * Math.Cos(p.X * Math.PI / 180),
                Y = p.Y * Math.Sin(p.X * Math.PI / 180),
                Z = p.Z
            };//存储空间直角坐标系
            return SRCS;
        }

        /// <summary>
        /// 空间直角坐标系转子午面直角坐标系；
        ///p.X代表X，p.Y代表Y，p.Z代表Z
        /// </summary>
        public static Point SRCStoMRACS(Point p)
        {
            Point MRACS = new Point();//存储子午面直角坐标
            //化简坐标方位名称
            double X = p.X;
            double Y = p.Y;
            double Z = p.Z;
            //定义子午面直角坐标变量，存储相应的值
            double L, x, y;

            if (X == 0)
            {
                L = Errors.Cant_Transfer;
                MRACS.X = L;
            }                                   //当X=0时，返回错误代码
            else
            {
                L = Math.Atan(Y / X);
                MRACS.X = L * 180 / Math.PI;    //弧度转角度
            }                                   //L=arctan(Y/X),这里算出来的是弧度

            x = X / Math.Cos(L);                //用cos使用的是弧度，计算x
            y = Z;                              //y=Z

            //将子午面直角坐标的值赋给MRACS
            MRACS.Y = x;
            MRACS.Z = y;
            return MRACS;
        }

        /// <summary>
        /// 空间直角坐标系转大地坐标系；
        ///p.X代表X，p.Y代表Y，p.Z代表Z
        /// </summary>
        public static Point SRCStoGCS(Point p, Ellipsoid ellipsoid)
        {
            Point GCS = new Point();//存储大地坐标

            //当坐标点位于地心时，无法知道点的经纬度B,L，只能知道高度H
            if (p.Distance_To_Origin() == 0)
            {
                GCS.X = Errors.Cant_Transfer;
                GCS.Y = Errors.Cant_Transfer;
                GCS.Z = -ellipsoid.a;
                return GCS;
            }

            //化简坐标方位名称
            double X = p.X;
            double Y = p.Y;
            double Z = p.Z;
            //定义大地坐标变量，存储相应的值
            double B, L, H;//B,L为角度
            double N;

            L = Math.Atan(Y / X) * 180 / Math.PI;
            B = Iteration_of_B(X, Y, Z, ellipsoid) * 180 / Math.PI; //弧度转角度
            N = ellipsoid.c / Math.Sqrt(1 + ellipsoid.e2_2 * Math.Pow(Math.Cos(B*Math.PI/180), 2));  //公式(4-36)
            if (B == 0)
                H = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2)) / Math.Cos(B * Math.PI / 180) - N;
            else
                H = Z / Math.Sin(B*Math.PI/180) - N * (1 - ellipsoid.e1_2);

            GCS.X = B;
            GCS.Y = L;
            GCS.Z = H;

            return GCS;
        }

        /// <summary>
        /// 迭代函数Iteration_of_B()，
        /// <return>B double类型，经迭代后符合精度要求的B值</return>
        /// </summary>
        public static double Iteration_of_B(double X, double Y, double Z, Ellipsoid ellipsoid)
        {
            double B;                           //B为弧度制
            double D = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));      //计算√(X^2+Y^2)

            //M为迭代法求B时B的精度，单位为"(秒)
            double M = 0.00001;

            double t0 = Z / D;                  //迭代初始值t0
            double p = ellipsoid.c * ellipsoid.e1_2 / D; //公式(4-40)
            double k = 1 + ellipsoid.e2_2;
            double t1, t2;                      //迭代变量

            t1 = t0;
            //迭代
            do
            {
                //方法一：
                //N = ellipsoid.a / W(B1 * 180 / Math.PI, ellipsoid.E1_square());
                //B2 = Math.Atan(Z / D + N * ellipsoid.E1_square() * Math.Sin(B1) / D);

                //方法二：
                t2 = t0 + p * t1 / Math.Sqrt(k + Math.Pow(t1, 2));

                if (Abs1(t2 - t1) <= (M / 3600) * Math.PI / 180) break;
                t1 = t2;
            } while (true);
            B = Math.Atan(t2);  //正切值转弧度
            return B;//弧度
        }

        /// <summary>
        /// 返回实数的绝对值
        /// </summary>
        public static double Abs1(double a)
        {
            if (a >= 0) return a;
            else return -a;
        }

        //定义函数V()和W()，用于求公式中的V，W，以化简计算
        /// <summary>
        /// 返回W；
        /// B为某点的纬度(角度制)，e1为当前椭球体的第一偏心率
        /// </summary>
        public static double W(double B, double e1_square)
        {
            return Math.Sqrt(1 - e1_square * Math.Pow(Math.Sin(B * Math.PI / 180), 2));
        }

        /// <summary>
        /// 返回V；
        /// B为某点的纬度(角度制)，e2为当前椭球体的第二偏心率
        /// </summary>
        public static double V(double B, double e2_square)
        {
            return Math.Sqrt(1 + e2_square * Math.Pow(Math.Cos(B * Math.PI / 180), 2));
        }

        ///// <summary>
        ///// 返回点到坐标原点的距离
        ///// </summary>
        ///// <param name="coordinate_Value"></param>
        ///// <returns name="dist"></returns>
        //public static double Distance_to_Origin(Point p)
        //{
        //    double dist;
        //    dist = Math.Sqrt(Math.Pow(p.X, 2) + Math.Pow(p.Y, 2) + Math.Pow(p.Z, 2));
        //    return dist;
        //}
    }
}
