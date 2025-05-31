namespace NPC_Creator_NT.Forms
{
    partial class AddSprites
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
            ADDbutton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(184, 15);
            label1.TabIndex = 0;
            label1.Text = "Add Spritesheet to which Project?";
            // 
            // listProjects
            // 
            listProjects.FormattingEnabled = true;
            listProjects.Location = new Point(53, 38);
            listProjects.Name = "listProjects";
            listProjects.Size = new Size(121, 23);
            listProjects.TabIndex = 1;
            // 
            // ADDbutton
            // 
            ADDbutton.Location = new Point(12, 76);
            ADDbutton.Name = "ADDbutton";
            ADDbutton.Size = new Size(75, 23);
            ADDbutton.TabIndex = 2;
            ADDbutton.Text = "Add";
            ADDbutton.UseVisualStyleBackColor = true;
            ADDbutton.Click += ADDbutton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(132, 76);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddSprites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(226, 114);
            Controls.Add(CancelButton);
            Controls.Add(ADDbutton);
            Controls.Add(listProjects);
            Controls.Add(label1);
            Name = "AddSprites";
            Text = "AddSprites";
            Load += AddSprites_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox listProjects;
        private Button ADDbutton;
        private Button CancelButton;
    }
}