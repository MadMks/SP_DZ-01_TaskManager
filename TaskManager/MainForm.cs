using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
        private List<ListViewItem> listViewItems = null;

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
            AppManageForm appManageForm = new AppManageForm(true);
            appManageForm.Show();
        }

        private void endProcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppManageForm appManageForm = new AppManageForm(false);
            appManageForm.Show();
        }
    }
}
