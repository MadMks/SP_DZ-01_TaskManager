namespace TaskManager
{
    partial class MainForm
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
            this.listViewActiveProcesses = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewActiveProcesses
            // 
            this.listViewActiveProcesses.Location = new System.Drawing.Point(12, 51);
            this.listViewActiveProcesses.Name = "listViewActiveProcesses";
            this.listViewActiveProcesses.Size = new System.Drawing.Size(419, 237);
            this.listViewActiveProcesses.TabIndex = 0;
            this.listViewActiveProcesses.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.listViewActiveProcesses);
            this.Name = "MainForm";
            this.Text = "Task Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewActiveProcesses;
    }
}

