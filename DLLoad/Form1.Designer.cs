namespace DLLoad
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProcessName = new System.Windows.Forms.TextBox();
            this.tbProcessID = new System.Windows.Forms.TextBox();
            this.btnBrowseProcesses = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDllPath = new System.Windows.Forms.TextBox();
            this.btnBrowseDll = new System.Windows.Forms.Button();
            this.btnInject = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbActivity = new System.Windows.Forms.ListBox();
            this.ilIcons = new System.Windows.Forms.ImageList(this.components);
            this.openDllFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process :";
            // 
            // tbProcessName
            // 
            this.tbProcessName.Enabled = false;
            this.tbProcessName.Location = new System.Drawing.Point(99, 6);
            this.tbProcessName.Name = "tbProcessName";
            this.tbProcessName.Size = new System.Drawing.Size(243, 31);
            this.tbProcessName.TabIndex = 1;
            // 
            // tbProcessID
            // 
            this.tbProcessID.Enabled = false;
            this.tbProcessID.Location = new System.Drawing.Point(348, 6);
            this.tbProcessID.Name = "tbProcessID";
            this.tbProcessID.Size = new System.Drawing.Size(95, 31);
            this.tbProcessID.TabIndex = 2;
            // 
            // btnBrowseProcesses
            // 
            this.btnBrowseProcesses.Location = new System.Drawing.Point(449, 4);
            this.btnBrowseProcesses.Name = "btnBrowseProcesses";
            this.btnBrowseProcesses.Size = new System.Drawing.Size(65, 34);
            this.btnBrowseProcesses.TabIndex = 3;
            this.btnBrowseProcesses.Text = "...";
            this.btnBrowseProcesses.UseVisualStyleBackColor = true;
            this.btnBrowseProcesses.Click += new System.EventHandler(this.btnBrowseProcesses_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "DLL :";
            // 
            // tbDllPath
            // 
            this.tbDllPath.Enabled = false;
            this.tbDllPath.Location = new System.Drawing.Point(99, 46);
            this.tbDllPath.Name = "tbDllPath";
            this.tbDllPath.Size = new System.Drawing.Size(344, 31);
            this.tbDllPath.TabIndex = 5;
            // 
            // btnBrowseDll
            // 
            this.btnBrowseDll.Location = new System.Drawing.Point(449, 44);
            this.btnBrowseDll.Name = "btnBrowseDll";
            this.btnBrowseDll.Size = new System.Drawing.Size(65, 34);
            this.btnBrowseDll.TabIndex = 6;
            this.btnBrowseDll.Text = "...";
            this.btnBrowseDll.UseVisualStyleBackColor = true;
            this.btnBrowseDll.Click += new System.EventHandler(this.btnBrowseDll_Click);
            // 
            // btnInject
            // 
            this.btnInject.Location = new System.Drawing.Point(12, 83);
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(502, 34);
            this.btnInject.TabIndex = 7;
            this.btnInject.Text = "Load";
            this.btnInject.UseVisualStyleBackColor = true;
            this.btnInject.Click += new System.EventHandler(this.btnInject_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbActivity);
            this.groupBox1.Location = new System.Drawing.Point(12, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 245);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activity";
            // 
            // lbActivity
            // 
            this.lbActivity.FormattingEnabled = true;
            this.lbActivity.ItemHeight = 25;
            this.lbActivity.Location = new System.Drawing.Point(6, 30);
            this.lbActivity.Name = "lbActivity";
            this.lbActivity.Size = new System.Drawing.Size(490, 204);
            this.lbActivity.TabIndex = 0;
            // 
            // ilIcons
            // 
            this.ilIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilIcons.ImageSize = new System.Drawing.Size(16, 16);
            this.ilIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openDllFileDialog
            // 
            this.openDllFileDialog.DefaultExt = "dll";
            this.openDllFileDialog.Filter = "DLL|*.dll|Any extension|*.*";
            this.openDllFileDialog.Title = "Open DLL";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 374);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInject);
            this.Controls.Add(this.btnBrowseDll);
            this.Controls.Add(this.tbDllPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseProcesses);
            this.Controls.Add(this.tbProcessID);
            this.Controls.Add(this.tbProcessName);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "DLLoad";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbProcessName;
        private TextBox tbProcessID;
        private Button btnBrowseProcesses;
        private Label label2;
        private TextBox tbDllPath;
        private Button btnBrowseDll;
        private Button btnInject;
        private GroupBox groupBox1;
        private ListBox lbActivity;
        private ImageList ilIcons;
        private OpenFileDialog openDllFileDialog;
    }
}