namespace Task_List
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.txtSave = new System.Windows.Forms.ToolStripMenuItem();
            this.txtOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTask = new System.Windows.Forms.ToolStripDropDownButton();
            this.txtDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTasks = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkTask = new System.Windows.Forms.CheckedListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFile,
            this.btnTask,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(364, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnFile
            // 
            this.btnFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtSave,
            this.txtOpen});
            this.btnFile.Image = ((System.Drawing.Image)(resources.GetObject("btnFile.Image")));
            this.btnFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFile.Name = "btnFile";
            this.btnFile.ShowDropDownArrow = false;
            this.btnFile.Size = new System.Drawing.Size(41, 22);
            this.btnFile.Text = "  File  ";
            this.btnFile.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSave
            // 
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(180, 22);
            this.txtSave.Text = "Save";
            // 
            // txtOpen
            // 
            this.txtOpen.Name = "txtOpen";
            this.txtOpen.Size = new System.Drawing.Size(180, 22);
            this.txtOpen.Text = "Open";
            this.txtOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnTask
            // 
            this.btnTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnTask.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtDelete,
            this.txtAdd});
            this.btnTask.Image = ((System.Drawing.Image)(resources.GetObject("btnTask.Image")));
            this.btnTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTask.Name = "btnTask";
            this.btnTask.ShowDropDownArrow = false;
            this.btnTask.Size = new System.Drawing.Size(46, 22);
            this.btnTask.Text = "  Task  ";
            // 
            // txtDelete
            // 
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(180, 22);
            this.txtDelete.Text = "Delete";
            this.txtDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(180, 22);
            this.txtAdd.Text = "Add";
            this.txtAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 22);
            this.btnExit.Text = "  Exit  ";
            this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Things To Do";
            // 
            // txtTasks
            // 
            this.txtTasks.Location = new System.Drawing.Point(55, 269);
            this.txtTasks.Name = "txtTasks";
            this.txtTasks.Size = new System.Drawing.Size(149, 20);
            this.txtTasks.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(252, 69);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(58, 25);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(252, 110);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(58, 25);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(252, 204);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 25);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(252, 264);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(58, 25);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(294, 333);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(58, 25);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkTask
            // 
            this.chkTask.CheckOnClick = true;
            this.chkTask.FormattingEnabled = true;
            this.chkTask.Location = new System.Drawing.Point(55, 69);
            this.chkTask.Name = "chkTask";
            this.chkTask.Size = new System.Drawing.Size(149, 169);
            this.chkTask.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 370);
            this.Controls.Add(this.chkTask);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtTasks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel btnExit;
        private System.Windows.Forms.ToolStripDropDownButton btnFile;
        private System.Windows.Forms.ToolStripMenuItem txtOpen;
        private System.Windows.Forms.ToolStripMenuItem txtSave;
        private System.Windows.Forms.ToolStripDropDownButton btnTask;
        private System.Windows.Forms.ToolStripMenuItem txtDelete;
        private System.Windows.Forms.ToolStripMenuItem txtAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTasks;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckedListBox chkTask;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

