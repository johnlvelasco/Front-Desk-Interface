namespace Front_Desk_Interface
{
    partial class UserInterface
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
            this.uxMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxNew = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSave = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.uxAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxTextBox = new System.Windows.Forms.ToolStripMenuItem();
            this.uxUpload = new System.Windows.Forms.ToolStripMenuItem();
            this.uxUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.uxRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.uxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMenu
            // 
            this.uxMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.uxMenu.Location = new System.Drawing.Point(0, 0);
            this.uxMenu.Name = "uxMenu";
            this.uxMenu.Size = new System.Drawing.Size(879, 28);
            this.uxMenu.TabIndex = 0;
            this.uxMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxNew,
            this.uxOpen,
            this.uxSave,
            this.uxSettings,
            this.uxAbout});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // uxNew
            // 
            this.uxNew.Name = "uxNew";
            this.uxNew.Size = new System.Drawing.Size(224, 26);
            this.uxNew.Text = "New";
            // 
            // uxOpen
            // 
            this.uxOpen.Name = "uxOpen";
            this.uxOpen.Size = new System.Drawing.Size(224, 26);
            this.uxOpen.Text = "Open...";
            // 
            // uxSave
            // 
            this.uxSave.Name = "uxSave";
            this.uxSave.Size = new System.Drawing.Size(224, 26);
            this.uxSave.Text = "Save As...";
            // 
            // uxSettings
            // 
            this.uxSettings.Name = "uxSettings";
            this.uxSettings.Size = new System.Drawing.Size(224, 26);
            this.uxSettings.Text = "Settings";
            // 
            // uxAbout
            // 
            this.uxAbout.Name = "uxAbout";
            this.uxAbout.Size = new System.Drawing.Size(224, 26);
            this.uxAbout.Text = "About";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxTextBox,
            this.uxUpload,
            this.uxUndo,
            this.uxRedo});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // uxTextBox
            // 
            this.uxTextBox.Name = "uxTextBox";
            this.uxTextBox.Size = new System.Drawing.Size(224, 26);
            this.uxTextBox.Text = "Add Text Box";
            // 
            // uxUpload
            // 
            this.uxUpload.Name = "uxUpload";
            this.uxUpload.Size = new System.Drawing.Size(224, 26);
            this.uxUpload.Text = "Upload Media";
            // 
            // uxUndo
            // 
            this.uxUndo.Name = "uxUndo";
            this.uxUndo.Size = new System.Drawing.Size(224, 26);
            this.uxUndo.Text = "Undo";
            // 
            // uxRedo
            // 
            this.uxRedo.Name = "uxRedo";
            this.uxRedo.Size = new System.Drawing.Size(224, 26);
            this.uxRedo.Text = "Redo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Displays";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Display 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Display 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Select this Display";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(554, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Select this Display";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 482);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxMenu);
            this.MainMenuStrip = this.uxMenu;
            this.Name = "UserInterface";
            this.Text = "Start Menu";
            this.uxMenu.ResumeLayout(false);
            this.uxMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxOpen;
        private System.Windows.Forms.ToolStripMenuItem uxSave;
        private System.Windows.Forms.ToolStripMenuItem uxSettings;
        private System.Windows.Forms.ToolStripMenuItem uxAbout;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxTextBox;
        private System.Windows.Forms.ToolStripMenuItem uxUpload;
        private System.Windows.Forms.ToolStripMenuItem uxNew;
        private System.Windows.Forms.ToolStripMenuItem uxUndo;
        private System.Windows.Forms.ToolStripMenuItem uxRedo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

