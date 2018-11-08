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


        public AppManageForm()
        {
            InitializeComponent();
        }

        public AppManageForm(bool isStart)
        {
            InitializeComponent();

            this.ShowWindowName(isStart);
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
