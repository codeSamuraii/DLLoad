using System.Diagnostics;

namespace DLLoad
{
    public partial class MainForm : Form
    {
        private Process selectedProcess;
        private string selectedDll;

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

        private void btnBrowseDll_Click(object sender, EventArgs e)
        {
            var dialogResult = openDllFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
                selectedDll = openDllFileDialog.FileName;
            else
                return;

            tbDllPath.Text = openDllFileDialog.FileName;
        }

        private void btnInject_Click(object sender, EventArgs e)
        {
            BasicInject.Inject(selectedProcess, selectedDll);
        }
    }
}