namespace TES3MP_ServerManager
{
    partial class Main
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
            this.LBIPs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BConnect = new System.Windows.Forms.Button();
            this.BDelete = new System.Windows.Forms.Button();
            this.TBIP = new System.Windows.Forms.TextBox();
            this.BAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBIPs
            // 
            this.LBIPs.FormattingEnabled = true;
            this.LBIPs.Location = new System.Drawing.Point(12, 25);
            this.LBIPs.Name = "LBIPs";
            this.LBIPs.Size = new System.Drawing.Size(273, 147);
            this.LBIPs.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servers";
            // 
            // BConnect
            // 
            this.BConnect.Location = new System.Drawing.Point(12, 206);
            this.BConnect.Name = "BConnect";
            this.BConnect.Size = new System.Drawing.Size(75, 23);
            this.BConnect.TabIndex = 2;
            this.BConnect.Text = "Connect";
            this.BConnect.UseVisualStyleBackColor = true;
            this.BConnect.Click += new System.EventHandler(this.BConnect_Click);
            // 
            // BDelete
            // 
            this.BDelete.Location = new System.Drawing.Point(210, 235);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(75, 23);
            this.BDelete.TabIndex = 3;
            this.BDelete.Text = "Delete";
            this.BDelete.UseVisualStyleBackColor = true;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // TBIP
            // 
            this.TBIP.Location = new System.Drawing.Point(12, 180);
            this.TBIP.Name = "TBIP";
            this.TBIP.Size = new System.Drawing.Size(273, 20);
            this.TBIP.TabIndex = 4;
            this.TBIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBIP_KeyDown);
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(210, 206);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(75, 23);
            this.BAdd.TabIndex = 5;
            this.BAdd.Text = "Add";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 272);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.TBIP);
            this.Controls.Add(this.BDelete);
            this.Controls.Add(this.BConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBIPs);
            this.Name = "Main";
            this.Text = "TES3MP-FTC-IPLIST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBIPs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BConnect;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.TextBox TBIP;
        private System.Windows.Forms.Button BAdd;
    }
}

