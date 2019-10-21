using PiggyBank.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiggyBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Kumbara kumbara = new Kumbara();
        BozukPara bzkPara = new BozukPara();
        // List<string> kumbaradakiParalar = new List<string>();
        // decimal kumbaradakiToplamPara;
        double kumbaradakiToplamParaHacmi;
        //double kumbaradakiFazlaHacim;
        int kirilmaSayisi = 0;
        double paralarinHacmi = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Para Seçiniz...";
            comboBox1.Items.AddRange(Enum.GetNames(typeof(ParaCesitleri)));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            if (kumbaradakiToplamParaHacmi<kumbara.Hacim)
            {
                string secilenPara = comboBox1.Text;
                
                if (secilenPara=="BirKurus"|| secilenPara == "BesKurus" || secilenPara == "OnKurus" || secilenPara == "YirmibesKurus" || secilenPara == "ElliKurus" || secilenPara == "BirLira" )
                {
                    
                    bzkPara.isim = (ParaCesitleri)comboBox1.SelectedIndex;
                    kumbara.ParaEkle(bzkPara);
                    paralarinHacmi += bzkPara.Hacim;

                    kumbaradakiToplamParaHacmi = paralarinHacmi;
                    label4.Text = kumbaradakiToplamParaHacmi.ToString();
                }

                if (secilenPara == "BesLira" || secilenPara == "OnLira" || secilenPara == "YirmiLira" || secilenPara == "ElliLira" || secilenPara == "YuzLira" || secilenPara == "İkiyuzLira")
                {

                    bzkPara.isim = (ParaCesitleri)comboBox1.SelectedIndex;
                    kumbara.ParaEkle(bzkPara);
                    paralarinHacmi += bzkPara.Hacim;

                    kumbaradakiToplamParaHacmi = paralarinHacmi;
                    label4.Text = kumbaradakiToplamParaHacmi.ToString();
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            kumbara.Shake(kumbaradakiToplamParaHacmi);
            paralarinHacmi = kumbaradakiToplamParaHacmi - kumbara.ParaninFazlaHacmi;
            label4.Text = paralarinHacmi.ToString();
            MessageBox.Show(UyariKutuphanesi.HacimGenisletildi());
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            label3.Text = kumbara.Break().ToString();
            kirilmaSayisi++;
            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\..\..\Resources\kumbara1.jpg");
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (kumbara.Durum==KumbaraDurumu.Kirik)
            {
                if (kirilmaSayisi<2)
                {
                    
                    label3.Text = "";
                    kumbara.Durum = KumbaraDurumu.Yapistirilmis;
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\..\..\Resources\kumbara.jpg");
                }
                else
                {
                    MessageBox.Show(UyariKutuphanesi.YapistirmaUyarisi());
                }
            }
            //else if (kumbara.Durum==KumbaraDurumu.Yapistirilmis)
            //{
            //    MessageBox.Show(UyariKutuphanesi.YapistirmaUyarisi());
            //}
            else
            {
                MessageBox.Show("Kumbara kırık değilken yapıştırılamaz!");
            }
        }
    }
}
