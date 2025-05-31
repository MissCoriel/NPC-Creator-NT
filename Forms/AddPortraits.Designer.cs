namespace NPC_Creator_NT.Forms
{
    partial class AddPortraits
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
            label1 = new Label();
            listProjects = new ComboBox();
            AddPortrait = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 19);
            label1.Name = "label1";
            label1.Size = new Size(170, 15);
            label1.TabIndex = 0;
            label1.Text = "Add Portraits to which Project?";
            // 
            // listProjects
            // 
            listProjects.FormattingEnabled = true;
            listProjects.Location = new Point(49, 47);
            listProjects.Name = "listProjects";
            listProjects.Size = new Size(121, 23);
            listProjects.TabIndex = 1;
            // 
            // AddPortrait
            // 
            AddPortrait.Location = new Point(12, 93);
            AddPortrait.Name = "AddPortrait";
            AddPortrait.Size = new Size(75, 23);
            AddPortrait.TabIndex = 2;
            AddPortrait.Text = "Add";
            AddPortrait.UseVisualStyleBackColor = true;
            AddPortrait.Click += AddPortrait_Click;
            // 
            // button2
            // 
            button2.Location = new Point(136, 93);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddPortraits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 132);
            Controls.Add(button2);
            Controls.Add(AddPortrait);
            Controls.Add(listProjects);
            Controls.Add(label1);
            Name = "AddPortraits";
            Text = "AddPortraits";
            Load += AddPortraits_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox listProjects;
        private Button AddPortrait;
        private Button button2;
    }
}