using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroApp
{
    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = new JsonRW<Stats>(Properties.Settings.Default.jsonFileLocation).OpenFileJson(new List<Stats>());
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fileStream = File.Open(Properties.Settings.Default.jsonFileLocation, FileMode.Open);
                fileStream.SetLength(0);
                fileStream.Close();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"File {ex.FileName} not found!");
            }
            catch (IOException ex)
            {
                MessageBox.Show(
                    $"{ex.GetType().Name}: The write operation could not " +
                    "be performed because the specified " +
                    "part of the file is locked.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
