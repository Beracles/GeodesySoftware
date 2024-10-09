using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 主界面;
using System.Runtime.InteropServices;

namespace 坐标系转换
{
    public partial class Coordinate_Transfer_Form : Form
    {
        public Coordinate_Transfer_Form()
        {
            InitializeComponent();

            //初始化已知坐标系和目标坐标系
            Present_Coordinate_cbBx.SelectedIndex = Setting.GCS;    //GCS代表大地坐标系
            Target_Coordinate_cbBx.SelectedIndex = Setting.MRACS;   //MRACS代表子午面直角坐标系
        }
        
        private int times_change = 0;

        /// <summary>
        /// “已知坐标系”下拉菜单发生改变时执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Present_Coordinate_cbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            times_change++;

            //切换标签
            x1_lbl.Text = Coordinate_Transfer.Variable_names[Present_Coordinate_cbBx.SelectedIndex, 0] + ":";
            y1_lbl.Text = Coordinate_Transfer.Variable_names[Present_Coordinate_cbBx.SelectedIndex, 1] + ":";
            z1_lbl.Text = Coordinate_Transfer.Variable_names[Present_Coordinate_cbBx.SelectedIndex, 2] + ":";
            
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
            times_change++;

            //切换标签
            x2_lbl.Text = Coordinate_Transfer.Variable_names[Target_Coordinate_cbBx.SelectedIndex, 0] + ":";
            y2_lbl.Text = Coordinate_Transfer.Variable_names[Target_Coordinate_cbBx.SelectedIndex, 1] + ":";
            z2_lbl.Text = Coordinate_Transfer.Variable_names[Target_Coordinate_cbBx.SelectedIndex, 2] + ":";
            
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
            if (Present_Coordinate_cbBx.SelectedIndex < 0 || Target_Coordinate_cbBx.SelectedIndex < 0)
                return;

            //判断已知坐标系与目标坐标系是否相同
            //当已知坐标系与目标坐标系相同时，弹窗提示
            if (Present_Coordinate_cbBx.SelectedIndex == Target_Coordinate_cbBx.SelectedIndex)
            {
                MessageBox.Show( "坐标系没有变化","Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //当已知坐标系与目标坐标系不同时，进行转换
            else
            {
                //临时变量,p1存储由文本框转换来的坐标数据，p2存储坐标转换后的坐标数据
                Coordinate_Transfer.Coordinate_Value p1,p2;
                
                //获取当前文本框中输入的坐标值
                p1 = Get_Coordinate();

                //判断是否为纯数字
                string tip = "";    //存储文本框输入值非纯数字时对应的坐标变量
                int times = 0;       //记录tip长度增加的次数是否大于0，大于0时则在要添加到tip后面的坐标变量前加一个逗号
                if (p1.X == Errors.Input_Illegal || p1.Y == Errors.Input_Illegal || p1.Z == Errors.Input_Illegal)
                {
                    //有非纯数字时，弹窗提示
                    if (p1.X == Errors.Input_Illegal)
                    {
                        tip += x1_lbl.Text[0];
                        times++;
                    }
                    if (p1.Y == Errors.Input_Illegal)
                    {
                        tip += (times > 0 ? "," : "") + y1_lbl.Text[0];
                        times++;
                    }
                    if (p1.Z == Errors.Input_Illegal)
                        tip += (times > 0 ? "," : "") + z1_lbl.Text[0];
                    MessageBox.Show("坐标值：" + tip+" 非法", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //全为纯数字时，执行坐标转换
                //坐标转换核心代码
                switch (Present_Coordinate_cbBx.SelectedIndex)          //判断已知坐标系是列表中的第几个，0-大地，1-子午，2-空间
                {
                    case 0://大地坐标系
                        switch (Target_Coordinate_cbBx.SelectedIndex)   //判断目标坐标系是第几个，0-大地，1-子午，2-空间
                        {
                            case 1:
                                p2 = Coordinate_Transfer.GCStoMRACS(p1, Setting.ellipsoids[Setting.Current_Ellipsoid]); //大地坐标系转子午面直角坐标系
                                break;
                            case 2:
                                p2 = Coordinate_Transfer.GCStoSRCS(p1, Setting.ellipsoids[Setting.Current_Ellipsoid]);  //大地坐标系转空间坐标系
                                break;
                        }
                        break;
                    case 1://子午面直角坐标
                        switch (Target_Coordinate_cbBx.SelectedIndex)
                        {
                            case 0:
                                                                                    //子午面直角坐标系转大地坐标系:先子午转空间，再空间转大地
                                p2 = Coordinate_Transfer.SRCStoGCS(Coordinate_Transfer.MRACStoSRCS(p1), Setting.ellipsoids[Setting.Current_Ellipsoid]);
                                break;
                            case 2:
                                p2 = Coordinate_Transfer.MRACStoSRCS(p1);           //子午面直角坐标系转空间坐标系
                                break;
                        }
                        break;
                    case 2://空间坐标系
                        switch (Target_Coordinate_cbBx.SelectedIndex)
                        {
                            case 0:
                                p2 = Coordinate_Transfer.SRCStoGCS(p1, Setting.ellipsoids[Setting.Current_Ellipsoid]);  //空间坐标系转大地坐标系
                                break;
                            case 1:
                                p2 = Coordinate_Transfer.SRCStoMRACS(p1);           //空间坐标系转子午面直角坐标系
                                break;
                        }
                        break;
                }
                Coordinate_Show(p2);
            }
        }

        /// <summary>
        /// 将文本框中的文本坐标数据转换为double类型，并返回三维坐标(X,Y,Z)
        /// </summary>
        private Coordinate_Transfer.Coordinate_Value Get_Coordinate()
        {
            Coordinate_Transfer.Coordinate_Value cv; ;

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
                    cv.X = Coordinate_Transfer.Abs1(deg) + Convert.ToDouble(x1_Min_txtBx.Text) / 60 +
                        Convert.ToDouble(x1_Sec_txtBx.Text) / 3600; //度分秒转化为度
                    cv.X *= deg >= 0 ? 1 : -1;
                }
            else
                cv.X = Errors.Input_Illegal;
            }
            else
            {
                if (Num_Check(x1_txtBx.Text))
                    cv.X = Convert.ToDouble(x1_txtBx.Text);
                else
                    cv.X=Errors.Input_Illegal;
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
                    cv.Y = Coordinate_Transfer.Abs1(deg) + Convert.ToDouble(y1_Min_txtBx.Text) / 60 +
                        Convert.ToDouble(y1_Sec_txtBx.Text) / 3600;//度分秒转化为度
                    cv.Y *= deg >= 0 ? 1 : -1;
                }
                else
                    cv.Y = Errors.Input_Illegal;
            }
            else
            {
                if (Num_Check(y1_txtBx.Text))
                    cv.Y = Convert.ToDouble(y1_txtBx.Text);
                else
                    cv.Y = Errors.Input_Illegal;
            }
            //z1
            if (Num_Check(z1_txtBx.Text))
                cv.Z = Convert.ToDouble(z1_txtBx.Text);
            else
                cv.Z = Errors.Input_Illegal;

            return cv;
        }

        /// <summary>
        /// 将点的三维坐标数据输出到文本框中
        /// </summary>
        private void Coordinate_Show(Coordinate_Transfer.Coordinate_Value cv)
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
                    deg = Math.Truncate(cv.X);//度(°)
                    min = Math.Truncate((cv.X - deg) * 60);//分(')
                    sec = Coordinate_Transfer.Abs1((cv.X - deg - min / 60) * 3600);//秒(")
                    min = Coordinate_Transfer.Abs1(min);//只在度前面有正负号
                    x2_Deg_txtBx.Text = deg.ToString();
                    x2_Min_txtBx.Text = min.ToString();
                    x2_Sec_txtBx.Text = sec.ToString();
                }
                else
                    x2_txtBx.Text = cv.X.ToString();
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
                    deg = Math.Truncate(cv.Y);              //度(°)
                    min = Math.Truncate((cv.Y - deg) * 60); //分(')
                    sec = Coordinate_Transfer.Abs1((cv.Y - deg - min / 60) * 3600);   //秒(")
                    min = Coordinate_Transfer.Abs1(min);//只在度前面有正负号
                    y2_Deg_txtBx.Text = deg.ToString();
                    y2_Min_txtBx.Text = min.ToString();
                    y2_Sec_txtBx.Text = sec.ToString();
                }
                else
                    y2_txtBx.Text = cv.Y.ToString();
            }
            //z2
            if (cv.Z == Errors.Cant_Transfer)
                tip += (times > 0 ? "," : "") + y2_lbl.Text[0];
            else
                z2_txtBx.Text = cv.Z.ToString();

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
                if ((str[i] < '0' || str[i] > '9') && str[i] != '.' && str[i] != '-'&&str[i]!='+')//当有数字、正负号和小数点之外的字符时，返回false
                    return false;
            if (Char_Count(str, '.') > 1) return false;
            if (str.Contains("-") && (str.IndexOf('-') != 0 || Char_Count(str, '-') > 1))
                return false;
            if (str.Contains("+") && (str.IndexOf('+') != 0 || Char_Count(str, '+') > 1))
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
        /// 当输入框失去输入焦点时，判断是否为空，为空则置0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputBx_Lose_Focus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
                tb.Text = "0";
        }

        /// <summary>
        /// 当点击窗体可见部分时，使活动控件失去焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Coordinate_Transfer_Form_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }
    }

    public class Coordinate_Transfer
    {
        /// <summary>
        /// 各坐标系统所使用的坐标变量名称：第一行代表大地(B,L,H)，第二行代表子午(L,x,y)，第三行代表空间(X,Y,Z)
        /// </summary>
        public static string[,] Variable_names = { { "B", "L", "H" }, { "L", "x", "y" }, { "X", "Y", "Z" } };

        /// <summary>
        /// 三维坐标，用于保存坐标数据，表示坐标(X,Y,Z)，默认为(0,0,0)
        /// </summary>
        public struct Coordinate_Value
        {
            private static double x;
            private static double y;
            private static double z;

            //封装字段
            public double X { get => x; set => x = value; }
            public double Y { get => y; set => y = value; }
            public double Z { get => z; set => z = value; }

            //重载运算符“==”，定义结构体相等运算符
            public static bool operator ==(Coordinate_Value cv1, Coordinate_Value cv2)
            {
                if (cv1.X == cv2.X && cv1.Y == cv2.Y && cv1.Z == cv2.Z)
                    return true;
                else
                    return false;
            }

            //重写函数Equals()
            public override bool Equals(object obj)
            {
                if (!(obj is Coordinate_Value))
                {
                    return false;
                }

                var value = (Coordinate_Value)obj;
                return X == value.X &&
                       Y == value.Y &&
                       Z == value.Z;
            }

            //重写函数GetHashCode()
            public override int GetHashCode()
            {
                var hashCode = -307843816;
                hashCode = hashCode * -1521134295 + X.GetHashCode();
                hashCode = hashCode * -1521134295 + Y.GetHashCode();
                hashCode = hashCode * -1521134295 + Z.GetHashCode();
                return hashCode;
            }

            //重写运算符“!=”
            public static bool operator !=(Coordinate_Value cv1, Coordinate_Value cv2)
            {
                if (cv1.X == cv2.X && cv1.Y == cv2.Y && cv1.Z == cv2.Z)
                    return false;
                else
                    return true;
            }
        }

        //定义函数坐标系转换函数
        ///<summary>
        ///将大地坐标系坐标转换为子午面直角坐标；
        ///cv.X代表X，cv.Y代表Y，cv.Z代表Z；
        ///ellipsoid 当前椭球体
        ///</summary>
        public static Coordinate_Value GCStoMRACS(Coordinate_Value cv, Ellipsoid ellipsoid)
        {
            Coordinate_Value MRACS;             //存储子午面直角坐标系坐标

            //将变量名与公式一致，便于理解
            double B = cv.X;
            double L = cv.Y;
            double H = cv.Z;

            double x, y;

            //定义变量N，计算N=a/W，代表内法线长
            double N = ellipsoid.a / W(B, ellipsoid.E1());

            //MRACS.X = L;
            //MRACS.Y = ellipsoid.a * Math.Cos(B * Math.PI / 180) / W(B, ellipsoid.Eccentricity_1());//a*cosB/W
            //MRACS.Z = ellipsoid.b * Math.Sin(B * Math.PI / 180) / V(B, ellipsoid.Eccentricity_2());//b*sinB/V

            x = (N + H) * Math.Cos(B * Math.PI / 180);//(N+H)*cosB
            y = (N * (1 - Math.Pow(ellipsoid.E1(), 2)) + H) * Math.Sin(B * Math.PI / 180);//(N*(1-e^2)+H)*sinB

            MRACS.X = L;
            MRACS.Y = x;
            MRACS.Z = y;
            return MRACS;
        }

        ///<summary>
        ///大地坐标系转空间直角坐标系；
        ///cv.X代表B，cv.Y代表L，cv.Z代表H；
        ///ellipsoid 当前椭球体
        ///</summary>
        public static Coordinate_Value GCStoSRCS(Coordinate_Value cv, Ellipsoid ellipsoid)
        {
            Coordinate_Value SRCS;//存储空间直角坐标系

            //将变量名尽量与公式一致，便于理解
            double B = cv.X;
            double L = cv.Y;
            double H = cv.Z;

            //定义变量N，计算N=a/W，代表内法线长
            double N = ellipsoid.a / W(cv.X, ellipsoid.E1());

            SRCS.X = (N + H) * Math.Cos(B * Math.PI / 180) * Math.Cos(L * Math.PI / 180);                   //(N+H)*cosBcosL
            SRCS.Y = (N + H) * Math.Cos(B * Math.PI / 180) * Math.Sin(L * Math.PI / 180);                   //(N+H)*cosBsinL
            SRCS.Z = (N * (1 - Math.Pow(ellipsoid.E1(), 2)) + H) * Math.Sin(B * Math.PI / 180); //(N*(1-e^2)+H)*sinB
            return SRCS;

        }

        ///<summary>
        ///子午面直角坐标系转空间直角坐标系；
        ///cv.X代表L，cv.Y代表x，cv.Z，代表y
        /// </summary>
        public static Coordinate_Value MRACStoSRCS(Coordinate_Value cv)
        {
            Coordinate_Value SRCS;//存储空间直角坐标系

            SRCS.X = cv.Y * Math.Cos(cv.X * Math.PI / 180);
            SRCS.Y = cv.Y * Math.Sin(cv.X * Math.PI / 180);
            SRCS.Z = cv.Z;
            return SRCS;
        }

        /// <summary>
        /// 空间直角坐标系转子午面直角坐标系；
        ///cv.X代表X，cv.Y代表Y，cv.Z代表Z
        /// </summary>
        public static Coordinate_Value SRCStoMRACS(Coordinate_Value cv)
        {
            Coordinate_Value MRACS;//存储子午面直角坐标
            //化简坐标方位名称
            double X = cv.X;
            double Y = cv.Y;
            double Z = cv.Z;
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
        ///cv.X代表X，cv.Y代表Y，cv.Z代表Z
        /// </summary>
        public static Coordinate_Value SRCStoGCS(Coordinate_Value cv, Ellipsoid ellipsoid)
        {
            Coordinate_Value GCS;//存储大地坐标

            //当坐标点位于地心时，无法知道点的经纬度B,L，只能知道高度H
            if (Distance_to_Origin(cv) == 0)
            {
                GCS.X = Errors.Cant_Transfer;
                GCS.Y = Errors.Cant_Transfer;
                GCS.Z = -ellipsoid.a;
                return GCS;
            }

            //化简坐标方位名称
            double X = cv.X;
            double Y = cv.Y;
            double Z = cv.Z;
            //定义大地坐标变量，存储相应的值
            double B, L, H;
            double N;

            L = Math.Atan(Y / X) * 180 / Math.PI;
            B = Iteration_of_B(X, Y, Z, ellipsoid) * 180 / Math.PI; //弧度转角度
            N = ellipsoid.C() / Math.Sqrt(1 + Math.Pow(ellipsoid.E2(), 2) * Math.Pow(Math.Cos(B), 2));  //公式(4-36)
            H = Z / Math.Sin(B) - N * (1 - Math.Pow(ellipsoid.E1(), 2));

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
            const double M = 0.00001;

            double t0 = Z / D;                  //迭代初始值t0
            double p = ellipsoid.C() * Math.Pow(ellipsoid.E1(), 2) / D; //公式(4-40)
            double k = 1 + Math.Pow(ellipsoid.E2(), 2);
            double t1, t2;                      //迭代变量

            t1 = t0;
            //迭代
            do
            {
                //方法一：
                //N = ellipsoid.a / W(B1 * 180 / Math.PI, ellipsoid.E1());
                //B2 = Math.Atan(Z / D + N * Math.Pow(ellipsoid.E1(), 2) * Math.Sin(B1) / D);

                //方法二：
                t2 = t0 + p * t1 / Math.Sqrt(k + Math.Pow(t1, 2));
                if (Abs1(t2 - t1) <= M / 3600) break;
                else t1 = t2;
            } while (true);
            B = Math.Atan(t2);  //正切值转弧度
            return B;
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
        public static double W(double B, double e1)
        {
            return Math.Sqrt(1 - Math.Pow(e1, 2) * Math.Pow(Math.Sin(B * Math.PI / 180), 2));
        }

        /// <summary>
        /// 返回V；
        /// B为某点的纬度(角度制)，e2为当前椭球体的第二偏心率
        /// </summary>
        public static double V(double B, double e2)
        {
            return Math.Sqrt(1 + Math.Pow(e2, 2) * Math.Pow(Math.Cos(B * Math.PI / 180), 2));
        }

        /// <summary>
        /// 返回点到坐标原点的距离
        /// </summary>
        /// <param name="coordinate_Value"></param>
        /// <returns name="dist"></returns>
        public static double Distance_to_Origin(Coordinate_Transfer.Coordinate_Value coordinate_Value)
        {
            double dist;
            dist = Math.Sqrt(Math.Pow(coordinate_Value.X, 2) + Math.Pow(coordinate_Value.Y, 2) + Math.Pow(coordinate_Value.Z, 2));
            return dist;
        }
    }
}
