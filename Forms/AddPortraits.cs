using NPC_Creator_NT.Data;
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
    public partial class AddPortraits : Form
    {
        public AddPortraits()
        {
            InitializeComponent();
        }

        private void AddPortraits_Load(object sender, EventArgs e)
        {
            foreach (string projects in StaticData.ProjectList)
            {
                listProjects.Items.Add(projects);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPortrait_Click(object sender, EventArgs e)
        {
            OpenFileDialog addportrait = new OpenFileDialog();
            addportrait.Title = "Add Portraits";
            addportrait.Filter = "PNG Files (*.png)|*.png";
            addportrait.FilterIndex = 1;
            if (addportrait.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists(Path.Combine(StaticData.CreatorDirectory, "Projects", listProjects.Text, "IMG")))
                {
                    //Create Directory Structure
                    Directory.CreateDirectory(Path.Combine(StaticData.CreatorDirectory, "Projects", listProjects.Text, "IMG"));
                    Directory.CreateDirectory(Path.Combine(StaticData.CreatorDirectory, "Projects", listProjects.Text, "IMG", "Spritesheets"));
                    Directory.CreateDirectory(Path.Combine(StaticData.CreatorDirectory, "Projects", listProjects.Text, "IMG", "Portraits"));
                }
                string importfile = addportrait.FileName;
                if (File.Exists(Path.Combine(StaticData.CreatorDirectory, "Projects", listProjects.Text, "IMG", "Portraits", "portraits.png")))
                {
                    File.Copy(importfile, Path.Combine(StaticData.CreatorDirectory, "Projects", listProjects.Text, "IMG", "Portraits", addportrait.SafeFileName));
                }
                if (!File.Exists(Path.Combine(StaticData.CreatorDirectory, "Projects", listProjects.Text, "IMG", "Portraits", "portraits.png")))
                {
                    MessageBox.Show("There is no Main Portraits!  This File will be desginated as the main.", "Main Portraits", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    File.Copy(importfile, Path.Combine(StaticData.CreatorDirectory, "Projects", listProjects.Text, "IMG", "Portraits", "portraits.png"));
                }
            }

        }
    }
}
