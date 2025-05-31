namespace NPC_Creator_NT.Forms
{
    partial class SelectProject
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
            ProjectSelector = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 32);
            label1.Name = "label1";
            label1.Size = new Size(199, 15);
            label1.TabIndex = 0;
            label1.Text = "Select a Project or Create a New One";
            // 
            // ProjectSelector
            // 
            ProjectSelector.FormattingEnabled = true;
            ProjectSelector.Location = new Point(87, 68);
            ProjectSelector.Name = "ProjectSelector";
            ProjectSelector.Size = new Size(121, 23);
            ProjectSelector.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(110, 108);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Okay";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SelectProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 163);
            Controls.Add(button1);
            Controls.Add(ProjectSelector);
            Controls.Add(label1);
            Name = "SelectProject";
            Text = "SelectProject";
            Load += SelectProject_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox ProjectSelector;
        private Button button1;
    }
}