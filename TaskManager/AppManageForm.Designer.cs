namespace TaskManager
{
    partial class AppManageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSelectDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.labelNameOrPathProgram = new System.Windows.Forms.Label();
            this.textBoxNameOrPathProgram = new System.Windows.Forms.TextBox();
            this.buttonOverview = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelSelectTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSelectDate
            // 
            this.labelSelectDate.AutoSize = true;
            this.labelSelectDate.Location = new System.Drawing.Point(14, 77);
            this.labelSelectDate.Name = "labelSelectDate";
            this.labelSelectDate.Size = new System.Drawing.Size(79, 13);
            this.labelSelectDate.TabIndex = 0;
            this.labelSelectDate.Text = "Выбрать дату";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(15, 98);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerDate.TabIndex = 1;
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(222, 98);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerTime.TabIndex = 2;
            // 
            // labelNameOrPathProgram
            // 
            this.labelNameOrPathProgram.AutoSize = true;
            this.labelNameOrPathProgram.Location = new System.Drawing.Point(15, 18);
            this.labelNameOrPathProgram.Name = "labelNameOrPathProgram";
            this.labelNameOrPathProgram.Size = new System.Drawing.Size(161, 13);
            this.labelNameOrPathProgram.TabIndex = 3;
            this.labelNameOrPathProgram.Text = "Введите имя/путь программы:";
            // 
            // textBoxNameOrPathProgram
            // 
            this.textBoxNameOrPathProgram.Location = new System.Drawing.Point(15, 40);
            this.textBoxNameOrPathProgram.Name = "textBoxNameOrPathProgram";
            this.textBoxNameOrPathProgram.Size = new System.Drawing.Size(318, 21);
            this.textBoxNameOrPathProgram.TabIndex = 4;
            // 
            // buttonOverview
            // 
            this.buttonOverview.Location = new System.Drawing.Point(347, 40);
            this.buttonOverview.Name = "buttonOverview";
            this.buttonOverview.Size = new System.Drawing.Size(75, 23);
            this.buttonOverview.TabIndex = 5;
            this.buttonOverview.Text = "Обзор";
            this.buttonOverview.UseVisualStyleBackColor = true;
            this.buttonOverview.Click += new System.EventHandler(this.buttonOverview_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(258, 149);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(347, 149);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelSelectTime
            // 
            this.labelSelectTime.AutoSize = true;
            this.labelSelectTime.Location = new System.Drawing.Point(221, 77);
            this.labelSelectTime.Name = "labelSelectTime";
            this.labelSelectTime.Size = new System.Drawing.Size(84, 13);
            this.labelSelectTime.TabIndex = 8;
            this.labelSelectTime.Text = "Выбрать время";
            // 
            // AppManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 187);
            this.Controls.Add(this.labelSelectTime);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOverview);
            this.Controls.Add(this.textBoxNameOrPathProgram);
            this.Controls.Add(this.labelNameOrPathProgram);
            this.Controls.Add(this.dateTimePickerTime);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelSelectDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppManageForm";
            this.Text = "AppManageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.Label labelNameOrPathProgram;
        private System.Windows.Forms.TextBox textBoxNameOrPathProgram;
        private System.Windows.Forms.Button buttonOverview;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelSelectTime;
    }
}