using System;
using System.IO;
using System.Windows.Forms;

namespace Task_List
{
    public partial class Form1 : Form
    {
        private string fileName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            chkTask.Items.Add(txtTasks.Text);
            txtTasks.Text = "";
            txtTasks.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var task = chkTask.CheckedItems;
            while (task.Count > 0)
            {
                chkTask.Items.Remove(task[0]);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (fileName != "")
            {
                //Save
                File.Delete(fileName);
                FileStream fs = File.Open(fileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                foreach (var tasks in chkTask.Items)
                {
                    sw.WriteLine(tasks);
                }

                sw.Close();
            }
            else
            {
                //Save as
                saveFileDialog1.Filter = "Text Files | *.txt | All Files | *.";
                DialogResult result = saveFileDialog1.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    foreach (var tasks in chkTask.Items)
                    {
                        sw.WriteLine(tasks);
                    }

                    sw.Close();
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files | *.txt";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                chkTask.Items.Clear();
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                fileName = openFileDialog1.FileName;
                string line;
                while ((line = sr.ReadLine()) != null)
                {

                    chkTask.Items.Add(line);
                }

                sr.Close();
            }
        }
    }
}
