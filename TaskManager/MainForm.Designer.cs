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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusCountProcess = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewActiveProcesses
            // 
            this.listViewActiveProcesses.Location = new System.Drawing.Point(12, 51);
            this.listViewActiveProcesses.Name = "listViewActiveProcesses";
            this.listViewActiveProcesses.Size = new System.Drawing.Size(539, 221);
            this.listViewActiveProcesses.TabIndex = 0;
            this.listViewActiveProcesses.UseCompatibleStateImageBehavior = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(476, 22);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusCountProcess});
            this.statusStrip1.Location = new System.Drawing.Point(0, 278);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(563, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusCountProcess
            // 
            this.toolStripStatusCountProcess.Name = "toolStripStatusCountProcess";
            this.toolStripStatusCountProcess.Size = new System.Drawing.Size(103, 17);
            this.toolStripStatusCountProcess.Text = "toolStripStatusLabel";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 300);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.listViewActiveProcesses);
            this.Name = "MainForm";
            this.Text = "Task Manager";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewActiveProcesses;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusCountProcess;
    }
}

