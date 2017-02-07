using System;
using System.Windows.Forms;
using YSSGP.Sınıflar;
using System.Collections.Generic;

namespace YSSGP
{
    public partial class AsilIsverenISGPersonelForm : Form
    {
        private static AsilIsverenISGPersonelForm formum;
        public enum Gorev { İSGUzmanı,İşyeriHekimi}
        private static Gorev _gorev;
        private List<ISGUzmani> uzmanlar = new List<ISGUzmani>();
        private  List<IsyeriHekimi> hekimler=new List<IsyeriHekimi>();
        private static string baslik;
        private ISGUzmani uzman;
        private IsyeriHekimi hekim;
        private static ToolStripStatusLabel aciklamalbl;
        public AsilIsverenISGPersonelForm()
        {
            InitializeComponent();
        }
        private static void BaslikDegistir(string bsl)
        {
            AsilIsverenISGPersonelForm.formum.Text = bsl;
        }
        public static AsilIsverenISGPersonelForm FormuGoster(Gorev gorevi,ToolStripStatusLabel lbl)
        {
            if (formum==null)
            {
                formum = new AsilIsverenISGPersonelForm();
            }
            _gorev = gorevi;
            aciklamalbl = lbl;
            formum.dataGridView2.Rows.Clear();
            formum.dataGridView1.Rows.Clear();
            switch (_gorev)
            {
                case Gorev.İSGUzmanı:
                    baslik = "Asıl İşveren İş Güvenliği Uzmanları";
                    
                    if (Proje.asilisverenisguzmanlari.Count > 0)
                    {
                        formum.uzmanlar = Proje.asilisverenisguzmanlari;
                        formum.uzman = new ISGUzmani();
                        for (int j = 0; j < formum.uzman.gorevvesorumluluklar.Count; j++)
                        {
                            formum.dataGridView2.Rows.Add(formum.uzman.gorevvesorumluluklar[j]);
                        }

                    }
                    else
                    {
                        formum.uzman = new ISGUzmani();
                        for (int j = 0; j < formum.uzman.gorevvesorumluluklar.Count; j++)
                        {
                            formum.dataGridView2.Rows.Add(formum.uzman.gorevvesorumluluklar[j]);
                        }
                    }


                    for (int i = 0; i < formum.uzmanlar.Count; i++)
                    {
                        object[] vals = new object[4];
                        vals[0] = formum.uzmanlar[i].ad;
                        vals[1] = formum.uzmanlar[i].tc;
                        vals[2] = formum.uzmanlar[i].sert;
                        vals[3] = formum.uzmanlar[i].iletişim;
                        formum.dataGridView1.Rows.Add(vals);
                        //for (int j = 0; j < uzmanlar[i].gorevvesorumluluklar.Count; j++)
                        //{
                        //    dataGridView2.Rows.Add(uzmanlar[i].gorevvesorumluluklar[j]);
                        //}
                    }
                    break;
                case Gorev.İşyeriHekimi:
                    baslik = "Asıl İşveren İşyeri Hekimleri";

                    if (Proje.asilisverenisyerihekimleri.Count > 0)
                    {
                        formum.hekimler = Proje.asilisverenisyerihekimleri;
                    }
                    else
                    {
                        formum.hekim = new IsyeriHekimi();
                        for (int j = 0; j < formum.hekim.gorevvesorumluluklar.Count; j++)
                        {
                            formum.dataGridView2.Rows.Add(formum.hekim.gorevvesorumluluklar[j]);
                        }
                    }

                    for (int i = 0; i < formum.hekimler.Count; i++)
                    {
                        object[] vals = new object[4];
                        vals[0] = formum.hekimler[i].ad;
                        vals[1] = formum.hekimler[i].tc;
                        vals[2] = formum.hekimler[i].sert;
                        vals[3] = formum.hekimler[i].iletişim;
                        formum.dataGridView1.Rows.Add(vals);
                        for (int j = 0; j < formum.hekimler[i].gorevvesorumluluklar.Count; j++)
                        {
                            formum.dataGridView2.Rows.Add(formum.hekimler[i].gorevvesorumluluklar[j]);
                        }


                    }
                    break;

                default:
                    break;
            }
            BaslikDegistir(baslik);
            return formum;

        }
        private void AsilIsverenISGPersonelForm_Load(object sender, EventArgs e)
        {
            this.Text = baslik;
             //switch (_gorev)
             //{
             //    case Gorev.İSGUzmanı:
             //        if (Proje.asilisverenisguzmanlari.Count > 0)
             //        {
             //            uzmanlar = Proje.asilisverenisguzmanlari;
             //            uzman = new ISGUzmani();
             //            for (int j = 0; j < uzman.gorevvesorumluluklar.Count; j++)
             //            {
             //                dataGridView2.Rows.Add(uzman.gorevvesorumluluklar[j]);
             //            }

            //        }
            //        else { 
            //            uzman = new ISGUzmani();
            //            for (int j = 0; j < uzman.gorevvesorumluluklar.Count; j++)
            //            {
            //                dataGridView2.Rows.Add(uzman.gorevvesorumluluklar[j]);
            //            }
            //        }


            //        for (int i = 0; i < uzmanlar.Count; i++)
            //        {
            //            object[] vals = new object[4];
            //            vals[0] = uzmanlar[i].ad;
            //            vals[1] = uzmanlar[i].tc;
            //            vals[2] = uzmanlar[i].sert;
            //            vals[3] = uzmanlar[i].iletişim;
            //            dataGridView1.Rows.Add(vals);
            //            //for (int j = 0; j < uzmanlar[i].gorevvesorumluluklar.Count; j++)
            //            //{
            //            //    dataGridView2.Rows.Add(uzmanlar[i].gorevvesorumluluklar[j]);
            //            //}
            //        }
            //        break;
            //    case Gorev.İşyeriHekimi:


            //        if (Proje.asilisverenisyerihekimleri.Count > 0)
            //        {
            //            hekimler = Proje.asilisverenisyerihekimleri; 
            //        }
            //        else
            //        {
            //            hekim = new IsyeriHekimi();
            //            for (int j = 0; j < hekim.gorevvesorumluluklar.Count; j++)
            //            {
            //                dataGridView2.Rows.Add(hekim.gorevvesorumluluklar[j]);
            //            }
            //        }

            //        for (int i = 0; i < hekimler.Count; i++)
            //        {
            //            object[] vals = new object[4];
            //            vals[0] = hekimler[i].ad;
            //            vals[1] = hekimler[i].tc;
            //            vals[2] = hekimler[i].sert;
            //            vals[3] = hekimler[i].iletişim;
            //            dataGridView1.Rows.Add(vals);
            //            for (int j = 0; j < hekimler[i].gorevvesorumluluklar.Count; j++)
            //            {
            //                dataGridView2.Rows.Add(hekimler[i].gorevvesorumluluklar[j]);
            //            }


            //        }
            //        break;

            //    default:
            //        break;
            //}
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            index = dataGridView1.SelectedRows[0].Index;
            switch (_gorev)
            {
                case Gorev.İSGUzmanı:
                    if (dataGridView1.SelectedRows.Count>0)
                    {
                        txtAd.Text = uzmanlar[dataGridView1.SelectedRows[0].Index].ad;
                        txtIletisim.Text = uzmanlar[dataGridView1.SelectedRows[0].Index].iletişim;
                        txtSert.Text = uzmanlar[dataGridView1.SelectedRows[0].Index].sert;
                       // txtTc.Text = uzmanlar[dataGridView1.SelectedRows[0].Index].tc;
                        dataGridView2.Rows.Clear();
                        for (int i = 0; i < uzmanlar[dataGridView1.SelectedRows[0].Index].gorevvesorumluluklar.Count; i++)
                        {
                            dataGridView2.Rows.Add(uzmanlar[dataGridView1.SelectedRows[0].Index].gorevvesorumluluklar[i]);
                        }
                    }
                    break;
                case Gorev.İşyeriHekimi:
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        txtAd.Text = hekimler[dataGridView1.SelectedRows[0].Index].ad;
                        txtIletisim.Text = hekimler[dataGridView1.SelectedRows[0].Index].iletişim;
                        txtSert.Text = hekimler[dataGridView1.SelectedRows[0].Index].sert;
                        //txtTc.Text = hekimler[dataGridView1.SelectedRows[0].Index].tc;
                        dataGridView2.Rows.Clear();
                        for (int i = 0; i < hekimler[dataGridView1.SelectedRows[0].Index].gorevvesorumluluklar.Count; i++)
                        {
                            dataGridView2.Rows.Add(hekimler[dataGridView1.SelectedRows[0].Index].gorevvesorumluluklar[i]);
                        }
                    }
                    break;
                
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (_gorev)
            {
                case Gorev.İSGUzmanı:
                    object[] vals = new object[4];
                    vals[0] = txtAd.Text;
                    vals[1] = "";
                    vals[2] = txtSert.Text;
                    vals[3] = txtIletisim.Text;
                    dataGridView1.Rows.Add(vals);
                    ISGUzmani yeniuzman = new ISGUzmani();
                    yeniuzman.ad = txtAd.Text;
                    yeniuzman.tc ="";
                    yeniuzman.sert = txtSert.Text;
                    yeniuzman.iletişim = txtIletisim.Text;
                    yeniuzman.gorevvesorumluluklar.Clear();
                    for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                    {
                        yeniuzman.gorevvesorumluluklar.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
                    }
                    uzmanlar.Add(yeniuzman);
                    aciklamalbl.Text = yeniuzman.ad + " isimli İş Güvenliği Uzmanı eklendi.";
                    break;
                case Gorev.İşyeriHekimi:
                    object[] vals2 = new object[4];
                    vals2[0] = txtAd.Text;
                    vals2[1] = "";
                    vals2[2] = txtSert.Text;
                    vals2[3] = txtIletisim.Text;
                    dataGridView1.Rows.Add(vals2);
                    IsyeriHekimi yenihekim = new IsyeriHekimi();
                    yenihekim.ad = txtAd.Text;
                    yenihekim.tc = "";
                    yenihekim.sert = txtSert.Text;
                    yenihekim.iletişim = txtIletisim.Text;
                    yenihekim.gorevvesorumluluklar.Clear();
                    for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                    {
                        yenihekim.gorevvesorumluluklar.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
                    }
                    hekimler.Add(yenihekim);
                    aciklamalbl.Text = yenihekim.ad + " isimli İşyeri Heklimi eklendi.";
                    break;
               
                default:
                    break;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (_gorev)
            {
                case Gorev.İSGUzmanı:
                    if (dataGridView1.Rows.Count>0)
                    {
                        //uzmanlar.Clear();
                        //for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        //{
                        //    ISGUzmani yeniuzman = new ISGUzmani();
                        //    yeniuzman.ad = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        //    yeniuzman.tc = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        //    yeniuzman.sert = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        //    yeniuzman.iletişim = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        //    yeniuzman.gorevvesorumluluklar.Clear();
                        //    for (int j = 0; j < dataGridView2.Rows.Count-1; j++)
                        //    {
                        //        yeniuzman.gorevvesorumluluklar.Add(dataGridView2.Rows[j].Cells[0].Value.ToString());
                        //    }
                        //    uzmanlar.Add(yeniuzman);

                        //}
                        Proje.asilisverenisguzmanlari = uzmanlar;
                        aciklamalbl.Text = "Asıl işveren İş Güvenliği Uzmanları listesi kaydedildi.";
                    }
                    
                    break;
                case Gorev.İşyeriHekimi:
                    if (dataGridView1.Rows.Count > 0)
                    {
                        //hekimler.Clear();
                        //for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        //{
                        //    IsyeriHekimi hekim = new IsyeriHekimi();
                        //    hekim.ad = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        //    hekim.tc = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        //    hekim.sert = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        //    hekim.iletişim = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        //    hekim.gorevvesorumluluklar.Clear();
                        //    for (int j = 0; j < dataGridView2.Rows.Count-1; j++)
                        //    {
                        //        hekim.gorevvesorumluluklar.Add(dataGridView2.Rows[j].Cells[0].Value.ToString());
                        //    }
                        //    hekimler.Add(hekim);
                        //}
                        Proje.asilisverenisyerihekimleri = hekimler;
                        aciklamalbl.Text = "Asıl işveren İşyeri Hekimleri listesi kaydedildi.";
                    }
                    
                    break;
               
                default:
                    break;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                switch (_gorev)
                {
                    case Gorev.İSGUzmanı:
                        aciklamalbl.Text = "Asıl işveren İş Güvenliği Uzmanları listesinden +" + uzmanlar[dataGridView1.SelectedRows[0].Index].ad + " silindi.";
                        uzmanlar.RemoveAt(dataGridView1.SelectedRows[0].Index);
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                        break;
                    case Gorev.İşyeriHekimi:
                        aciklamalbl.Text = "Asıl işveren İşyeri Hekimleri listesinden +" + uzmanlar[dataGridView1.SelectedRows[0].Index].ad + " silindi.";
                        hekimler.RemoveAt(dataGridView1.SelectedRows[0].Index);
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                        break;
                    
                    default:
                        break;
                }
                
            }
        }
        int index = -1;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            switch (_gorev)
            {
                case Gorev.İSGUzmanı:
                    dataGridView1.SelectedRows[0].Cells[0].Value = txtAd.Text;
                    dataGridView1.SelectedRows[0].Cells[1].Value = "";
                    dataGridView1.SelectedRows[0].Cells[2].Value = txtSert.Text;
                    dataGridView1.SelectedRows[0].Cells[3].Value = txtIletisim.Text;
                    
                    ISGUzmani yeni = new ISGUzmani();
                    yeni.ad = txtAd.Text;
                    yeni.tc = "";
                    yeni.sert = txtSert.Text;
                    yeni.iletişim = txtIletisim.Text;
                    yeni.gorevvesorumluluklar.Clear();
                    for (int i = 0; i < dataGridView2.Rows.Count-1; i++)
                    {
                        yeni.gorevvesorumluluklar.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
                    }    
                    uzmanlar[index] = yeni;
                    aciklamalbl.Text = yeni.ad+" isimli İş Güvenliği Uzmanı bilgileri güncellendi.";
                    break;
                case Gorev.İşyeriHekimi:
                    dataGridView1.SelectedRows[0].Cells[0].Value = txtAd.Text;
                    dataGridView1.SelectedRows[0].Cells[1].Value = "";
                    dataGridView1.SelectedRows[0].Cells[2].Value = txtSert.Text;
                    dataGridView1.SelectedRows[0].Cells[3].Value = txtIletisim.Text;

                    IsyeriHekimi yenihekim = new IsyeriHekimi();
                    yenihekim.ad = txtAd.Text;
                    yenihekim.tc = "";
                    yenihekim.sert = txtSert.Text;
                    yenihekim.iletişim = txtIletisim.Text;
                    yenihekim.gorevvesorumluluklar.Clear();
                    for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                    {
                        yenihekim.gorevvesorumluluklar.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
                    }
                    hekimler[index] = yenihekim;
                    aciklamalbl.Text = yenihekim.ad + " isimli İşyeri Hekimi bilgileri güncellendi.";
                    break;
                default:
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
