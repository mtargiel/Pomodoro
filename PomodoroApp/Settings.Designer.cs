namespace PomodoroApp
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.setTimeOfBreak = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.workTimeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // setTimeOfBreak
            // 
            this.setTimeOfBreak.FormattingEnabled = true;
            this.setTimeOfBreak.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.setTimeOfBreak.Location = new System.Drawing.Point(12, 25);
            this.setTimeOfBreak.Name = "setTimeOfBreak";
            this.setTimeOfBreak.Size = new System.Drawing.Size(63, 21);
            this.setTimeOfBreak.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 118);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // workTimeBox
            // 
            this.workTimeBox.FormattingEnabled = true;
            this.workTimeBox.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.workTimeBox.Location = new System.Drawing.Point(12, 80);
            this.workTimeBox.Name = "workTimeBox";
            this.workTimeBox.Size = new System.Drawing.Size(63, 21);
            this.workTimeBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Przerwa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Czas pracy";
            // 
            // Settings
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 155);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workTimeBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.setTimeOfBreak);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox setTimeOfBreak;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox workTimeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}