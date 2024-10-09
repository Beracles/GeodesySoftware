using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace 坐标系转换
{
    public static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            if (args.Length == 0)             //如果参数数组长度为0，说明是从外部启动，提示警告
                MessageBox.Show("无法从外部启动程序", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //管理进程使只能启动一个
            Process pro = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(pro.ProcessName);
            if (processes.Length >= 2)
            {
                MessageBox.Show("已经在运行！请不要反复启动！", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pro.Kill();
            }


            else if (args[0] == "MainForm") //当传入的参数列表非空，且参数为"MainForm"时，表示是由主窗口启动的，可以启动
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Coordinate_Transfer_Form());
            }
        }
    }
    
}
