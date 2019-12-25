using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics;
using MathNet.Numerics.Data.Matlab;

namespace MySystem
{
    public partial class Get_Parameter_Form : Form
    {
        /// <summary>
        /// 父窗体变量
        /// </summary>
        public static Ellipsoid_Transfer_Form ellipsoid_Transfer_Form;

        /// <summary>
        /// 接收父窗体坐标系代号，0-GCS，1-SRCS
        /// </summary>
        public static int Coordinate_System;
        /// <summary>
        /// 接收父窗体的已知椭球体代号
        /// </summary>
        public static int Known_Ellipsoid;
        /// <summary>
        /// 接收父窗体的目标椭球体代号
        /// </summary>
        public static int Target_Ellipsoid;

        public Get_Parameter_Form(Ellipsoid_Transfer_Form form)
        {
            InitializeComponent();
            ellipsoid_Transfer_Form = form;
            //读取父窗体中的配置信息
            Coordinate_System = ((ComboBox)ellipsoid_Transfer_Form.Controls.Find("Coordinate_System_cbBx", false)[0]).SelectedIndex;
            Known_Ellipsoid = ((ComboBox)ellipsoid_Transfer_Form.Controls.Find("Known_Ellipsoid_cbBx", false)[0]).SelectedIndex;
            Target_Ellipsoid = ((ComboBox)ellipsoid_Transfer_Form.Controls.Find("Target_Ellipsoid_cbBx", false)[0]).SelectedIndex;
            Target_Ellipsoid += (Target_Ellipsoid >= Known_Ellipsoid ? 1 : 0);
            //根据父窗体中的坐标系的选择，配置不同的界面
            switch (Coordinate_System)
            {
                case Ellipsoid_Transfer_Form.GCS:
                    Get_Parameter_dgv.Columns[0].HeaderText = "B1";
                    Get_Parameter_dgv.Columns[1].HeaderText = "L1";
                    Get_Parameter_dgv.Columns[2].HeaderText = "H1";
                    Get_Parameter_dgv.Columns[3].HeaderText = "B2";
                    Get_Parameter_dgv.Columns[4].HeaderText = "L2";
                    Get_Parameter_dgv.Columns[5].HeaderText = "H2";
                    Get_Parameter_dgv.Columns[0].Name = "B1";
                    Get_Parameter_dgv.Columns[1].Name = "L1";
                    Get_Parameter_dgv.Columns[2].Name = "H1";
                    Get_Parameter_dgv.Columns[3].Name = "B2";
                    Get_Parameter_dgv.Columns[4].Name = "L2";
                    Get_Parameter_dgv.Columns[5].Name = "H2";
                    tip_lbl.Text = "提示：请分别输入公共点在已知椭球体下的坐标(B1,L1,H1)和目标椭球体下的坐标(B2,L2,H2)";
                    break;
                case Ellipsoid_Transfer_Form.SRCS:
                    Get_Parameter_dgv.Columns[0].HeaderText = "X1";
                    Get_Parameter_dgv.Columns[1].HeaderText = "Y1";
                    Get_Parameter_dgv.Columns[2].HeaderText = "Z1";
                    Get_Parameter_dgv.Columns[3].HeaderText = "X2";
                    Get_Parameter_dgv.Columns[4].HeaderText = "Y2";
                    Get_Parameter_dgv.Columns[5].HeaderText = "Z2";
                    Get_Parameter_dgv.Columns[0].Name = "X1";
                    Get_Parameter_dgv.Columns[1].Name = "Y1";
                    Get_Parameter_dgv.Columns[2].Name = "Z1";
                    Get_Parameter_dgv.Columns[3].Name = "X2";
                    Get_Parameter_dgv.Columns[4].Name = "Y2";
                    Get_Parameter_dgv.Columns[5].Name = "Z2";
                    tip_lbl.Text = "提示：请分别输入公共点在已知椭球体下的坐标(X1,Y1,Z1)和目标椭球体下的坐标(X2,Y2,Z2)";
                    break;
            }
        }

        private void Import_Excel_tsmi_Click(object sender, EventArgs e)
        {
            try
            { 
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "Excel文件(*.xlsx)|*.xlsx|Excel文件(*.xls)|*.xls|文本(*.txt)|*.txt",
                    CheckFileExists = true
                };
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filename = ofd.FileName;//文件名

                    IWorkbook wb;
                    ISheet sheet;
                    IRow row;
                    FileStream fs;
                    fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    //列索引
                    int column_last, column_first;
                    //行索引
                    int row_last, row_first;
                    switch (ofd.FilterIndex)
                    {
                        case 1://第一个索引为.xlsx格式
                            wb = new XSSFWorkbook(fs);
                            sheet = (XSSFSheet)wb.GetSheet("Sheet1");

                            //获取行数和列数
                            row_first = sheet.FirstRowNum;
                            row_last = sheet.LastRowNum;
                            row = sheet.GetRow(row_first);
                            column_first = row.FirstCellNum;
                            column_last = row.LastCellNum;

                            for (int i = row_first; i <= row_last; i++)
                            {
                                Get_Parameter_dgv.Rows.Add();
                                for (int j = column_first; j < column_last; j++)
                                {
                                    Get_Parameter_dgv.Rows[i].Cells[j].Value = sheet.GetRow(i).GetCell(j).StringCellValue;
                                }
                            }
                            wb.Close();
                            break;
                        case 2://第二个索引为.xls格式
                            wb = new HSSFWorkbook(fs);
                            sheet = (HSSFSheet)wb.GetSheet("Sheet1");

                            //获取行数和列数、
                            row_first = sheet.FirstRowNum;
                            row_last = sheet.LastRowNum;
                            row = sheet.GetRow(row_first);
                            column_first = row.FirstCellNum;
                            column_last = row.LastCellNum;

                            for (int i = row_first; i <= row_last; i++)
                            {
                                Get_Parameter_dgv.Rows.Add();
                                for (int j = column_first; j < column_last; j++)
                                {
                                    Get_Parameter_dgv.Rows[i].Cells[j].Value = sheet.GetRow(i).GetCell(j).StringCellValue;
                                }
                            }
                            wb.Close();
                            break;
                        case 3://第三个索引为.txt格式
                            break;
                    }
                    fs.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Calc_btn_Click(object sender, EventArgs e)
        {
            //获取DataGridView控件中的数据的行数,即为公共点的个数
            int point_count = Get_Parameter_dgv.Rows.Count - 1;

            switch (Coordinate_System)
            {
                case Ellipsoid_Transfer_Form.GCS://大地坐标系
                    break;
                case Ellipsoid_Transfer_Form.SRCS:
                    var dX = new DenseMatrix(7, 1);//待求转换参数向量δX
                    var B = new DenseMatrix(point_count * 3, 7);//系数阵
                    var L = new DenseMatrix(point_count * 3, 1);//已知值向量

                    //读取坐标值
                    Ellipsoid_Transfer_Form.Common_Points.Rows.Clear();//清空公共点列表
                    for (int i = 0; i < point_count; i++)//每个点三个方程
                    {
                        Point p_known = new Point();
                        Point p_trans = new Point();
                        var b =new DenseMatrix(3, 7);

                        for(int j = 0; j < 3; j++)
                        {
                            p_known[j] = Convert.ToDouble(Get_Parameter_dgv.Rows[i].Cells[j].Value.ToString());
                            p_trans[j] = Convert.ToDouble(Get_Parameter_dgv.Rows[i].Cells[j + 3].Value.ToString());
                            L[3 * i + j,0] = p_trans[j];//对已知值向量赋值
                        }

                        //将公共点坐标保存在Common_Points表中
                        DataRow row = Ellipsoid_Transfer_Form.Common_Points.NewRow();
                        for (int j = 0; j < 3; j++)
                        {
                            row[j] = p_known[j];
                            row[j + 3] = p_trans[j];
                        }
                        Ellipsoid_Transfer_Form.Common_Points.Rows.Add(row);

                        b = Get_Matrix_B(p_known);
                        B.SetSubMatrix(3 * i, 0, b);//把b插入B中
                    }

                    //法方程求解
                    dX = (B.Transpose() * B).Inverse() * B.Transpose() * L as DenseMatrix;

                    //对全局变量赋值
                    Ellipsoid_Transfer_Form.dXo = dX[0, 0];
                    Ellipsoid_Transfer_Form.dYo = dX[1, 0];
                    Ellipsoid_Transfer_Form.dZo = dX[2, 0];
                    Ellipsoid_Transfer_Form.m = dX[3, 0] - 1;
                    Ellipsoid_Transfer_Form.eX = dX[4, 0] / dX[3, 0];
                    Ellipsoid_Transfer_Form.eY = dX[5, 0] / dX[3, 0];
                    Ellipsoid_Transfer_Form.eZ = dX[6, 0] / dX[3, 0];
                    Ellipsoid_Transfer_Form.Coordinate_System = Coordinate_System;
                    Ellipsoid_Transfer_Form.Known_Ellipsoid = Known_Ellipsoid;
                    Ellipsoid_Transfer_Form.Target_Ellipsoid = Target_Ellipsoid;
                    break;

            }

            //显示结果
            string result = "转换参数计算结果如下：\n" +
                "△Xo=" + Ellipsoid_Transfer_Form.dXo.ToString() + "\n\n" +
                "△Yo=" + Ellipsoid_Transfer_Form.dYo.ToString() + "\n\n" +
                "△Zo=" + Ellipsoid_Transfer_Form.dZo.ToString() + "\n\n" +
                "m=" + Ellipsoid_Transfer_Form.m.ToString() + "\n\n" +
                "εX=" + Ellipsoid_Transfer_Form.eX.ToString() + "\n\n" +
                "εY=" + Ellipsoid_Transfer_Form.eY.ToString() + "\n\n" +
                "εZ=" + Ellipsoid_Transfer_Form.eZ.ToString() + "\n\n";
            if (Coordinate_System == Ellipsoid_Transfer_Form.GCS)//大地坐标系比空间直角坐标系多两个参数
            {
                result += 
                    "△a=" + Ellipsoid_Transfer_Form.da.ToString() + "\n\n" +
                    "△α=" + Ellipsoid_Transfer_Form.daf.ToString() + "\n\n";
            }
            MessageBox.Show(result, "计算结果", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //激活椭球体转换界面“输入”和“转换”功能
            GroupBox Input_gpBx = (GroupBox)ellipsoid_Transfer_Form.Controls.Find("Input_gpBx", false)[0];
            Button Transfer_btn = (Button)ellipsoid_Transfer_Form.Controls.Find("Transfer_btn", false)[0];
            MenuStrip Ellipsoid_Transfer_ms = (MenuStrip)ellipsoid_Transfer_Form.Controls.Find("Ellipsoid_Transfer_ms", false)[0];
            ToolStripMenuItem Search_Parameter_tsmi = ((ToolStripMenuItem)Ellipsoid_Transfer_ms.Items.Find("Search_Parameter_tsmi", true)[0]);
            ToolStripMenuItem Export_Parameter_tsmi = ((ToolStripMenuItem)Ellipsoid_Transfer_ms.Items.Find("Export_Parameter_tsmi", true)[0]);
            Search_Parameter_tsmi.Enabled = true;
            Export_Parameter_tsmi.Enabled = true;
            foreach (System.Windows.Forms.Control c in Input_gpBx.Controls)
            {
                c.Enabled = true;
            }
            Transfer_btn.Enabled = true;

            //求出参数后关闭“求参数”窗体
            this.Close();
        }

        /// <summary>
        /// 当行数增加时，判断点的个数是否大于或等于3，满足条件时，“计算”按钮变为可用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Get_Parameter_dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (Get_Parameter_dgv.Rows.Count >= 4)
                Calc_btn.Enabled = true;
        }

        /// <summary>
        /// 当行数减少时，判断剩余点的个数是否大于或等于3，不满足条件时，“计算”按钮变为不可用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Get_Parameter_dgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (Get_Parameter_dgv.Rows.Count < 4)
                Calc_btn.Enabled = false;
        }

        private void Get_Parameter_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Ellipsoid_Transfer_Form.form = null;
        }

        /// <summary>
        /// 返回一个点的系数矩阵B（3*7）
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static DenseMatrix Get_Matrix_B(Point p)
        {
            DenseMatrix B = new DenseMatrix(3, 7);
            var I = DenseMatrix.CreateIdentity(3);
            var b = new DenseMatrix(3);
            for(int i = 0; i < 3; i++)
                B[i, 3] = p[i];
            
            b[0, 1] = -p.Z;
            b[0, 2] = p.Y;
            b[1, 2] = -p.X;
            b -= b.Transpose() as DenseMatrix;
            B.SetSubMatrix(0, 0, I);
            B.SetSubMatrix(0, 4, b);

            return B;
        }
        
    }
}
