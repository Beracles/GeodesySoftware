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
    public partial class Search_Parameter_Form : Form
    {
        public Search_Parameter_Form()
        {
            InitializeComponent();

            //显示结果
            Coordinate_System_txtBx.Text = Ellipsoid_Transfer_Form.coordinate_systems[Ellipsoid_Transfer_Form.Coordinate_System];
            Known_Ellipsoid_txtBx.Text = Setting.Ellipsoids[Ellipsoid_Transfer_Form.Known_Ellipsoid];
            Target_Ellipsoid_txtBx.Text = Setting.Ellipsoids[Ellipsoid_Transfer_Form.Target_Ellipsoid];
            dXo_txtBx.Text = Ellipsoid_Transfer_Form.dXo.ToString();
            dYo_txtBx.Text = Ellipsoid_Transfer_Form.dYo.ToString();
            dZo_txtBx.Text = Ellipsoid_Transfer_Form.dZo.ToString();
            m_txtBx.Text = Ellipsoid_Transfer_Form.m.ToString();
            eX_txtBx.Text = Ellipsoid_Transfer_Form.eX.ToString();
            eY_txtBx.Text = Ellipsoid_Transfer_Form.eY.ToString();
            eZ_txtBx.Text = Ellipsoid_Transfer_Form.eZ.ToString();

            Common_Points_dgv.DataSource = Ellipsoid_Transfer_Form.Common_Points;//设置公共点数据表的数据源s
            //设置表的列宽
            for(int i = 0; i < Common_Points_dgv.Columns.Count; i++)
            {
                Common_Points_dgv.Columns[i].Width = Common_Points_dgv.Width / Common_Points_dgv.Columns.Count;
            }
            
            //大地坐标系时显示
            if(Ellipsoid_Transfer_Form.Coordinate_System == Ellipsoid_Transfer_Form.GCS)
            {
                da_lbl.Visible = true;
                da_txtBx.Visible = true;
                daf_lbl.Visible = true;
                daf_txtBx.Visible = true;

                da_txtBx.Text = Ellipsoid_Transfer_Form.da.ToString();
                daf_txtBx.Text = Ellipsoid_Transfer_Form.daf.ToString();
            }
            else//空间直角坐标系时隐藏
            {
                da_lbl.Visible = false;
                da_txtBx.Visible = false;
                daf_lbl.Visible = false;
                daf_txtBx.Visible = false;
            }

        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_Parameter_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Ellipsoid_Transfer_Form.form = null;
        }

        private void Search_Parameter_Form_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
