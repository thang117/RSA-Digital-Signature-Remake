
namespace RSA_Signature_RemakeV1
{
    partial class frVertification
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnVertificationSignature = new System.Windows.Forms.Button();
            this.btnGoCreateFrom = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbVertification = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbElective = new System.Windows.Forms.RadioButton();
            this.rdbDesktop = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImportSignature = new System.Windows.Forms.Button();
            this.tbInputSignaturePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoToFile2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "☑Vertification Signature";
            // 
            // btnVertificationSignature
            // 
            this.btnVertificationSignature.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVertificationSignature.Location = new System.Drawing.Point(59, 145);
            this.btnVertificationSignature.Name = "btnVertificationSignature";
            this.btnVertificationSignature.Size = new System.Drawing.Size(310, 50);
            this.btnVertificationSignature.TabIndex = 5;
            this.btnVertificationSignature.Text = "Vertification Digital Signature";
            this.btnVertificationSignature.UseVisualStyleBackColor = true;
            this.btnVertificationSignature.Click += new System.EventHandler(this.btnVertificationSignature_Click);
            // 
            // btnGoCreateFrom
            // 
            this.btnGoCreateFrom.Location = new System.Drawing.Point(12, 201);
            this.btnGoCreateFrom.Name = "btnGoCreateFrom";
            this.btnGoCreateFrom.Size = new System.Drawing.Size(109, 23);
            this.btnGoCreateFrom.TabIndex = 9;
            this.btnGoCreateFrom.Text = "✒️Create Signature";
            this.btnGoCreateFrom.UseVisualStyleBackColor = true;
            this.btnGoCreateFrom.Click += new System.EventHandler(this.btnGoCreateFrom_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(345, 17);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(65, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "⟳Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbVertification
            // 
            this.lbVertification.AutoSize = true;
            this.lbVertification.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbVertification.Location = new System.Drawing.Point(59, 40);
            this.lbVertification.Name = "lbVertification";
            this.lbVertification.Size = new System.Drawing.Size(120, 23);
            this.lbVertification.TabIndex = 14;
            this.lbVertification.Text = "No Signature";
            this.lbVertification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdbElective);
            this.panel1.Controls.Add(this.rdbDesktop);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnImportSignature);
            this.panel1.Controls.Add(this.tbInputSignaturePath);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 71);
            this.panel1.TabIndex = 15;
            // 
            // rdbElective
            // 
            this.rdbElective.AutoSize = true;
            this.rdbElective.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbElective.Location = new System.Drawing.Point(295, 47);
            this.rdbElective.Name = "rdbElective";
            this.rdbElective.Size = new System.Drawing.Size(74, 23);
            this.rdbElective.TabIndex = 20;
            this.rdbElective.TabStop = true;
            this.rdbElective.Text = "Elective";
            this.rdbElective.UseVisualStyleBackColor = true;
            // 
            // rdbDesktop
            // 
            this.rdbDesktop.AutoSize = true;
            this.rdbDesktop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbDesktop.Location = new System.Drawing.Point(210, 47);
            this.rdbDesktop.Name = "rdbDesktop";
            this.rdbDesktop.Size = new System.Drawing.Size(79, 23);
            this.rdbDesktop.TabIndex = 19;
            this.rdbDesktop.TabStop = true;
            this.rdbDesktop.Text = "Desktop";
            this.rdbDesktop.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(93, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Locale extract:";
            // 
            // btnImportSignature
            // 
            this.btnImportSignature.Location = new System.Drawing.Point(295, 19);
            this.btnImportSignature.Name = "btnImportSignature";
            this.btnImportSignature.Size = new System.Drawing.Size(75, 23);
            this.btnImportSignature.TabIndex = 13;
            this.btnImportSignature.Text = "Import";
            this.btnImportSignature.UseVisualStyleBackColor = true;
            this.btnImportSignature.Click += new System.EventHandler(this.btnImportSignature_Click);
            // 
            // tbInputSignaturePath
            // 
            this.tbInputSignaturePath.Location = new System.Drawing.Point(91, 19);
            this.tbInputSignaturePath.Name = "tbInputSignaturePath";
            this.tbInputSignaturePath.ReadOnly = true;
            this.tbInputSignaturePath.Size = new System.Drawing.Size(198, 23);
            this.tbInputSignaturePath.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Signature:";
            // 
            // btnGoToFile2
            // 
            this.btnGoToFile2.Location = new System.Drawing.Point(171, 201);
            this.btnGoToFile2.Name = "btnGoToFile2";
            this.btnGoToFile2.Size = new System.Drawing.Size(75, 23);
            this.btnGoToFile2.TabIndex = 16;
            this.btnGoToFile2.Text = "Go to file";
            this.btnGoToFile2.UseVisualStyleBackColor = true;
            this.btnGoToFile2.Click += new System.EventHandler(this.btnGoToFile2_Click);
            // 
            // frVertification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 226);
            this.Controls.Add(this.btnGoToFile2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbVertification);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGoCreateFrom);
            this.Controls.Add(this.btnVertificationSignature);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frVertification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vertification";
            this.Load += new System.EventHandler(this.frVertification_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVertificationSignature;
        private System.Windows.Forms.Button btnGoCreateFrom;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbVertification;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImportSignature;
        private System.Windows.Forms.TextBox tbInputSignaturePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbElective;
        private System.Windows.Forms.RadioButton rdbDesktop;
        private System.Windows.Forms.Button btnGoToFile2;
    }
}