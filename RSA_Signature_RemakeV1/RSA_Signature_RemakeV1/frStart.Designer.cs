
namespace RSA_Signature_RemakeV1
{
    partial class frStart
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVertificationFrom = new System.Windows.Forms.Button();
            this.btnCreateFrom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalSignatureCreationProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appInfomationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVertificationFrom);
            this.panel1.Controls.Add(this.btnCreateFrom);
            this.panel1.Location = new System.Drawing.Point(28, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 74);
            this.panel1.TabIndex = 0;
            // 
            // btnVertificationFrom
            // 
            this.btnVertificationFrom.BackColor = System.Drawing.Color.Transparent;
            this.btnVertificationFrom.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVertificationFrom.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnVertificationFrom.Location = new System.Drawing.Point(219, 4);
            this.btnVertificationFrom.Name = "btnVertificationFrom";
            this.btnVertificationFrom.Size = new System.Drawing.Size(210, 67);
            this.btnVertificationFrom.TabIndex = 1;
            this.btnVertificationFrom.Text = "☑Vertification";
            this.btnVertificationFrom.UseVisualStyleBackColor = false;
            this.btnVertificationFrom.Click += new System.EventHandler(this.btnVertificationFrom_Click);
            // 
            // btnCreateFrom
            // 
            this.btnCreateFrom.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateFrom.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateFrom.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnCreateFrom.Location = new System.Drawing.Point(3, 4);
            this.btnCreateFrom.Name = "btnCreateFrom";
            this.btnCreateFrom.Size = new System.Drawing.Size(210, 67);
            this.btnCreateFrom.TabIndex = 0;
            this.btnCreateFrom.Text = "✒️Create";
            this.btnCreateFrom.UseVisualStyleBackColor = false;
            this.btnCreateFrom.Click += new System.EventHandler(this.btnCreateFrom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "RSA  Digital Signature Remake";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(489, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem,
            this.digitalSignatureCreationProcessToolStripMenuItem,
            this.appInfomationToolStripMenuItem});
            this.informationToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // digitalSignatureCreationProcessToolStripMenuItem
            // 
            this.digitalSignatureCreationProcessToolStripMenuItem.Name = "digitalSignatureCreationProcessToolStripMenuItem";
            this.digitalSignatureCreationProcessToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.digitalSignatureCreationProcessToolStripMenuItem.Text = "Digital signature creation process";
            this.digitalSignatureCreationProcessToolStripMenuItem.Click += new System.EventHandler(this.digitalSignatureCreationProcessToolStripMenuItem_Click);
            // 
            // appInfomationToolStripMenuItem
            // 
            this.appInfomationToolStripMenuItem.Name = "appInfomationToolStripMenuItem";
            this.appInfomationToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.appInfomationToolStripMenuItem.Text = "App Infomation";
            this.appInfomationToolStripMenuItem.Click += new System.EventHandler(this.appInfomationToolStripMenuItem_Click);
            // 
            // frStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 166);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVertificationFrom;
        private System.Windows.Forms.Button btnCreateFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitalSignatureCreationProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appInfomationToolStripMenuItem;
    }
}

