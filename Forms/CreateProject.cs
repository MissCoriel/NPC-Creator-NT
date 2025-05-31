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
    public partial class CreateProject : Form
    {
        public CreateProject()
        {
            InitializeComponent();
        }

        private void OKBUTTON_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path.Combine(StaticData.CreatorDirectory, "Projects"));
            Directory.CreateDirectory(Path.Combine(StaticData.CreatorDirectory, "Projects", PROJECTNAME.Text));
            this.Close();
        }

        private void CANCELBUTTON_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
