using System;
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
        const string file_Path = "log.txt";

        private EnumOfLogRecords nameLog = EnumOfLogRecords.Error;

        private List<ListViewItem> listViewItems = null;

        private AppManageForm appManageForm = null;

        public MainForm()
        {
            InitializeComponent();

            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
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
            // TODO запуск процесса.
            Process process = new Process();
            process.StartInfo.FileName = appManageForm.ProgramName;
            process.Start();

            this.WritingLogsToFile(EnumOfLogRecords.Start, process.StartInfo.FileName);
        }

        private void EndProgram(object a)
        {
            string processName
                = Path.GetFileNameWithoutExtension(appManageForm.ProgramName);

            Process[] processes = Process.GetProcessesByName(processName);

            foreach (Process process in processes)
            {
                process.CloseMainWindow();
                process.Close();

                this.WritingLogsToFile(EnumOfLogRecords.End, appManageForm.ProgramName);
            }
        }

        private void WritingLogsToFile(EnumOfLogRecords log, string name)
        {
            FileStream fileStream = null;
            StreamWriter streamWriter = null;
            try
            {
                fileStream = new FileStream(file_Path, FileMode.Append);

                streamWriter = new StreamWriter(fileStream, Encoding.Unicode);


                if (log == EnumOfLogRecords.Start)
                {
                    streamWriter.WriteLine("Старт программы > " + name);
                }
                else if (log == EnumOfLogRecords.End)
                {
                    streamWriter.WriteLine("Завершение программы > " + name);
                }
                else if (log == EnumOfLogRecords.Error)
                {
                    streamWriter.WriteLine("[ error ] " + name);
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
