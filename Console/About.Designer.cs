namespace PowerSDR
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSwVersion = new System.Windows.Forms.LabelTS();
            this.lblGenesis = new System.Windows.Forms.Label();
            this.lblRadioModel = new System.Windows.Forms.LabelTS();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblBoot_version = new System.Windows.Forms.LabelTS();
            this.lblBoot = new System.Windows.Forms.Label();
            this.lblSerialNumber = new System.Windows.Forms.LabelTS();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.lblFirm_version = new System.Windows.Forms.LabelTS();
            this.labelTS1 = new System.Windows.Forms.LabelTS();
            this.lblPowerSDR = new System.Windows.Forms.Label();
            this.lblFIRMWARE = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonOK.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonOK.Location = new System.Drawing.Point(161, 412);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(92, 37);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSwVersion);
            this.groupBox1.Controls.Add(this.lblGenesis);
            this.groupBox1.Controls.Add(this.lblRadioModel);
            this.groupBox1.Controls.Add(this.lblModel);
            this.groupBox1.Controls.Add(this.lblBoot_version);
            this.groupBox1.Controls.Add(this.lblBoot);
            this.groupBox1.Controls.Add(this.lblSerialNumber);
            this.groupBox1.Controls.Add(this.lblSerialNo);
            this.groupBox1.Controls.Add(this.lblFirm_version);
            this.groupBox1.Controls.Add(this.labelTS1);
            this.groupBox1.Controls.Add(this.lblPowerSDR);
            this.groupBox1.Controls.Add(this.lblFIRMWARE);
            this.groupBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.groupBox1.Location = new System.Drawing.Point(25, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 365);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblSwVersion
            // 
            this.lblSwVersion.AutoSize = true;
            this.lblSwVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwVersion.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblSwVersion.Image = null;
            this.lblSwVersion.Location = new System.Drawing.Point(105, 54);
            this.lblSwVersion.Name = "lblSwVersion";
            this.lblSwVersion.Size = new System.Drawing.Size(146, 24);
            this.lblSwVersion.TabIndex = 13;
            this.lblSwVersion.Text = "Version: **.*.**";
            this.lblSwVersion.Click += new System.EventHandler(this.GSDR_revision_Click);
            // 
            // lblGenesis
            // 
            this.lblGenesis.AutoSize = true;
            this.lblGenesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenesis.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblGenesis.Location = new System.Drawing.Point(39, 22);
            this.lblGenesis.Name = "lblGenesis";
            this.lblGenesis.Size = new System.Drawing.Size(272, 25);
            this.lblGenesis.TabIndex = 2;
            this.lblGenesis.Text = "Genesis 2.1 by YT7PWR";
            this.lblGenesis.Click += new System.EventHandler(this.lblGenesis_Click);
            // 
            // lblRadioModel
            // 
            this.lblRadioModel.AutoSize = true;
            this.lblRadioModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadioModel.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblRadioModel.Image = null;
            this.lblRadioModel.Location = new System.Drawing.Point(129, 165);
            this.lblRadioModel.Name = "lblRadioModel";
            this.lblRadioModel.Size = new System.Drawing.Size(97, 20);
            this.lblRadioModel.TabIndex = 12;
            this.lblRadioModel.Text = "Genesis G**";
            this.lblRadioModel.Click += new System.EventHandler(this.lblRadioModel_Click);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblModel.Location = new System.Drawing.Point(110, 136);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(134, 24);
            this.lblModel.TabIndex = 11;
            this.lblModel.Text = "Radio model:";
            this.lblModel.Click += new System.EventHandler(this.lblModel_Click);
            // 
            // lblBoot_version
            // 
            this.lblBoot_version.AutoSize = true;
            this.lblBoot_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoot_version.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblBoot_version.Image = null;
            this.lblBoot_version.Location = new System.Drawing.Point(155, 219);
            this.lblBoot_version.Name = "lblBoot_version";
            this.lblBoot_version.Size = new System.Drawing.Size(44, 20);
            this.lblBoot_version.TabIndex = 10;
            this.lblBoot_version.Text = "0.0.0";
            this.lblBoot_version.Click += new System.EventHandler(this.lblBoot_version_Click);
            // 
            // lblBoot
            // 
            this.lblBoot.AutoSize = true;
            this.lblBoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoot.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblBoot.Location = new System.Drawing.Point(111, 190);
            this.lblBoot.Name = "lblBoot";
            this.lblBoot.Size = new System.Drawing.Size(132, 24);
            this.lblBoot.TabIndex = 9;
            this.lblBoot.Text = "Boot version:";
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNumber.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblSerialNumber.Image = null;
            this.lblSerialNumber.Location = new System.Drawing.Point(159, 327);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(36, 20);
            this.lblSerialNumber.TabIndex = 8;
            this.lblSerialNumber.Text = "000";
            this.lblSerialNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNo.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblSerialNo.Location = new System.Drawing.Point(104, 298);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(147, 24);
            this.lblSerialNo.TabIndex = 7;
            this.lblSerialNo.Text = "Serial number:";
            // 
            // lblFirm_version
            // 
            this.lblFirm_version.AutoSize = true;
            this.lblFirm_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirm_version.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblFirm_version.Image = null;
            this.lblFirm_version.Location = new System.Drawing.Point(155, 273);
            this.lblFirm_version.Name = "lblFirm_version";
            this.lblFirm_version.Size = new System.Drawing.Size(44, 20);
            this.lblFirm_version.TabIndex = 6;
            this.lblFirm_version.Text = "0.0.0";
            // 
            // labelTS1
            // 
            this.labelTS1.AutoSize = true;
            this.labelTS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTS1.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelTS1.Image = null;
            this.labelTS1.Location = new System.Drawing.Point(115, 109);
            this.labelTS1.Name = "labelTS1";
            this.labelTS1.Size = new System.Drawing.Size(125, 20);
            this.labelTS1.TabIndex = 4;
            this.labelTS1.Text = "from Flex Radio)";
            // 
            // lblPowerSDR
            // 
            this.lblPowerSDR.AutoSize = true;
            this.lblPowerSDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerSDR.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblPowerSDR.Location = new System.Drawing.Point(94, 85);
            this.lblPowerSDR.Name = "lblPowerSDR";
            this.lblPowerSDR.Size = new System.Drawing.Size(167, 20);
            this.lblPowerSDR.TabIndex = 3;
            this.lblPowerSDR.Text = "(based on PowerSDR ";
            // 
            // lblFIRMWARE
            // 
            this.lblFIRMWARE.AutoSize = true;
            this.lblFIRMWARE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFIRMWARE.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblFIRMWARE.Location = new System.Drawing.Point(89, 244);
            this.lblFIRMWARE.Name = "lblFIRMWARE";
            this.lblFIRMWARE.Size = new System.Drawing.Size(177, 24);
            this.lblFIRMWARE.TabIndex = 1;
            this.lblFIRMWARE.Text = "Firmware version:";
            // 
            // About
            // 
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(407, 461);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(423, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(423, 500);
            this.Name = "About";
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGenesis;
        private System.Windows.Forms.Label lblFIRMWARE;
        private System.Windows.Forms.Label lblPowerSDR;
        private System.Windows.Forms.LabelTS labelTS1;
        private System.Windows.Forms.LabelTS lblFirm_version;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.LabelTS lblSerialNumber;
        private System.Windows.Forms.LabelTS lblBoot_version;
        private System.Windows.Forms.Label lblBoot;
        private System.Windows.Forms.LabelTS lblRadioModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.LabelTS lblSwVersion;
    }
}