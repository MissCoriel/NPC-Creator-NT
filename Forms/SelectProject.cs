using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPC_Creator_NT.Forms
{
    public partial class SelectProject : Form
    {
        public SelectProject()
        {
            InitializeComponent();
        }

        private void SelectProject_Load(object sender, EventArgs e)
        {
            foreach (string project in Data.StaticData.ProjectList)
            {
                ProjectSelector.Items.Add(project);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(ProjectSelector.Text))
            {
                Data.StaticData.CurrentProject = ProjectSelector.Text;
                if (!Directory.Exists(Path.Combine(Data.StaticData.CreatorDirectory, "Projects", Data.StaticData.CurrentProject)))
                {
                    Directory.CreateDirectory((Path.Combine(Data.StaticData.CreatorDirectory, "Projects", Data.StaticData.CurrentProject)));
                    MessageBox.Show("Project Folder did not exist.  New Project Created!", "New Project", MessageBoxButtons.OK);
                }
                this.Close();
            }
        }
    }
}
