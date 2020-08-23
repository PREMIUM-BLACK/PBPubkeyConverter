namespace PBPubkeyConverter
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPublicKeyIn = new System.Windows.Forms.TextBox();
            this.bnConvert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConverted = new System.Windows.Forms.TextBox();
            this.llLink = new System.Windows.Forms.LinkLabel();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "This easy tool let you \"convert\" a non xpub public key to any other key which is " +
    "supported.";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(505, 60);
            this.label2.TabIndex = 0;
            this.label2.Text = "There is no magic behind, cause you have to replace the first 4 bytes with the on" +
    "es of the one you want to convert to. You just have to take about that Base64 en" +
    "coding.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "The public key to convert:";
            // 
            // txtPublicKeyIn
            // 
            this.txtPublicKeyIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPublicKeyIn.Location = new System.Drawing.Point(11, 149);
            this.txtPublicKeyIn.Multiline = true;
            this.txtPublicKeyIn.Name = "txtPublicKeyIn";
            this.txtPublicKeyIn.Size = new System.Drawing.Size(505, 71);
            this.txtPublicKeyIn.TabIndex = 2;
            // 
            // bnConvert
            // 
            this.bnConvert.Location = new System.Drawing.Point(10, 270);
            this.bnConvert.Name = "bnConvert";
            this.bnConvert.Size = new System.Drawing.Size(64, 20);
            this.bnConvert.TabIndex = 3;
            this.bnConvert.Text = "Convert";
            this.bnConvert.UseVisualStyleBackColor = true;
            this.bnConvert.Click += new System.EventHandler(this.bnConvert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "The converted result:";
            // 
            // txtConverted
            // 
            this.txtConverted.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConverted.Location = new System.Drawing.Point(10, 328);
            this.txtConverted.Multiline = true;
            this.txtConverted.Name = "txtConverted";
            this.txtConverted.Size = new System.Drawing.Size(505, 71);
            this.txtConverted.TabIndex = 2;
            // 
            // llLink
            // 
            this.llLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llLink.AutoSize = true;
            this.llLink.Location = new System.Drawing.Point(149, 462);
            this.llLink.Name = "llLink";
            this.llLink.Size = new System.Drawing.Size(266, 13);
            this.llLink.TabIndex = 4;
            this.llLink.TabStop = true;
            this.llLink.Text = "powered by PREMIUM BLACK (https://premium.black)";
            this.llLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLink_LinkClicked);
            // 
            // cmbTypes
            // 
            this.cmbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Location = new System.Drawing.Point(73, 237);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(139, 21);
            this.cmbTypes.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Convert to:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(10, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(506, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Huge thanks to NBitcoin (https://github.com/MetacoSA/NBitcoin)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 483);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTypes);
            this.Controls.Add(this.llLink);
            this.Controls.Add(this.bnConvert);
            this.Controls.Add(this.txtConverted);
            this.Controls.Add(this.txtPublicKeyIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "PREMIUM BLACK Pubkey Converter";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPublicKeyIn;
        private System.Windows.Forms.Button bnConvert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConverted;
        private System.Windows.Forms.LinkLabel llLink;
        private System.Windows.Forms.ComboBox cmbTypes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

