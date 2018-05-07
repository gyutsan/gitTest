using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            mCheckProcessTimer = new System.Timers.Timer();
            mCheckProcessTimer.Interval = 1000;
            mCheckProcessTimer.Elapsed += checkProcess;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartProcess();

            mCheckProcessTimer.Start();
        }

        public void StartProcess()
        {
            Process tempProcess = Process.Start(@"C:\Users\Yuning Nae\Documents\GitHub\gitTest\WindowsFormsApp1\testWinForms\bin\Debug\testWinForms");
            mProcessId = tempProcess.Id;
            textBox1.AppendText("Process Id : " + mProcessId + Environment.NewLine);
        }

        private void checkProcess(object sendor, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                Process tempProcess = Process.GetProcessById(mProcessId);
                //Process.GetProcessById(mModuleInfoTable[i].moduleProcessId);
                // 함수이름 가져오기 예제
                //txtLog(MethodBase.GetCurrentMethod().Name + "hello~~");
            }
            catch
            {
                textBox1.AppendText(mProcessId + " is dead" + Environment.NewLine);
                StartProcess();
            }
        }

        private System.Timers.Timer mCheckProcessTimer = null;
        private int mProcessId = 0;
    }
}
