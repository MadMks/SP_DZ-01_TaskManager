using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace TaskManager
{
    public partial class AppManageForm : Form
    {
        //private bool isStart;
        

        public string ProgramName
        {
            get { return this.textBoxNameOrPathProgram.Text; }
        }
        //public string ProcessName
        //{
        //    get
        //    {
        //        string closeProcessName = "";
        //        Uri uri = new Uri(this.textBoxNameOrPathProgram.Text);

        //        if (uri.IsFile)
        //        {
        //            closeProcessName = Path.GetFileNameWithoutExtension(uri.LocalPath);
        //        }
        //        else
        //        {
        //            closeProcessName = this.textBoxNameOrPathProgram.Text;
        //        }
        //        return closeProcessName;
        //    }
        //}

        public AppManageForm()
        {
            InitializeComponent();
        }

        public AppManageForm(bool isStart)
        {
            InitializeComponent();

            //this.isStart = isStart;
        }

        private void buttonOverview_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выберите файл программы";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.textBoxNameOrPathProgram.Text = openFileDialog.FileName;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // TODO запуск
            //TimerCallback timerCallback = null;

            //if (this.isStart)
            //{
            //    // запуск таймера с методом старт
            //    timerCallback = new TimerCallback(this.StartProgram);
            //}
            //else
            //{
            //    // запуск таймера с методом енд
            //    timerCallback = new TimerCallback(this.EndProgram);
            //}

            //Timer timer = new Timer(timerCallback);
            
            //timer.Change(0, 0); // TODO mlsec

            //MessageBox.Show("запуск таймера");
            this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        //private void StartProgram(object pathFile)
        //{
        //    // TODO запуск процесса.
        //    Process process = new Process();
        //    process.StartInfo.FileName = this.textBoxNameOrPathProgram.Text;
        //    process.Start();
        //    // TODO запуск потока Лог
        //}

        //private void EndProgram(object pathFile)
        //{
        //    // TODO завершение процесса.
        //    //Process proc = new Process();
        //    //proc.StartInfo.FileName = this.textBoxNameOrPathProgram.Text;
            

        //    //string closeProcessName = "";
        //    //Uri uri = new Uri(this.textBoxNameOrPathProgram.Text);

        //    //if (uri.IsFile)
        //    //{
        //    //    //closeProcessName = Path.GetFileName(uri.LocalPath);
        //    //    closeProcessName = Path.GetFileNameWithoutExtension(uri.LocalPath);
        //    //}
        //    //else
        //    //{
        //    //    closeProcessName = this.textBoxNameOrPathProgram.Text;
        //    //}


        //    Process[] processes = Process.GetProcesses();

        //    foreach (Process process in processes)
        //    {
        //        if (process.ProcessName == closeProcessName)
        //        {
        //            process.CloseMainWindow();
        //            process.Close();
        //        }
                
        //    }
        //    // TODO запуск потока Лог
        //}
    }
}
