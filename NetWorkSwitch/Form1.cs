using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetWorkSwitch
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        List<Profile> lesProfilesReseaux;
        BindingSource bs = new BindingSource();
        //[00000000] Realtek PCIe GBE Family Controller
        string nomCarteReseau = "[00000004] Carte Ethernet virtuelle Hyper-V";

        public Form1()
        {
            InitializeComponent();
           InitNetWorkProfile();
           carteReseau.DataSource = IPInfo.GetListCarteReseau();

        }


        public void InitNetWorkProfile()
        {
             lesProfilesReseaux = new List<Profile>();
            
                        Profile leProfileNC = new Profile();
                        leProfileNC.nomProfile = "Bouygues Telecom";
                        leProfileNC.laConfig = new IPConfiguration("192.168.0.12", "255.255.255.0", "192.168.0.243", "8.8.8.8", "4.4.4.4");
            
                        Profile leProfileFree = new Profile();
                        leProfileFree.nomProfile = "Free";
                        leProfileFree.laConfig = new IPConfiguration("192.168.0.12", "255.255.255.0", "192.168.0.242", "212.27.40.240", "212.27.40.241");
            
                        lesProfilesReseaux.Add(leProfileNC);
                        lesProfilesReseaux.Add(leProfileFree);
            
                        bs.DataSource=lesProfilesReseaux;
            
                        cbProfile.DataSource = bs;
            
            
                        //Update actual conf
                        modifierAffichageConfActuelle(IPInfo.GetIP(nomCarteReseau));
            
        }
        public Form1(string nomProfile)
        {
            InitializeComponent();
            InitNetWorkProfile();

            if(lesProfilesReseaux.Where(p=>p.nomProfile.ToUpper()==nomProfile.ToUpper()).Count()>0)
            {
                SetProfileReseau(lesProfilesReseaux.Where(p => p.nomProfile.ToUpper() == nomProfile.ToUpper()).Select(p => p.laConfig).First(), true);
            }
          
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            #if BATCHMODEFREE
                        this.Close();
            #endif

            #if BATCHMODENUMERICABLE
                        this.Close();
            #endif
        }

        private void cbProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            modifierAffichageProfile((Profile)cbProfile.SelectedItem);
        }

        private void modifierAffichageProfile(Profile leProfile)
        {
            lblConfIP.Text=leProfile.laConfig.IpAdresse;
            lblConfNetMask.Text=leProfile.laConfig.Subnet;
            lblConfGateWay.Text=leProfile.laConfig.GateWay;
            lblConfDNS.Text = leProfile.laConfig.DNS1+" "+leProfile.laConfig.DNS2;
        }

        private void modifierAffichageConfActuelle(IPConfiguration laConfig)
        {
            lblActIP.Text = laConfig.IpAdresse;
            lblActNetMask.Text = laConfig.Subnet;
            lblActGateWay.Text = laConfig.GateWay;
            lblActDNS.Text = laConfig.DNS1 + " " + laConfig.DNS2;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SetProfileReseau(((Profile)cbProfile.SelectedItem).laConfig,false);
        }


        private void SetProfileReseau(IPConfiguration laConfig,bool batchMode)
        {
            IPInfo.SetIP(nomCarteReseau, laConfig);
                    modifierAffichageConfActuelle(IPInfo.GetIP(nomCarteReseau));
                       if(batchMode==false)MessageBox.Show("Configuration appliqué");
        }

        private void carteReseau_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomCarteReseau = (string)carteReseau.SelectedItem;
            modifierAffichageConfActuelle(IPInfo.GetIP(nomCarteReseau));
        }
    }
}
