using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseSwitcher
{
    public partial class ErrorReport : Form
    {
        public static void ReportError(Exception err)
        {
            var window = new ErrorReport();
            window.texts.AppendText("程序遇到了错误。向开发者提供下面的信息有助于诊断和修复这个错误。\n");
            window.texts.AppendText("这些信息仅与程序代码相关，通常不会包含关于您或您计算机的信息。\n");
            window.texts.AppendText("------------------------\n");
            window.texts.AppendText(err.Message + "\n");
            window.texts.AppendText(err.StackTrace);
            window.ShowDialog();
        }

        public ErrorReport()
        {
            InitializeComponent();
        }
    }
}
