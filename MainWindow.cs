namespace NPC_Creator_NT
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if(Directory.Exists(Path.Combine(Data.StaticData.CreatorDirectory, "Projects")))
            {
                var folderlist = Directory.GetDirectories(Path.Combine(Data.StaticData.CreatorDirectory, "Projects"));
                foreach(string directory in folderlist)
                {
                    Data.StaticData.ProjectList.Add(directory);
                }
            }
            Forms._00Loading ldscrn = new Forms._00Loading();
            ldscrn.Text = "Loading";
            ldscrn.ShowDialog();

        }

        private void nPCDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.CharacterData CDCreate = new Forms.CharacterData();
            CDCreate.Text = "Create NPC Data";
            CDCreate.ShowDialog();
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.CreateProject projcreate = new Forms.CreateProject();
            projcreate.Text = "Create New Project";
            projcreate.ShowDialog();
        }

        private void spritesheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.AddSprites spriteadd = new Forms.AddSprites();
            spriteadd.Text = "Add Spritesheet";
            spriteadd.ShowDialog();
        }

        private void portraitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.AddPortraits portadd = new Forms.AddPortraits();
            portadd.Text = "Add Portraits";
            portadd.ShowDialog();
        }
    }
}