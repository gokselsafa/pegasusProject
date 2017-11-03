using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using pegasusProject.Classes;
using MaterialSkin;
using MaterialSkin.Controls;

namespace pegasusProject
{
    public partial class Form1 : MaterialForm
    {
        public string bireyselKurumsalTMS="G";
        public string bireyselKurumsalTahakkuk = "G";
        public string bireyselKurumsalSiebel = "G";
        bool uatMi = false;

        ComboBoxItemItemsTMS cbItemTMS = new ComboBoxItemItemsTMS();
        
        public Form1()
        {
            InitializeComponent();
            var SkinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkinManager.Themes.DARK;
            SkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }


        private void btnGetir_Click(object sender, EventArgs e)
        {
            var source = new BindingSource();

            switch (matTabTMS.SelectedIndex)
            {
                case 0:{
                        if (cbUrun.SelectedIndex >= 0 && cbAltUrun.SelectedIndex >= 0)
                        {
                                TMS tms = new TMS(uatMi);
                            source.DataSource = tms.setDataType(bireyselKurumsalTMS, cbUrun.SelectedIndex, cbAltUrun.SelectedIndex);
                            dataGridView1.DataSource = source;

                            #region
                            /*foreach (DataGridViewRow item in dataGridView1.Columns)
                            {
                                var isNull = item;
                                
                                for(int i=0;i<item;i++)
                                {
                                    if(item.Cells[i] != null)
                                    {
                                        isNull 
                                    }*
                                }*/
#endregion

                        }
                        else
                        {
                            MessageBox.Show("Tüm Alanların Seçilmesi zorunludur.","Uyarı");
                        }
                    }
                    break;
                case 1:
                    {
                        if (cbXDSL.SelectedIndex >= 0 && cbKurumXDSL.SelectedIndex >= 0)
                        {
                            xDSL xDSL = new xDSL(uatMi);
                            source.DataSource = xDSL.setDataTip(cbKurumXDSL.Text, cbXDSL.Text);
                            dGridXDSL.DataSource = source;
                        }
                        else
                        {
                            MessageBox.Show("Tüm Alanların Seçilmesi zorunludur.", "Uyarı");
                        }
                    }break;
                case 2:
                    {
                        if (cbUrunTahakkuk.SelectedIndex >= 0)
                        {
                            Tahakkuk tahakuk = new Tahakkuk(uatMi);
                            source.DataSource = tahakuk.setDataTip(bireyselKurumsalTahakkuk, cbUrunTahakkuk.SelectedIndex);
                            dGridTahakuk.DataSource = source;
                        }
                        else
                        {
                            MessageBox.Show("Tüm Alanların Seçilmesi zorunludur.", "Uyarı");
                        }
                        
                    }
                    break;
                case 3:
                    {
                        if (cbUrunCW.SelectedIndex >= 0)
                        {
                            ConceptWave cW = new ConceptWave(uatMi);
                            source.DataSource = cW.setDataTip();
                            dGridCW.DataSource = source;
                        }
                        else
                        {
                            MessageBox.Show("Tüm Alanların Seçilmesi zorunludur.", "Uyarı");
                        }
                    }
                    break;
                case 4:
                    {
                            Siebel siebel = new Siebel(uatMi);
                            source.DataSource = siebel.setDataTip(bireyselKurumsalSiebel);
                            dGridSiebel.DataSource = source;
                    }break;

            }

            




            foreach (var items in dataGridView1.Columns)
            {
                bool notAvailable = true;

                if (notAvailable)
                {
                    //dataGridView1.Columns[].Visible = false;
                }
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in cbItemTMS.bireysel)
                cbUrun.Items.Add(item);
        }
        
        private void rbBAU_CheckedChanged_1(object sender, EventArgs e)
        {
            uatMi = false;
        }

        private void rbUAT_CheckedChanged_1(object sender, EventArgs e)
        {
            uatMi = true;
        }

        private void rbBireysel_CheckedChanged_1(object sender, EventArgs e)
        {
            bireyselKurumsalTMS = "G";
            cbUrun.Items.Clear();
            cbAltUrun.Items.Clear();
            cbUrun.Text = "";
            cbAltUrun.Text = "";


            foreach (var item in cbItemTMS.bireysel)
                cbUrun.Items.Add(item);
        }

        private void rbKurumsal_CheckedChanged_1(object sender, EventArgs e)
        {
            bireyselKurumsalTMS = "T";
            cbUrun.Items.Clear();
            cbAltUrun.Items.Clear();
            cbUrun.Text= "";
            cbAltUrun.Text = "";

            foreach (var item in cbItemTMS.kurumsal)
                cbUrun.Items.Add(item);
        }
        
        private void cbUrun_SelectedValueChanged(object sender, EventArgs e)
        {
            cbAltUrun.Items.Clear();
            cbUrun.Text = "";
            cbAltUrun.Text = "";

            if (bireyselKurumsalTMS == "T")
            {
                switch (cbUrun.SelectedIndex)
                {
                    case 0: {
                            foreach (var item in cbItemTMS.pstn)
                                cbAltUrun.Items.Add(item);
                        } break;
                    case 1: {
                            foreach (var item in cbItemTMS.isdn)
                                cbAltUrun.Items.Add(item);
                        } break;
                    case 2: {
                            foreach (var item in cbItemTMS.yapa)
                                cbAltUrun.Items.Add(item);
                        } break;
                    case 3: {
                            foreach (var item in cbItemTMS.ggac)
                                cbAltUrun.Items.Add(item);
                        } break;
                }
            }
            else
            {
                switch (cbUrun.SelectedIndex)
                {
                    case 0: {
                            foreach (var item in cbItemTMS.pstn)
                                cbAltUrun.Items.Add(item);
                        } break;
                    case 1: {
                            foreach (var item in cbItemTMS.ortakTesis)
                                cbAltUrun.Items.Add(item);
                        } break;
                }
            }
        }

        private void rbBireyselTahakkuk_CheckedChanged(object sender, EventArgs e)
        {
            bireyselKurumsalTahakkuk = "G";
            cbUrunTahakkuk.Items.Clear();
            cbUrun.Text = "";
            foreach (var item in cbItemTMS.bireyselTahakkuk)
                cbUrunTahakkuk.Items.Add(item);
        }

        private void rbKurumsalTahakkuk_CheckedChanged(object sender, EventArgs e)
        {
            bireyselKurumsalTahakkuk = "T";
            cbUrunTahakkuk.Items.Clear();
            cbUrun.Text = "";
            foreach (var item in cbItemTMS.kurumsalTahakkuk)
                cbUrunTahakkuk.Items.Add(item);
        }

        private void rbBireyselSiebel_CheckedChanged(object sender, EventArgs e)
        {
            bireyselKurumsalSiebel = "G";
        }

        private void rbKurumsalSiebel_CheckedChanged(object sender, EventArgs e)
        {
            bireyselKurumsalSiebel = "T";
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }
    }
}
