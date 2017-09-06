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
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cyclesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingMinutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breakMinutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortBreakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cyclesDataGridViewTextBoxColumn,
            this.workingMinutesDataGridViewTextBoxColumn,
            this.breakMinutesDataGridViewTextBoxColumn,
            this.shortBreakDataGridViewTextBoxColumn,
            this.dateOfWork});
            this.dataGridView1.DataSource = this.statsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(540, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // statsBindingSource
            // 
            this.statsBindingSource.DataSource = typeof(PomodoroApp.Stats);
            // 
            // settingsBindingSource
            // 
            this.settingsBindingSource.DataSource = typeof(PomodoroApp.Settings);
            // 
            // cyclesDataGridViewTextBoxColumn
            // 
            this.cyclesDataGridViewTextBoxColumn.DataPropertyName = "Cycles";
            this.cyclesDataGridViewTextBoxColumn.HeaderText = "Cykle";
            this.cyclesDataGridViewTextBoxColumn.Name = "cyclesDataGridViewTextBoxColumn";
            this.cyclesDataGridViewTextBoxColumn.ReadOnly = true;
            this.cyclesDataGridViewTextBoxColumn.Width = 58;
            // 
            // workingMinutesDataGridViewTextBoxColumn
            // 
            this.workingMinutesDataGridViewTextBoxColumn.DataPropertyName = "WorkingMinutes";
            this.workingMinutesDataGridViewTextBoxColumn.HeaderText = "Minut pracy";
            this.workingMinutesDataGridViewTextBoxColumn.Name = "workingMinutesDataGridViewTextBoxColumn";
            this.workingMinutesDataGridViewTextBoxColumn.ReadOnly = true;
            this.workingMinutesDataGridViewTextBoxColumn.Width = 87;
            // 
            // breakMinutesDataGridViewTextBoxColumn
            // 
            this.breakMinutesDataGridViewTextBoxColumn.DataPropertyName = "BreakMinutes";
            this.breakMinutesDataGridViewTextBoxColumn.HeaderText = "Minut długich przerw";
            this.breakMinutesDataGridViewTextBoxColumn.Name = "breakMinutesDataGridViewTextBoxColumn";
            this.breakMinutesDataGridViewTextBoxColumn.ReadOnly = true;
            this.breakMinutesDataGridViewTextBoxColumn.Width = 131;
            // 
            // shortBreakDataGridViewTextBoxColumn
            // 
            this.shortBreakDataGridViewTextBoxColumn.DataPropertyName = "ShortBreak";
            this.shortBreakDataGridViewTextBoxColumn.HeaderText = "Ilość krótkich przerw";
            this.shortBreakDataGridViewTextBoxColumn.Name = "shortBreakDataGridViewTextBoxColumn";
            this.shortBreakDataGridViewTextBoxColumn.ReadOnly = true;
            this.shortBreakDataGridViewTextBoxColumn.Width = 129;
            // 
            // dateOfWork
            // 
            this.dateOfWork.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dateOfWork.DataPropertyName = "dateOfWork";
            this.dateOfWork.HeaderText = "Data";
            this.dateOfWork.Name = "dateOfWork";
            this.dateOfWork.ReadOnly = true;
            this.dateOfWork.Width = 55;
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StatsForm";
            this.Text = "Stats";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource settingsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource statsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cyclesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingMinutesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breakMinutesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortBreakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfWork;
    }
}