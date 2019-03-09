namespace BluetoothPoC
{
    partial class frmBluetooth
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
            this.lstDevices = new System.Windows.Forms.ListBox();
            this.btnDiscover = new System.Windows.Forms.Button();
            this.btnGetMAC = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.Pair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDevices
            // 
            this.lstDevices.FormattingEnabled = true;
            this.lstDevices.ItemHeight = 16;
            this.lstDevices.Location = new System.Drawing.Point(17, 16);
            this.lstDevices.Margin = new System.Windows.Forms.Padding(4);
            this.lstDevices.Name = "lstDevices";
            this.lstDevices.Size = new System.Drawing.Size(306, 356);
            this.lstDevices.TabIndex = 0;
            // 
            // btnDiscover
            // 
            this.btnDiscover.Location = new System.Drawing.Point(479, 16);
            this.btnDiscover.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiscover.Name = "btnDiscover";
            this.btnDiscover.Size = new System.Drawing.Size(160, 28);
            this.btnDiscover.TabIndex = 1;
            this.btnDiscover.Text = "&Device Discovery";
            this.btnDiscover.UseVisualStyleBackColor = true;
            this.btnDiscover.Click += new System.EventHandler(this.btnDiscover_Click);
            // 
            // btnGetMAC
            // 
            this.btnGetMAC.Location = new System.Drawing.Point(479, 52);
            this.btnGetMAC.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetMAC.Name = "btnGetMAC";
            this.btnGetMAC.Size = new System.Drawing.Size(160, 28);
            this.btnGetMAC.TabIndex = 2;
            this.btnGetMAC.Text = "Get &MAC Address";
            this.btnGetMAC.UseVisualStyleBackColor = true;
            this.btnGetMAC.Click += new System.EventHandler(this.btnGetMAC_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(479, 88);
            this.btnSendFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(160, 28);
            this.btnSendFile.TabIndex = 3;
            this.btnSendFile.Text = "&Send File";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(479, 124);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 28);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Pair
            // 
            this.Pair.Location = new System.Drawing.Point(479, 170);
            this.Pair.Name = "Pair";
            this.Pair.Size = new System.Drawing.Size(160, 31);
            this.Pair.TabIndex = 5;
            this.Pair.Text = "Pair";
            this.Pair.UseVisualStyleBackColor = true;
            this.Pair.Visible = false;
            this.Pair.Click += new System.EventHandler(this.Pair_Click);
            // 
            // frmBluetooth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 682);
            this.Controls.Add(this.Pair);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.btnGetMAC);
            this.Controls.Add(this.btnDiscover);
            this.Controls.Add(this.lstDevices);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBluetooth";
            this.Text = "Bluetooth";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDevices;
        private System.Windows.Forms.Button btnDiscover;
        private System.Windows.Forms.Button btnGetMAC;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button Pair;
    }
}

