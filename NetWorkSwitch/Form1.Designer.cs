namespace NetWorkSwitch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblConfDNS = new DevExpress.XtraEditors.LabelControl();
            this.lblConfGateWay = new DevExpress.XtraEditors.LabelControl();
            this.lblConfNetMask = new DevExpress.XtraEditors.LabelControl();
            this.lblConfIP = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cbProfile = new System.Windows.Forms.ComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblActDNS = new DevExpress.XtraEditors.LabelControl();
            this.lblActGateWay = new DevExpress.XtraEditors.LabelControl();
            this.lblActNetMask = new DevExpress.XtraEditors.LabelControl();
            this.lblActIP = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.carteReseau = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(378, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Profile :";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.lblConfDNS);
            this.groupControl2.Controls.Add(this.lblConfGateWay);
            this.groupControl2.Controls.Add(this.lblConfNetMask);
            this.groupControl2.Controls.Add(this.lblConfIP);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Location = new System.Drawing.Point(378, 46);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(366, 139);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Profile";
            // 
            // lblConfDNS
            // 
            this.lblConfDNS.Location = new System.Drawing.Point(40, 94);
            this.lblConfDNS.Name = "lblConfDNS";
            this.lblConfDNS.Size = new System.Drawing.Size(53, 13);
            this.lblConfDNS.TabIndex = 8;
            this.lblConfDNS.Text = "lblConfDNS";
            // 
            // lblConfGateWay
            // 
            this.lblConfGateWay.Location = new System.Drawing.Point(60, 75);
            this.lblConfGateWay.Name = "lblConfGateWay";
            this.lblConfGateWay.Size = new System.Drawing.Size(78, 13);
            this.lblConfGateWay.TabIndex = 7;
            this.lblConfGateWay.Text = "lblConfGateWay";
            // 
            // lblConfNetMask
            // 
            this.lblConfNetMask.Location = new System.Drawing.Point(61, 53);
            this.lblConfNetMask.Name = "lblConfNetMask";
            this.lblConfNetMask.Size = new System.Drawing.Size(74, 13);
            this.lblConfNetMask.TabIndex = 6;
            this.lblConfNetMask.Text = "lblConfNetMask";
            // 
            // lblConfIP
            // 
            this.lblConfIP.Location = new System.Drawing.Point(75, 36);
            this.lblConfIP.Name = "lblConfIP";
            this.lblConfIP.Size = new System.Drawing.Size(43, 13);
            this.lblConfIP.TabIndex = 5;
            this.lblConfIP.Text = "lblConfIP";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(7, 94);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "DNS :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(7, 75);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Gateway:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 55);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Netmask :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Adresse IP :";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(21, 191);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(723, 36);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Appliquer";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cbProfile
            // 
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Location = new System.Drawing.Point(418, 22);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(326, 21);
            this.cbProfile.TabIndex = 5;
            this.cbProfile.SelectedIndexChanged += new System.EventHandler(this.cbProfile_SelectedIndexChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblActDNS);
            this.groupControl1.Controls.Add(this.lblActGateWay);
            this.groupControl1.Controls.Add(this.lblActNetMask);
            this.groupControl1.Controls.Add(this.lblActIP);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Location = new System.Drawing.Point(21, 46);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(333, 139);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Conf actuelle:";
            // 
            // lblActDNS
            // 
            this.lblActDNS.Location = new System.Drawing.Point(42, 94);
            this.lblActDNS.Name = "lblActDNS";
            this.lblActDNS.Size = new System.Drawing.Size(46, 13);
            this.lblActDNS.TabIndex = 8;
            this.lblActDNS.Text = "lblActDNS";
            // 
            // lblActGateWay
            // 
            this.lblActGateWay.Location = new System.Drawing.Point(60, 75);
            this.lblActGateWay.Name = "lblActGateWay";
            this.lblActGateWay.Size = new System.Drawing.Size(71, 13);
            this.lblActGateWay.TabIndex = 7;
            this.lblActGateWay.Text = "lblActGateWay";
            // 
            // lblActNetMask
            // 
            this.lblActNetMask.Location = new System.Drawing.Point(61, 53);
            this.lblActNetMask.Name = "lblActNetMask";
            this.lblActNetMask.Size = new System.Drawing.Size(67, 13);
            this.lblActNetMask.TabIndex = 6;
            this.lblActNetMask.Text = "lblActNetMask";
            // 
            // lblActIP
            // 
            this.lblActIP.Location = new System.Drawing.Point(75, 36);
            this.lblActIP.Name = "lblActIP";
            this.lblActIP.Size = new System.Drawing.Size(36, 13);
            this.lblActIP.TabIndex = 5;
            this.lblActIP.Text = "lblActIP";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(9, 94);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(27, 13);
            this.labelControl10.TabIndex = 3;
            this.labelControl10.Text = "DNS :";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(7, 75);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(47, 13);
            this.labelControl11.TabIndex = 2;
            this.labelControl11.Text = "Gateway:";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(6, 55);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(48, 13);
            this.labelControl12.TabIndex = 1;
            this.labelControl12.Text = "Netmask :";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(9, 35);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(59, 13);
            this.labelControl13.TabIndex = 0;
            this.labelControl13.Text = "Adresse IP :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(21, 27);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(67, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Carte réseau:";
            // 
            // carteReseau
            // 
            this.carteReseau.FormattingEnabled = true;
            this.carteReseau.Location = new System.Drawing.Point(96, 22);
            this.carteReseau.Name = "carteReseau";
            this.carteReseau.Size = new System.Drawing.Size(258, 21);
            this.carteReseau.TabIndex = 11;
            this.carteReseau.SelectedIndexChanged += new System.EventHandler(this.carteReseau_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 241);
            this.Controls.Add(this.carteReseau);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.cbProfile);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Blueprint";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Form1";
            this.Text = "NetWorkSwitch";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblConfDNS;
        private DevExpress.XtraEditors.LabelControl lblConfGateWay;
        private DevExpress.XtraEditors.LabelControl lblConfNetMask;
        private DevExpress.XtraEditors.LabelControl lblConfIP;
        private System.Windows.Forms.ComboBox cbProfile;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblActDNS;
        private DevExpress.XtraEditors.LabelControl lblActGateWay;
        private DevExpress.XtraEditors.LabelControl lblActNetMask;
        private DevExpress.XtraEditors.LabelControl lblActIP;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.ComboBox carteReseau;

    }
}

