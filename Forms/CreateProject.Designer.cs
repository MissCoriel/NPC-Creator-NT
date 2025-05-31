namespace NPC_Creator_NT.Forms
{
    partial class CreateProject
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
            PROJECTNAME = new TextBox();
            OKBUTTON = new Button();
            CANCELBUTTON = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 20);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 0;
            label1.Text = "Create Project Name";
            // 
            // PROJECTNAME
            // 
            PROJECTNAME.Location = new Point(55, 38);
            PROJECTNAME.Name = "PROJECTNAME";
            PROJECTNAME.Size = new Size(133, 23);
            PROJECTNAME.TabIndex = 1;
            // 
            // OKBUTTON
            // 
            OKBUTTON.Location = new Point(27, 67);
            OKBUTTON.Name = "OKBUTTON";
            OKBUTTON.Size = new Size(75, 23);
            OKBUTTON.TabIndex = 2;
            OKBUTTON.Text = "Create";
            OKBUTTON.UseVisualStyleBackColor = true;
            OKBUTTON.Click += OKBUTTON_Click;
            // 
            // CANCELBUTTON
            // 
            CANCELBUTTON.Location = new Point(137, 67);
            CANCELBUTTON.Name = "CANCELBUTTON";
            CANCELBUTTON.Size = new Size(75, 23);
            CANCELBUTTON.TabIndex = 3;
            CANCELBUTTON.Text = "Cancel";
            CANCELBUTTON.UseVisualStyleBackColor = true;
            CANCELBUTTON.Click += CANCELBUTTON_Click;
            // 
            // CreateProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 110);
            Controls.Add(CANCELBUTTON);
            Controls.Add(OKBUTTON);
            Controls.Add(PROJECTNAME);
            Controls.Add(label1);
            Name = "CreateProject";
            Text = "CreateProject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox PROJECTNAME;
        private Button OKBUTTON;
        private Button CANCELBUTTON;
    }
}