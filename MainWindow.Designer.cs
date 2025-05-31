namespace NPC_Creator_NT
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            createToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem1 = new ToolStripMenuItem();
            projectToolStripMenuItem = new ToolStripMenuItem();
            nPCDataToolStripMenuItem = new ToolStripMenuItem();
            dialogueToolStripMenuItem = new ToolStripMenuItem();
            scheduleToolStripMenuItem = new ToolStripMenuItem();
            animationToolStripMenuItem = new ToolStripMenuItem();
            imageToolStripMenuItem = new ToolStripMenuItem();
            spritesheetToolStripMenuItem = new ToolStripMenuItem();
            portraitsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { createToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1105, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem1 });
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(56, 20);
            createToolStripMenuItem.Text = "Project";
            // 
            // createToolStripMenuItem1
            // 
            createToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { projectToolStripMenuItem, nPCDataToolStripMenuItem, dialogueToolStripMenuItem, scheduleToolStripMenuItem, animationToolStripMenuItem, imageToolStripMenuItem });
            createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            createToolStripMenuItem1.Size = new Size(180, 22);
            createToolStripMenuItem1.Text = "Create";
            // 
            // projectToolStripMenuItem
            // 
            projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            projectToolStripMenuItem.Size = new Size(180, 22);
            projectToolStripMenuItem.Text = "New Project";
            projectToolStripMenuItem.Click += projectToolStripMenuItem_Click;
            // 
            // nPCDataToolStripMenuItem
            // 
            nPCDataToolStripMenuItem.Name = "nPCDataToolStripMenuItem";
            nPCDataToolStripMenuItem.Size = new Size(180, 22);
            nPCDataToolStripMenuItem.Text = "NPCData";
            nPCDataToolStripMenuItem.Click += nPCDataToolStripMenuItem_Click;
            // 
            // dialogueToolStripMenuItem
            // 
            dialogueToolStripMenuItem.Name = "dialogueToolStripMenuItem";
            dialogueToolStripMenuItem.Size = new Size(180, 22);
            dialogueToolStripMenuItem.Text = "Dialogue";
            // 
            // scheduleToolStripMenuItem
            // 
            scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            scheduleToolStripMenuItem.Size = new Size(180, 22);
            scheduleToolStripMenuItem.Text = "Schedule";
            // 
            // animationToolStripMenuItem
            // 
            animationToolStripMenuItem.Name = "animationToolStripMenuItem";
            animationToolStripMenuItem.Size = new Size(180, 22);
            animationToolStripMenuItem.Text = "Animation";
            // 
            // imageToolStripMenuItem
            // 
            imageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { spritesheetToolStripMenuItem, portraitsToolStripMenuItem });
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new Size(180, 22);
            imageToolStripMenuItem.Text = "Image";
            // 
            // spritesheetToolStripMenuItem
            // 
            spritesheetToolStripMenuItem.Name = "spritesheetToolStripMenuItem";
            spritesheetToolStripMenuItem.Size = new Size(180, 22);
            spritesheetToolStripMenuItem.Text = "Spritesheet";
            spritesheetToolStripMenuItem.Click += spritesheetToolStripMenuItem_Click;
            // 
            // portraitsToolStripMenuItem
            // 
            portraitsToolStripMenuItem.Name = "portraitsToolStripMenuItem";
            portraitsToolStripMenuItem.Size = new Size(180, 22);
            portraitsToolStripMenuItem.Text = "Portraits";
            portraitsToolStripMenuItem.Click += portraitsToolStripMenuItem_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 605);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            Text = "NPC Creator 4";
            Load += MainWindow_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem1;
        private ToolStripMenuItem projectToolStripMenuItem;
        private ToolStripMenuItem nPCDataToolStripMenuItem;
        private ToolStripMenuItem dialogueToolStripMenuItem;
        private ToolStripMenuItem scheduleToolStripMenuItem;
        private ToolStripMenuItem animationToolStripMenuItem;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripMenuItem spritesheetToolStripMenuItem;
        private ToolStripMenuItem portraitsToolStripMenuItem;
    }
}