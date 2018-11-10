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

namespace TaskManager
{
    public partial class AppManageForm : Form
    {
        public string ProgramName
        {
            get { return this.textBoxNameOrPathProgram.Text; }
        }

        public DateTime DateAndTime
        {
            get {
                return new DateTime(
                  this.dateTimePickerDate.Value.Year,
                  this.dateTimePickerDate.Value.Month,
                  this.dateTimePickerDate.Value.Day,
                  this.dateTimePickerTime.Value.Hour,
                  this.dateTimePickerTime.Value.Minute,
                  this.dateTimePickerTime.Value.Second);
            }
        }


        public AppManageForm()
        {
            InitializeComponent();
        }

        public AppManageForm(bool isStart)
        {
            InitializeComponent();

            this.Load += AppManageForm_Load;

            this.ShowWindowName(isStart);
        }

        private void AppManageForm_Load(object sender, EventArgs e)
        {
            this.dateTimePickerDate.MinDate = DateTime.Now;
        }

        private void ShowWindowName(bool isStart)
        {
            if (isStart)
            {
                this.Text = "Настройка запуска программы";
            }
            else
            {
                this.Text = "Настройка завершения программы";
            }
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
            this.DialogResult = DialogResult.OK;
        }
    }
}
