namespace DLLoad
{
    partial class SelectProcess
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
            this.lvProcessesList = new System.Windows.Forms.ListView();
            this.chProcessId = new System.Windows.Forms.ColumnHeader();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chPath = new System.Windows.Forms.ColumnHeader();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvProcessesList
            // 
            this.lvProcessesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProcessId,
            this.chName,
            this.chPath});
            this.lvProcessesList.FullRowSelect = true;
            this.lvProcessesList.GridLines = true;
            this.lvProcessesList.Location = new System.Drawing.Point(12, 12);
            this.lvProcessesList.Name = "lvProcessesList";
            this.lvProcessesList.Size = new System.Drawing.Size(721, 577);
            this.lvProcessesList.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvProcessesList.TabIndex = 1;
            this.lvProcessesList.UseCompatibleStateImageBehavior = false;
            this.lvProcessesList.View = System.Windows.Forms.View.Details;
            // 
            // chProcessId
            // 
            this.chProcessId.Text = "#";
            this.chProcessId.Width = 100;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 310;
            // 
            // chPath
            // 
            this.chPath.Text = "Window Title";
            this.chPath.Width = 307;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(195, 595);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(346, 34);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // SelectProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 643);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lvProcessesList);
            this.Name = "SelectProcess";
            this.Text = "Select a process";
            this.Load += new System.EventHandler(this.SelectProcess_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvProcessesList;
        private ColumnHeader chProcessId;
        private ColumnHeader chName;
        private ColumnHeader chPath;
        private Button btnOk;
    }
}