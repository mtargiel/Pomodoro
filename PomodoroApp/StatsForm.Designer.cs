namespace PomodoroApp
{
    partial class StatsForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cleanButton = new System.Windows.Forms.Button();
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cyclesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingMinutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breakMinutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfWorkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cyclesDataGridViewTextBoxColumn,
            this.workingMinutesDataGridViewTextBoxColumn,
            this.breakMinutesDataGridViewTextBoxColumn,
            this.dateOfWorkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.statsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(519, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // statsBindingSource
            // 
            this.statsBindingSource.DataSource = typeof(PomodoroApp.Stats);
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(5, 226);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(75, 23);
            this.cleanButton.TabIndex = 1;
            this.cleanButton.Text = "Wyczyść";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // settingsBindingSource
            // 
            this.settingsBindingSource.DataSource = typeof(PomodoroApp.Settings);
            // 
            // cyclesDataGridViewTextBoxColumn
            // 
            this.cyclesDataGridViewTextBoxColumn.DataPropertyName = "Cycles";
            this.cyclesDataGridViewTextBoxColumn.HeaderText = "Pomodoro cycles";
            this.cyclesDataGridViewTextBoxColumn.Name = "cyclesDataGridViewTextBoxColumn";
            this.cyclesDataGridViewTextBoxColumn.ReadOnly = true;
            this.cyclesDataGridViewTextBoxColumn.Width = 113;
            // 
            // workingMinutesDataGridViewTextBoxColumn
            // 
            this.workingMinutesDataGridViewTextBoxColumn.DataPropertyName = "WorkingMinutes";
            this.workingMinutesDataGridViewTextBoxColumn.HeaderText = "Work minutes";
            this.workingMinutesDataGridViewTextBoxColumn.Name = "workingMinutesDataGridViewTextBoxColumn";
            this.workingMinutesDataGridViewTextBoxColumn.ReadOnly = true;
            this.workingMinutesDataGridViewTextBoxColumn.Width = 97;
            // 
            // breakMinutesDataGridViewTextBoxColumn
            // 
            this.breakMinutesDataGridViewTextBoxColumn.DataPropertyName = "BreakMinutes";
            this.breakMinutesDataGridViewTextBoxColumn.HeaderText = "Break minutes";
            this.breakMinutesDataGridViewTextBoxColumn.Name = "breakMinutesDataGridViewTextBoxColumn";
            this.breakMinutesDataGridViewTextBoxColumn.ReadOnly = true;
            this.breakMinutesDataGridViewTextBoxColumn.Width = 99;
            // 
            // dateOfWorkDataGridViewTextBoxColumn
            // 
            this.dateOfWorkDataGridViewTextBoxColumn.DataPropertyName = "DateOfWork";
            this.dateOfWorkDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateOfWorkDataGridViewTextBoxColumn.Name = "dateOfWorkDataGridViewTextBoxColumn";
            this.dateOfWorkDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfWorkDataGridViewTextBoxColumn.Width = 55;
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 261);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StatsForm";
            this.Text = "Statystyki";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource settingsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource statsBindingSource;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn cyclesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingMinutesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breakMinutesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfWorkDataGridViewTextBoxColumn;
    }
}