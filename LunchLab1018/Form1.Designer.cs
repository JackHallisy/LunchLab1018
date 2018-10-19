namespace LunchLab1018
{
    partial class Form1
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
            this.tbResults = new System.Windows.Forms.TextBox();
            this.Results = new System.Windows.Forms.Label();
            this.btWriteDTF = new System.Windows.Forms.Button();
            this.btReadFile = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbResults
            // 
            this.tbResults.Location = new System.Drawing.Point(60, 12);
            this.tbResults.Multiline = true;
            this.tbResults.Name = "tbResults";
            this.tbResults.Size = new System.Drawing.Size(684, 180);
            this.tbResults.TabIndex = 0;
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Location = new System.Drawing.Point(312, 212);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(55, 17);
            this.Results.TabIndex = 1;
            this.Results.Text = "Results";
            // 
            // btWriteDTF
            // 
            this.btWriteDTF.Location = new System.Drawing.Point(60, 302);
            this.btWriteDTF.Name = "btWriteDTF";
            this.btWriteDTF.Size = new System.Drawing.Size(141, 47);
            this.btWriteDTF.TabIndex = 2;
            this.btWriteDTF.Text = "Write Date To File";
            this.btWriteDTF.UseVisualStyleBackColor = true;
            this.btWriteDTF.Click += new System.EventHandler(this.btWriteDTF_Click);
            // 
            // btReadFile
            // 
            this.btReadFile.Location = new System.Drawing.Point(300, 302);
            this.btReadFile.Name = "btReadFile";
            this.btReadFile.Size = new System.Drawing.Size(168, 47);
            this.btReadFile.TabIndex = 3;
            this.btReadFile.Text = "Read File";
            this.btReadFile.UseVisualStyleBackColor = true;
            this.btReadFile.Click += new System.EventHandler(this.btReadFile_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(569, 302);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(136, 47);
            this.btClear.TabIndex = 4;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btReadFile);
            this.Controls.Add(this.btWriteDTF);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.tbResults);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.Label Results;
        private System.Windows.Forms.Button btWriteDTF;
        private System.Windows.Forms.Button btReadFile;
        private System.Windows.Forms.Button btClear;
    }
}

