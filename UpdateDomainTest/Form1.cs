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
using UpdateDomainTest.Models;
using System.Xml;
using System.Xml.Serialization;

namespace UpdateDomainTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<FileInfo> SelectFiles { get; set; }

        private void butSelectFile_Click(object sender, EventArgs e)
        {
            opFile.ShowDialog();
            if (opFile.FileNames.Length > 0)
            {
                SelectFiles = new List<FileInfo>();

                IList<UFileInfo> ufiles = new List<UFileInfo>();
                foreach (string sfile in opFile.FileNames)
                {
                    FileInfo fInfo = new FileInfo(sfile);
                    if (fInfo.Exists)
                    {
                        UFileInfo ufile = new UFileInfo();
                        ufile.CreateTime = fInfo.CreationTime;
                        ufile.FileFullName = fInfo.FullName;
                        ufile.FileName = fInfo.Name;

                        ufiles.Add(ufile);
                        SelectFiles.Add(fInfo);

                        folderBrows.SelectedPath = fInfo.Directory.FullName;
                    }
                }
                dataGridView1.DataSource = ufiles;

            }
            else
            {
                SelectFiles = new List<FileInfo>();
            }
        }

        private void butSetup2_Click(object sender, EventArgs e)
        {
            folderBrows.ShowDialog();
            if (folderBrows.SelectedPath != null && folderBrows.SelectedPath.Length > 0)
            {
                DirectoryInfo dInfo = new DirectoryInfo(folderBrows.SelectedPath);
                if (dInfo.Exists)
                {
                    tbFile.Text = folderBrows.SelectedPath;
                }
            }
        }

        private void lbExcludeList_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left)
            //{ }
            //else
            //{
            //    if (cbExcludeFolder.Checked == false)
            //        return;

            //    if (lbExcludeList.SelectedIndex > -1)
            //    {
            //        cMenExclude.Items[0].Enabled = false;
            //        cMenExclude.Items[2].Enabled = true;
            //    }
            //    else
            //    {
            //        cMenExclude.Items[0].Enabled = true;
            //        cMenExclude.Items[2].Enabled = true;
            //    }
            //    cMenExclude.Show();
            //}
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbExcludeFolder.Checked == false)
                return;

            folderBrows.ShowDialog();
            if (folderBrows.SelectedPath != null && folderBrows.SelectedPath.Length > 0)
            {
                DirectoryInfo dInfo = new DirectoryInfo(folderBrows.SelectedPath);
                if (dInfo.Exists)
                {
                    lbExcludeList.Items.Add(dInfo.FullName);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbExcludeFolder.Checked == false)
                return;

            if (lbExcludeList.SelectedIndex > -1)
            {
                lbExcludeList.Items.RemoveAt(lbExcludeList.SelectedIndex);
            }
        }

        private void lbExcludeList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)           
            {
                if (cbExcludeFolder.Checked == false)
                    return;

                if (lbExcludeList.SelectedIndex > -1)
                {
                    cMenExclude.Items[0].Enabled = false;
                    cMenExclude.Items[1].Enabled = true;
                }
                else
                {
                    cMenExclude.Items[0].Enabled = true;
                    cMenExclude.Items[1].Enabled = true;
                }
                cMenExclude.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo sfile = new FileInfo(Environment.CurrentDirectory+ "\\Configs\\UpdateDireXML.xml");
            if (sfile.Exists)
            {
                StreamReader stream = new StreamReader(sfile.FullName);
                XmlSerializer serializer = new XmlSerializer(typeof(Folders));
                try
                {
                    Folders folers = (Folders)serializer.Deserialize(stream);
                }
                catch (InvalidOperationException error)
                {
                    throw error;
                }
                finally
                {
                    if (stream != null)
                    {
                        stream.Close();
                        stream.Dispose();
                    }
                }

            }
            
                //new DirectoryInfo(Application.StartupPath);
        }
    }

}
