
namespace WinFormsApp1
{
    partial class ArmKassirLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArmKassirLauncher));
            this.PathToApplication = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ApplicationParamether = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FileSettingsLaunch = new System.Windows.Forms.TextBox();
            this.FileNameParamethres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listPanel = new System.Windows.Forms.RichTextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.BaseName1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.оРазработчикахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.какИспользоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ошибкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запускНа1МонитореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PathToApplication
            // 
            resources.ApplyResources(this.PathToApplication, "PathToApplication");
            this.PathToApplication.BackColor = System.Drawing.Color.Blue;
            this.PathToApplication.ForeColor = System.Drawing.SystemColors.Menu;
            this.PathToApplication.Name = "PathToApplication";
            this.PathToApplication.TextChanged += new System.EventHandler(this.PathToApplication_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ApplicationParamether
            // 
            resources.ApplyResources(this.ApplicationParamether, "ApplicationParamether");
            this.ApplicationParamether.BackColor = System.Drawing.Color.Blue;
            this.ApplicationParamether.ForeColor = System.Drawing.SystemColors.Menu;
            this.ApplicationParamether.Name = "ApplicationParamether";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.StartRecordFile);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ReadRecordFile);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Name = "label3";
            // 
            // FileSettingsLaunch
            // 
            resources.ApplyResources(this.FileSettingsLaunch, "FileSettingsLaunch");
            this.FileSettingsLaunch.BackColor = System.Drawing.Color.Blue;
            this.FileSettingsLaunch.ForeColor = System.Drawing.SystemColors.Menu;
            this.FileSettingsLaunch.Name = "FileSettingsLaunch";
            this.FileSettingsLaunch.TextChanged += new System.EventHandler(this.FileSettingsLaunch_TextChanged);
            // 
            // FileNameParamethres
            // 
            resources.ApplyResources(this.FileNameParamethres, "FileNameParamethres");
            this.FileNameParamethres.BackColor = System.Drawing.Color.Blue;
            this.FileNameParamethres.ForeColor = System.Drawing.SystemColors.Menu;
            this.FileNameParamethres.Name = "FileNameParamethres";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Name = "label4";
            // 
            // listPanel
            // 
            resources.ApplyResources(this.listPanel, "listPanel");
            this.listPanel.BackColor = System.Drawing.Color.Blue;
            this.listPanel.ForeColor = System.Drawing.SystemColors.Menu;
            this.listPanel.Name = "listPanel";
            // 
            // Clear
            // 
            resources.ApplyResources(this.Clear, "Clear");
            this.Clear.BackColor = System.Drawing.Color.White;
            this.Clear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Clear.Name = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.ClearFile);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Name = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // BaseName1
            // 
            resources.ApplyResources(this.BaseName1, "BaseName1");
            this.BaseName1.BackColor = System.Drawing.Color.Blue;
            this.BaseName1.ForeColor = System.Drawing.SystemColors.Menu;
            this.BaseName1.Name = "BaseName1";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Start);
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            resources.ApplyResources(this.toolStripSplitButton1, "toolStripSplitButton1");
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оРазработчикахToolStripMenuItem,
            this.какИспользоватьToolStripMenuItem,
            this.ошибкиToolStripMenuItem});
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            // 
            // оРазработчикахToolStripMenuItem
            // 
            resources.ApplyResources(this.оРазработчикахToolStripMenuItem, "оРазработчикахToolStripMenuItem");
            this.оРазработчикахToolStripMenuItem.Name = "оРазработчикахToolStripMenuItem";
            this.оРазработчикахToolStripMenuItem.Click += new System.EventHandler(this.оРазработчикахToolStripMenuItem_Click);
            // 
            // какИспользоватьToolStripMenuItem
            // 
            resources.ApplyResources(this.какИспользоватьToolStripMenuItem, "какИспользоватьToolStripMenuItem");
            this.какИспользоватьToolStripMenuItem.Name = "какИспользоватьToolStripMenuItem";
            this.какИспользоватьToolStripMenuItem.Click += new System.EventHandler(this.какИспользоватьToolStripMenuItem_Click);
            // 
            // ошибкиToolStripMenuItem
            // 
            resources.ApplyResources(this.ошибкиToolStripMenuItem, "ошибкиToolStripMenuItem");
            this.ошибкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запускНа1МонитореToolStripMenuItem});
            this.ошибкиToolStripMenuItem.Name = "ошибкиToolStripMenuItem";
            // 
            // запускНа1МонитореToolStripMenuItem
            // 
            resources.ApplyResources(this.запускНа1МонитореToolStripMenuItem, "запускНа1МонитореToolStripMenuItem");
            this.запускНа1МонитореToolStripMenuItem.Name = "запускНа1МонитореToolStripMenuItem";
            this.запускНа1МонитореToolStripMenuItem.Click += new System.EventHandler(this.запускНа1МонитореToolStripMenuItem_Click);
            // 
            // ArmKassirLauncher
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BaseName1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.listPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FileNameParamethres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FileSettingsLaunch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ApplicationParamether);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PathToApplication);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "ArmKassirLauncher";
            this.Load += new System.EventHandler(this.ArmKassirLauncher_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PathToApplication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ApplicationParamether;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FileSettingsLaunch;
        private System.Windows.Forms.TextBox FileNameParamethres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox listPanel;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BaseName1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem оРазработчикахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem какИспользоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ошибкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запускНа1МонитореToolStripMenuItem;
    }
}

