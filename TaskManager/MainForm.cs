﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace TaskManager
{
    public partial class MainForm : Form
    {
        class Logging
        {
            public EnumOfLogRecords State { get; set; }
            public string Name { get; set; }
        }

        const string file_Path = "log.txt";

        private List<ListViewItem> listViewItems = null;

        private AppManageForm appManageForm = null;

        private ParameterizedThreadStart paramThreadStart = null;
        //private Thread thread = null;

        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.paramThreadStart
                = new ParameterizedThreadStart(WritingLogsToFile);
            //this.thread = new Thread(paramThreadStart);

            this.listViewActiveProcesses.View = View.Details;

            this.listViewActiveProcesses.Columns.Add("Имя процесса", 140);
            this.listViewActiveProcesses.Columns.Add("ID", 40);
            this.listViewActiveProcesses.Columns.Add("Память", 100);
            
            listViewItems = new List<ListViewItem>();

            this.ShowActiveProcesses();

            //TimerCallback timerCallback = new TimerCallback(this.ShowActiveProcesses);
            //Timer timer = new Timer(timerCallback);
            //timer.Change(0, 3000);
        }

        private void ShowActiveProcesses()
        {
            this.listViewActiveProcesses.Items.Clear();
            this.listViewItems.Clear();

            Process[] processes = Process.GetProcesses();

            foreach (Process process in Process.GetProcesses())
            {
                listViewItems.Add(
                    new ListViewItem(
                        new string[] {
                                process.ProcessName,
                                process.Id.ToString(),
                                process.VirtualMemorySize64.ToString("0,0,0", CultureInfo.InvariantCulture)
                            }
                    )
                );
            }

            this.listViewActiveProcesses.Items.AddRange(listViewItems.ToArray());

            this.toolStripStatusCountProcess.Text = "Процессов: " + listViewItems.Count;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.ShowActiveProcesses();
        }

        private void startProcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowTimeSetting(true);
        }

        private void endProcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowTimeSetting(false);
        }

        private void ShowTimeSetting(bool isStart)
        {
            appManageForm = new AppManageForm(isStart);
            DialogResult result = appManageForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                TimerCallback timerCallback = null;

                if (isStart)
                {
                    // запуск таймера с методом старт
                    timerCallback = new TimerCallback(this.StartProgram);
                }
                else
                {
                    // запуск таймера с методом енд
                    timerCallback = new TimerCallback(this.EndProgram);
                }

                Timer timer = new Timer(timerCallback);

                timer.Change(0, 0); // TODO mlsec
            }
        }

        private void StartProgram(object a)
        {
            Process process = null;

            try
            {
                process = new Process();
                process.StartInfo.FileName = appManageForm.ProgramName;
                process.Start();

                this.StartLoggingStream(EnumOfLogRecords.Start, process.StartInfo.FileName);
                //this.WritingLogsToFile(EnumOfLogRecords.Start, process.StartInfo.FileName);
            }
            catch (Exception ex)
            {
                this.StartLoggingStream(EnumOfLogRecords.Error, ex.Message 
                    + " \""
                    + process.StartInfo.FileName
                    + "\"");
            }
        }

        private void EndProgram(object a)
        {
            try
            {
                string processName
                    = Path.GetFileNameWithoutExtension(appManageForm.ProgramName);

                Process[] processes = Process.GetProcessesByName(processName);

                if (processes.Count() == 0)
                {
                    throw new Exception("Не удается найти указанный файл");
                }

                foreach (Process process in processes)
                {
                    process.CloseMainWindow();
                    process.Close();

                    this.StartLoggingStream(EnumOfLogRecords.End, appManageForm.ProgramName);
                    //this.WritingLogsToFile(EnumOfLogRecords.End, appManageForm.ProgramName);
                }
            }
            catch (Exception ex)
            {
                this.StartLoggingStream(EnumOfLogRecords.Error, ex.Message
                    + " \""
                    + appManageForm.ProgramName
                    + "\"");
            }
        }

        private void StartLoggingStream(EnumOfLogRecords state, string name)
        {
            try
            {
                Thread thread = new Thread(WritingLogsToFile);

                Logging logging = new Logging
                {
                    State = state,
                    Name = name
                };

                thread.Start(logging);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void WritingLogsToFile(object log)
        {
            Logging logging = log as Logging;

            FileStream fileStream = null;
            StreamWriter streamWriter = null;
            try
            {
                fileStream = new FileStream(file_Path, FileMode.Append);

                streamWriter = new StreamWriter(fileStream, Encoding.Unicode);


                if (logging.State == EnumOfLogRecords.Start)
                {
                    streamWriter.WriteLine("Старт программы > " + logging.Name);
                }
                else if (logging.State == EnumOfLogRecords.End)
                {
                    streamWriter.WriteLine("Завершение программы > " + logging.Name);
                }
                else if (logging.State == EnumOfLogRecords.Error)
                {
                    streamWriter.WriteLine("[ error ] " + logging.Name);
                }
            }
            catch (Exception ex)
            {
                streamWriter.WriteLine("[ error ] " + ex.Message);
            }
            finally
            {
                streamWriter?.Close();
                fileStream?.Close();
            }
        }
    }
}
