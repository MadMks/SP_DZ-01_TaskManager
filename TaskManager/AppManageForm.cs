using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class AppManageForm : Form
    {
        public AppManageForm()
        {
            InitializeComponent();
        }

        public AppManageForm(bool isStart)
        {
            InitializeComponent();
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
    }
}
