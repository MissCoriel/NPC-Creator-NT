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
    public partial class AddSprites : Form
    {
        public AddSprites()
        {
            InitializeComponent();
        }

        private void AddSprites_Load(object sender, EventArgs e)
        {
            foreach (string project in StaticData.ProjectList)
            {
                listProjects.Items.Add(project);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ADDbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog addspritesheet = new OpenFileDialog();
            addspritesheet.Title = "Add Spritesheet";
            addspritesheet.Filter = "PNG Files (*.png)|*.png";
            addspritesheet.FilterIndex = 1;
            if (addspritesheet.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists(Path.Combine(StaticData.CreatorDirectory, "Projects", listProjects.Text, "IMG")))
                {
                    //Create Directory Structure
                    Directory.CreateDirectory(Path.Combine(StaticData.CreatorDirectory, "Projects", listProjects.Text, "IMG"));
                    Directory.CreateDirectory(Path.Combine(StaticData.CreatorDirectory, "Projects", listProjects.Text, "IMG", "Spritesheets"));
                    Directory.CreateDirectory(Path.Combine(StaticData.CreatorDirectory, "Projects", listProjects.Text, "IMG", "Portraits"));
                }
                string importfile = addspritesheet.FileName;
                if (File.Exists(Path.Combine(StaticData.CreatorDirectory, "Projects", listProjects.Text, "IMG", "Spritesheets", "spritesheet.png")))
                {
                    File.Copy(importfile, Path.Combine(StaticData.CreatorDirectory, "Projects", listProjects.Text, "IMG", "Spritesheets", addspritesheet.SafeFileName));
                }
                if (!File.Exists(Path.Combine(StaticData.CreatorDirectory, "Projects", listProjects.Text, "IMG", "Spritesheets", "spritesheet.png")))
                {
                    MessageBox.Show("There is no Main Spritesheet!  This Spritesheet will be desginated as the main.", "Main Spritesheet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    File.Copy(importfile, Path.Combine(StaticData.CreatorDirectory, "Projects", listProjects.Text, "IMG", "Spritesheets", "spritesheet.png"));
                }
            }
            this.Close();
        }
    }
}
