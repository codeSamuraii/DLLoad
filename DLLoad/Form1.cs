using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace DLLoad
{
    public partial class MainForm : Form
    {
        private Process selectedProcess;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbActivity.Items.Add("[*] Program loaded successfully.");
        }

        private void btnBrowseProcesses_Click(object sender, EventArgs e)
        {
            using (var selectProcess = new SelectProcess())
            {
                var dialogResult = selectProcess.ShowDialog();
                if (dialogResult == DialogResult.OK)
                    selectedProcess = selectProcess.selectedProcess;
                else
                    return;
            }

            tbProcessName.Text = selectedProcess.ProcessName;
            tbProcessID.Text = selectedProcess.Id.ToString();
        }
    }
}