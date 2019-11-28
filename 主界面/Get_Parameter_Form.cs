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
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Excel文件(*.xls)|*.xls|Excel文件(*.xlsx)|*.xlsx|文本(*.txt)|*.txt",
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
                int column_last, column_first;
                int row_last, row_first;
                switch (ofd.FilterIndex)
                {
                    case 1://第一个索引为.xls格式
                        wb = new HSSFWorkbook(fs);
                        sheet = (HSSFSheet)wb.GetSheet("Sheet1");

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
                    case 2://第二个索引为.xlsx格式
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
                    case 3://第三个索引为.txt格式
                        break;
                }
                fs.Close();
            }
        }

        private void Calc_btn_Click(object sender, EventArgs e)
        {
            //获取DataGridView控件中的数据的行数
            int rows_count = Get_Parameter_dgv.Rows.Count - 1;//因为最后一行为空，所以实际有效行数要减去1

            switch (Coordinate_System)
            {
                case Ellipsoid_Transfer_Form.GCS://大地坐标系
                    break;
                case Ellipsoid_Transfer_Form.SRCS:
                    var dX = new DenseVector(7);//待求转换参数向量δX
                    var B = new DenseMatrix(rows_count * 3, 7);//系数阵
                    var L = new DenseVector(rows_count * 3);//已知值向量
                    var P = DenseMatrix.CreateIdentity(rows_count * 3);//权阵，设为单位阵

                    //读取坐标值
                    for (int i = 0; i < rows_count - 1; i++)//每个点三个方程
                    {
                        Coordinate_System_Transfer.Coordinate_Value cv = new Coordinate_System_Transfer.Coordinate_Value();
                        var b =new DenseMatrix(3, 7);

                        cv.X = Convert.ToDouble(Get_Parameter_dgv.Rows[i].Cells[0].Value.ToString());
                        cv.Y = Convert.ToDouble(Get_Parameter_dgv.Rows[i].Cells[1].Value.ToString());
                        cv.Z = Convert.ToDouble(Get_Parameter_dgv.Rows[i].Cells[2].Value.ToString());
                        b = Get_Matrix_B(cv);
                        B.SetSubMatrix(3 * i, 0, b);//把b插入B中
                        
                        L[3 * i + 0] = Convert.ToDouble(Get_Parameter_dgv.Rows[i].Cells[3].Value.ToString());//X2
                        L[3 * i + 1] = Convert.ToDouble(Get_Parameter_dgv.Rows[i].Cells[4].Value.ToString());//Y2
                        L[3 * i + 2] = Convert.ToDouble(Get_Parameter_dgv.Rows[i].Cells[5].Value.ToString());//Z2
                    }

                    //法方程求解
                    dX = (DenseVector)((B.Transpose() * B).Inverse() * B.Transpose() * L);//此为化简后的公式，原公式为:

                    //对全局变量赋值
                    Ellipsoid_Transfer_Form.dXo = dX[0];
                    Ellipsoid_Transfer_Form.dYo = dX[1];
                    Ellipsoid_Transfer_Form.dZo = dX[2];
                    Ellipsoid_Transfer_Form.m = dX[3] - 1;
                    Ellipsoid_Transfer_Form.eX = dX[4] / dX[3];
                    Ellipsoid_Transfer_Form.eY = dX[5] / dX[3];
                    Ellipsoid_Transfer_Form.eZ = dX[6] / dX[3];
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
        /// <param name="cv"></param>
        /// <returns></returns>
        public static DenseMatrix Get_Matrix_B(Coordinate_System_Transfer.Coordinate_Value cv)
        {
            DenseMatrix B = new DenseMatrix(3, 7);
            var I = DenseMatrix.CreateIdentity(3);
            var b = new DenseMatrix(3, 4);
            b[0, 0] = cv.X;
            b[0, 2] = -cv.Z;
            b[0, 3] = cv.Y;
            b[1, 0] = cv.Y;
            b[1, 1] = cv.Z;
            b[1, 3] = -cv.X;
            b[2, 0] = cv.Z;
            b[2, 1] = -cv.Y;
            b[2, 2] = cv.X;
            B.SetSubMatrix(0, 0, I);
            B.SetSubMatrix(0, 3, b);

            return B;
        }
        
    }
}
