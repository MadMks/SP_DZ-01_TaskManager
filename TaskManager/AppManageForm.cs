using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private bool isStart;

        public AppManageForm()
        {
            InitializeComponent();
        }

        public AppManageForm(bool isStart)
        {
            InitializeComponent();

            this.isStart = isStart;
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
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // TODO запуск
            TimerCallback timerCallback = null;

            if (this.isStart)
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

            MessageBox.Show("запуск таймера");
            this.Close();
        }

        private void StartProgram(object pathFile)
        {
            // TODO запуск процесса.
            // TODO запуск потока Лог
        }

        private void EndProgram(object pathFile)
        {
            // TODO завершение процесса.
            // TODO запуск потока Лог
        }
    }
}
