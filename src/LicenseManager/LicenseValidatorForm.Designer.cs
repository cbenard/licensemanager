namespace LicenseManager
{
    partial class LicenseValidatorForm
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
            this.btnValidateLicense = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.txtExpiration = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIsValid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnValidateLicense
            // 
            this.btnValidateLicense.Location = new System.Drawing.Point(75, 329);
            this.btnValidateLicense.Name = "btnValidateLicense";
            this.btnValidateLicense.Size = new System.Drawing.Size(129, 23);
            this.btnValidateLicense.TabIndex = 17;
            this.btnValidateLicense.Text = "Validate License";
            this.btnValidateLicense.UseVisualStyleBackColor = true;
            this.btnValidateLicense.Click += new System.EventHandler(this.btnValidateLicense_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "License";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Public Key";
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.AllowDrop = true;
            this.txtPublicKey.Location = new System.Drawing.Point(75, 8);
            this.txtPublicKey.Multiline = true;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(477, 211);
            this.txtPublicKey.TabIndex = 14;
            this.txtPublicKey.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtPublicKey_DragDrop);
            this.txtPublicKey.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtPublicKey_DragEnter);
            // 
            // txtLicense
            // 
            this.txtLicense.AllowDrop = true;
            this.txtLicense.Location = new System.Drawing.Point(75, 225);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(477, 20);
            this.txtLicense.TabIndex = 16;
            this.txtLicense.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtLicense_DragDrop);
            this.txtLicense.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtLicense_DragEnter);
            // 
            // txtExpiration
            // 
            this.txtExpiration.Location = new System.Drawing.Point(75, 277);
            this.txtExpiration.Name = "txtExpiration";
            this.txtExpiration.Size = new System.Drawing.Size(477, 20);
            this.txtExpiration.TabIndex = 21;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(75, 251);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(477, 20);
            this.txtProduct.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Expiration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Valid";
            // 
            // txtIsValid
            // 
            this.txtIsValid.Location = new System.Drawing.Point(75, 303);
            this.txtIsValid.Name = "txtIsValid";
            this.txtIsValid.Size = new System.Drawing.Size(477, 20);
            this.txtIsValid.TabIndex = 21;
            // 
            // LicenseValidatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 363);
            this.Controls.Add(this.txtIsValid);
            this.Controls.Add(this.txtExpiration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValidateLicense);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPublicKey);
            this.Controls.Add(this.txtLicense);
            this.Name = "LicenseValidatorForm";
            this.Text = "LicenseValidator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidateLicense;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.TextBox txtExpiration;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIsValid;

    }
}