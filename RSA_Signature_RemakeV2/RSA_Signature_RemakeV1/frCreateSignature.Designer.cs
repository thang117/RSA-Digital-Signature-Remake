
namespace RSA_Signature_RemakeV1
{
    partial class frCreateSignature
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
            this.btnImportData = new System.Windows.Forms.Button();
            this.tbInputDataPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateSignature = new System.Windows.Forms.Button();
            this.cbbSizeKey = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGoVertificationFrom = new System.Windows.Forms.Button();
            this.btnGoHome = new System.Windows.Forms.Button();
            this.btnGoToFile1 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImportData
            // 
            this.btnImportData.Location = new System.Drawing.Point(319, 43);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(75, 23);
            this.btnImportData.TabIndex = 0;
            this.btnImportData.Text = "Import";
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // tbInputDataPath
            // 
            this.tbInputDataPath.Location = new System.Drawing.Point(63, 44);
            this.tbInputDataPath.Name = "tbInputDataPath";
            this.tbInputDataPath.ReadOnly = true;
            this.tbInputDataPath.Size = new System.Drawing.Size(250, 23);
            this.tbInputDataPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(-6, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "✒️Create Signature";
            // 
            // btnCreateSignature
            // 
            this.btnCreateSignature.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateSignature.Location = new System.Drawing.Point(58, 140);
            this.btnCreateSignature.Name = "btnCreateSignature";
            this.btnCreateSignature.Size = new System.Drawing.Size(310, 50);
            this.btnCreateSignature.TabIndex = 4;
            this.btnCreateSignature.Text = "Create Digital Signature";
            this.btnCreateSignature.UseVisualStyleBackColor = true;
            this.btnCreateSignature.Click += new System.EventHandler(this.btnCreateSignature_Click);
            // 
            // cbbSizeKey
            // 
            this.cbbSizeKey.FormattingEnabled = true;
            this.cbbSizeKey.Location = new System.Drawing.Point(138, 15);
            this.cbbSizeKey.Name = "cbbSizeKey";
            this.cbbSizeKey.Size = new System.Drawing.Size(256, 23);
            this.cbbSizeKey.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose size key:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbbSizeKey);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnImportData);
            this.panel1.Controls.Add(this.tbInputDataPath);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 80);
            this.panel1.TabIndex = 7;
            // 
            // btnGoVertificationFrom
            // 
            this.btnGoVertificationFrom.Location = new System.Drawing.Point(302, 196);
            this.btnGoVertificationFrom.Name = "btnGoVertificationFrom";
            this.btnGoVertificationFrom.Size = new System.Drawing.Size(109, 23);
            this.btnGoVertificationFrom.TabIndex = 8;
            this.btnGoVertificationFrom.Text = "☑Vertification";
            this.btnGoVertificationFrom.UseVisualStyleBackColor = true;
            this.btnGoVertificationFrom.Click += new System.EventHandler(this.btnGoVertificationFrom_Click);
            // 
            // btnGoHome
            // 
            this.btnGoHome.Location = new System.Drawing.Point(12, 196);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(109, 23);
            this.btnGoHome.TabIndex = 9;
            this.btnGoHome.Text = "🏡Home";
            this.btnGoHome.UseVisualStyleBackColor = true;
            this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // btnGoToFile1
            // 
            this.btnGoToFile1.Location = new System.Drawing.Point(177, 196);
            this.btnGoToFile1.Name = "btnGoToFile1";
            this.btnGoToFile1.Size = new System.Drawing.Size(75, 23);
            this.btnGoToFile1.TabIndex = 10;
            this.btnGoToFile1.Text = "Go to file";
            this.btnGoToFile1.UseVisualStyleBackColor = true;
            this.btnGoToFile1.Click += new System.EventHandler(this.btnGoToFile1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(326, 17);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(65, 23);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "⟳Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frCreateSignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 223);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGoToFile1);
            this.Controls.Add(this.btnGoHome);
            this.Controls.Add(this.btnGoVertificationFrom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCreateSignature);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frCreateSignature";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create";
            this.Load += new System.EventHandler(this.frCreateSignature_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.TextBox tbInputDataPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateSignature;
        private System.Windows.Forms.ComboBox cbbSizeKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGoVertificationFrom;
        private System.Windows.Forms.Button btnGoHome;
        private System.Windows.Forms.Button btnGoToFile1;
        private System.Windows.Forms.Button btnReset;
    }
}