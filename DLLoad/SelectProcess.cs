using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLLoad
{
    public partial class SelectProcess : Form
    {
        public Process selectedProcess { get; set; }

        public SelectProcess()
        {
            InitializeComponent();
        }

        private void SelectProcess_Load(object sender, EventArgs e)
        {
            Process[] processCollection = Process.GetProcesses();
            foreach (Process process in processCollection)
            {
                ListViewItem item = new ListViewItem(process.Id.ToString());
                item.UseItemStyleForSubItems = false;
                item.Tag = process;
                item.SubItems.Add(process.ProcessName);

                string windowTitle = process.MainWindowTitle;
                if (windowTitle != "")
                    item.SubItems.Add(windowTitle);
                else
                    item.SubItems.Add("none", Color.Gray, Color.White, DefaultFont);

                lvProcessesList.Items.Add(item);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.selectedProcess = (Process)lvProcessesList.SelectedItems[0].Tag;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
