using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab02
{
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
            LoadRootDirectories();
            treeView1.AfterExpand += treeView1_AfterExpand;
            treeView1.AfterSelect += treeView1_AfterSelect;
        }

        private string currentFilePath;

        private void LoadRootDirectories()
        {
            treeView1.BeginUpdate();
            try
            {
                DirectoryInfo dDrive = new DirectoryInfo(@"D:\");
                if (dDrive.Exists)
                {
                    TreeNode dRootNode = new TreeNode(dDrive.Name);
                    dRootNode.Tag = dDrive;
                    dRootNode.Nodes.Add(new TreeNode("Loading..."));
                    treeView1.Nodes.Add(dRootNode);
                }
                DirectoryInfo cDrive = new DirectoryInfo(@"C:\");
                if (cDrive.Exists)
                {
                    TreeNode cRootNode = new TreeNode(cDrive.Name);
                    cRootNode.Tag = cDrive;
                    cRootNode.Nodes.Add(new TreeNode("Loading..."));
                    treeView1.Nodes.Add(cRootNode);
                }
            }
            finally
            {
                treeView1.EndUpdate();
            }
        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            if (selectedNode.Nodes[0].Text == "Loading...")
            {
                selectedNode.Nodes.Clear();
                DirectoryInfo directory = selectedNode.Tag as DirectoryInfo;

                if (directory != null)
                {
                    LoadDirectories(directory, selectedNode);
                }
            }
        }

        private void LoadDirectories(DirectoryInfo directoryInfo, TreeNode nodeToAddTo)
        {
            try
            {
                foreach (DirectoryInfo subDir in directoryInfo.EnumerateDirectories())
                {
                    TreeNode dirNode = new TreeNode(subDir.Name);
                    dirNode.Tag = subDir;
                    dirNode.Nodes.Add(new TreeNode("Loading..."));
                    nodeToAddTo.Nodes.Add(dirNode);
                }
                foreach (FileInfo file in directoryInfo.EnumerateFiles())
                {
                    TreeNode fileNode = new TreeNode(file.Name);
                    fileNode.Tag = file.FullName;
                    nodeToAddTo.Nodes.Add(fileNode);
                }
            }
            catch (UnauthorizedAccessException)
            {
                TreeNode accessDeniedNode = new TreeNode("Access Denied");
                accessDeniedNode.ForeColor = Color.Red;
                nodeToAddTo.Nodes.Add(accessDeniedNode);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (File.Exists(e.Node.Tag?.ToString()))
            {
                string selectedPath = e.Node.Tag.ToString();
                string extension = Path.GetExtension(selectedPath).ToLower();
                pictureBox1.Image = null;
                richTextBox1.Clear();
                pictureBox1.Visible = false;
                richTextBox1.Visible = false;
                if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".bmp")
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.Image = Image.FromFile(selectedPath);
                    pictureBox1.Visible = true;
                }
                else if (extension == ".txt")
                {
                    string textContent = File.ReadAllText(selectedPath);
                    richTextBox1.Text = textContent;
                    richTextBox1.Visible = true;
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void Escape_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Bai05_Load(object sender, EventArgs e)
        {

        }

        private void Save_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFilePath) && Path.GetExtension(currentFilePath).ToLower() == ".txt")
            {
                try
                {
                    File.WriteAllText(currentFilePath, richTextBox1.Text);
                    MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                SaveAs_Click(sender, e);
            }
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.AddExtension = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
                        currentFilePath = saveFileDialog.FileName;
                        MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
