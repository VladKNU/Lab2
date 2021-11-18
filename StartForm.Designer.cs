
namespace XML
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.URLlabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.ChooseButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.MyMenuStrip = new System.Windows.Forms.MenuStrip();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FastPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ENGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBox.SuspendLayout();
            this.MyMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // URLlabel
            // 
            this.URLlabel.AutoSize = true;
            this.URLlabel.Location = new System.Drawing.Point(6, 16);
            this.URLlabel.Name = "URLlabel";
            this.URLlabel.Size = new System.Drawing.Size(0, 13);
            this.URLlabel.TabIndex = 0;
            this.URLlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.URLlabel.TextChanged += new System.EventHandler(this.URLlabel_TextChanged);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.StartButton.Location = new System.Drawing.Point(113, 96);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(124, 52);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ChooseButton
            // 
            this.ChooseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.ChooseButton.Location = new System.Drawing.Point(113, 154);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(124, 52);
            this.ChooseButton.TabIndex = 2;
            this.ChooseButton.Text = "Choose";
            this.ChooseButton.UseVisualStyleBackColor = false;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.ExitButton.Location = new System.Drawing.Point(113, 212);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(124, 52);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.GroupBox.Controls.Add(this.URLlabel);
            this.GroupBox.Location = new System.Drawing.Point(22, 52);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(308, 38);
            this.GroupBox.TabIndex = 4;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "URL";
            // 
            // MyMenuStrip
            // 
            this.MyMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.MyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpToolStripMenuItem,
            this.LangToolStripMenuItem,
            this.FastPathToolStripMenuItem});
            this.MyMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MyMenuStrip.Name = "MyMenuStrip";
            this.MyMenuStrip.Size = new System.Drawing.Size(359, 24);
            this.MyMenuStrip.TabIndex = 7;
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.HelpToolStripMenuItem.Text = "Help!";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // LangToolStripMenuItem
            // 
            this.LangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UAToolStripMenuItem,
            this.ENGToolStripMenuItem,
            this.RUSToolStripMenuItem});
            this.LangToolStripMenuItem.Name = "LangToolStripMenuItem";
            this.LangToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.LangToolStripMenuItem.Text = "Language";
            // 
            // FastPathToolStripMenuItem
            // 
            this.FastPathToolStripMenuItem.Name = "FastPathToolStripMenuItem";
            this.FastPathToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.FastPathToolStripMenuItem.Text = "Fast path";
            this.FastPathToolStripMenuItem.Click += new System.EventHandler(this.FastPathToolStripMenuItem_Click);
            // 
            // UAToolStripMenuItem
            // 
            this.UAToolStripMenuItem.Name = "UAToolStripMenuItem";
            this.UAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.UAToolStripMenuItem.Text = "UA";
            this.UAToolStripMenuItem.Click += new System.EventHandler(this.UAToolStripMenuItem_Click);
            // 
            // ENGToolStripMenuItem
            // 
            this.ENGToolStripMenuItem.Name = "ENGToolStripMenuItem";
            this.ENGToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ENGToolStripMenuItem.Text = "ENG";
            this.ENGToolStripMenuItem.Click += new System.EventHandler(this.ENGToolStripMenuItem_Click);
            // 
            // RUSToolStripMenuItem
            // 
            this.RUSToolStripMenuItem.Name = "RUSToolStripMenuItem";
            this.RUSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RUSToolStripMenuItem.Text = "RUS";
            this.RUSToolStripMenuItem.Click += new System.EventHandler(this.RUSToolStripMenuItem_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(359, 311);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ChooseButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.MyMenuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MyMenuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curriculum";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.MyMenuStrip.ResumeLayout(false);
            this.MyMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label URLlabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ChooseButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.MenuStrip MyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FastPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ENGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RUSToolStripMenuItem;
    }
}