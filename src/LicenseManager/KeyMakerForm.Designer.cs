namespace LicenseManager
{
    partial class KeyMakerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPublic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrivate = new System.Windows.Forms.TextBox();
            this.btnSavePublic = new System.Windows.Forms.Button();
            this.btnSavePrivate = new System.Windows.Forms.Button();
            this.btnRegenerate = new System.Windows.Forms.Button();
            this.btnCopyPublic = new System.Windows.Forms.Button();
            this.btnCopyPrivate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Public Key";
            // 
            // txtPublic
            // 
            this.txtPublic.Location = new System.Drawing.Point(80, 12);
            this.txtPublic.Multiline = true;
            this.txtPublic.Name = "txtPublic";
            this.txtPublic.ReadOnly = true;
            this.txtPublic.Size = new System.Drawing.Size(192, 71);
            this.txtPublic.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Private Key";
            // 
            // txtPrivate
            // 
            this.txtPrivate.Location = new System.Drawing.Point(80, 89);
            this.txtPrivate.Multiline = true;
            this.txtPrivate.Name = "txtPrivate";
            this.txtPrivate.ReadOnly = true;
            this.txtPrivate.Size = new System.Drawing.Size(192, 71);
            this.txtPrivate.TabIndex = 5;
            // 
            // btnSavePublic
            // 
            this.btnSavePublic.Location = new System.Drawing.Point(15, 32);
            this.btnSavePublic.Name = "btnSavePublic";
            this.btnSavePublic.Size = new System.Drawing.Size(59, 23);
            this.btnSavePublic.TabIndex = 2;
            this.btnSavePublic.Text = "Save";
            this.btnSavePublic.UseVisualStyleBackColor = true;
            this.btnSavePublic.Click += new System.EventHandler(this.btnSavePublic_Click);
            // 
            // btnSavePrivate
            // 
            this.btnSavePrivate.Location = new System.Drawing.Point(15, 108);
            this.btnSavePrivate.Name = "btnSavePrivate";
            this.btnSavePrivate.Size = new System.Drawing.Size(59, 23);
            this.btnSavePrivate.TabIndex = 6;
            this.btnSavePrivate.Text = "Save";
            this.btnSavePrivate.UseVisualStyleBackColor = true;
            this.btnSavePrivate.Click += new System.EventHandler(this.btnSavePrivate_Click);
            // 
            // btnRegenerate
            // 
            this.btnRegenerate.Location = new System.Drawing.Point(149, 166);
            this.btnRegenerate.Name = "btnRegenerate";
            this.btnRegenerate.Size = new System.Drawing.Size(123, 23);
            this.btnRegenerate.TabIndex = 8;
            this.btnRegenerate.Text = "Regenerate Keys";
            this.btnRegenerate.UseVisualStyleBackColor = true;
            this.btnRegenerate.Click += new System.EventHandler(this.btnRegenerate_Click);
            // 
            // btnCopyPublic
            // 
            this.btnCopyPublic.Location = new System.Drawing.Point(15, 55);
            this.btnCopyPublic.Name = "btnCopyPublic";
            this.btnCopyPublic.Size = new System.Drawing.Size(59, 23);
            this.btnCopyPublic.TabIndex = 3;
            this.btnCopyPublic.Text = "Copy";
            this.btnCopyPublic.UseVisualStyleBackColor = true;
            this.btnCopyPublic.Click += new System.EventHandler(this.btnCopyPublic_Click);
            // 
            // btnCopyPrivate
            // 
            this.btnCopyPrivate.Location = new System.Drawing.Point(15, 131);
            this.btnCopyPrivate.Name = "btnCopyPrivate";
            this.btnCopyPrivate.Size = new System.Drawing.Size(59, 23);
            this.btnCopyPrivate.TabIndex = 7;
            this.btnCopyPrivate.Text = "Copy";
            this.btnCopyPrivate.UseVisualStyleBackColor = true;
            this.btnCopyPrivate.Click += new System.EventHandler(this.btnCopyPrivate_Click);
            // 
            // KeyMakerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.btnCopyPrivate);
            this.Controls.Add(this.btnCopyPublic);
            this.Controls.Add(this.btnRegenerate);
            this.Controls.Add(this.btnSavePrivate);
            this.Controls.Add(this.btnSavePublic);
            this.Controls.Add(this.txtPrivate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPublic);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KeyMakerForm";
            this.Text = "Key Maker";
            this.Load += new System.EventHandler(this.KeyMakerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPublic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrivate;
        private System.Windows.Forms.Button btnSavePublic;
        private System.Windows.Forms.Button btnSavePrivate;
        private System.Windows.Forms.Button btnRegenerate;
        private System.Windows.Forms.Button btnCopyPublic;
        private System.Windows.Forms.Button btnCopyPrivate;
    }
}