using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_07_2022Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            araclar = new BindingList<ARAC>();
            arabalar = new BindingList<Araba>();
            tekneler = new BindingList<Tekne>();
            motorsikletler = new BindingList<Motorsiklet>();
            bisikletler = new BindingList<Bisiklet>();


            cmbVitesAraba.DataSource = Enum.GetValues(typeof(VitesTuru));
            cmbYakitAraba.DataSource = Enum.GetValues(typeof(YakitTuru));
            cmbYakitTekne.DataSource = Enum.GetValues(typeof(YakitTuru));
            cmbVitesMotor.DataSource = Enum.GetValues(typeof(VitesTuru));
            cmbYakitMotor.DataSource = Enum.GetValues(typeof(YakitTuru));




        }


        BindingList<ARAC> araclar;
        BindingList<Araba> arabalar;
        BindingList<Tekne> tekneler;
        BindingList<Motorsiklet> motorsikletler;
        BindingList<Bisiklet> bisikletler;

        private void Form1_Load(object sender, EventArgs e)
        {
            grpAraba.Enabled = false;
            grpBisiklet.Enabled = false;
            grpMotosiklet.Enabled = false;
            grpTekne.Enabled = false;
            

            lblMotorGucuAraba.Enabled = false;
            txtMotorGucuAraba.Enabled = false;
            lblMotorTekne.Enabled = false;
            txtMotorTekne.Enabled = false;
            txtMotorGucuMotor.Enabled = false;
            lblMotorGucuMotor.Enabled = false;

            btnMotorAraba.Enabled = false;
            btnMotorGucuMotor.Enabled = false;
            btnMotorTekne.Enabled = false;
            


        }
        int index = 0;
        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            btnMotorAraba.Enabled = false;
            btnMotorGucuMotor.Enabled = false;
            btnMotorTekne.Enabled = false;

            lblMotorGucuAraba.Enabled = false;
            txtMotorGucuAraba.Enabled = false;
            lblMotorTekne.Enabled = false;
            txtMotorTekne.Enabled = false;
            txtMotorGucuMotor.Enabled = false;
            lblMotorGucuMotor.Enabled = false;

            ARAC eklenecekArac = new ARAC();
            eklenecekArac.Marka = txtMarkaArac.Text;
            eklenecekArac.Model = txtModelArac.Text;
            eklenecekArac.UretimTarihi = dtpUretimTarihi.Value;
            eklenecekArac.Renk = Color.FromArgb(Convert.ToInt32(nmrR.Value), Convert.ToInt32(nmrG.Value), Convert.ToInt32(nmrB.Value));
            eklenecekArac.KoltukSayisi = nmrKoltukSayisi.Value.ToString();
            araclar.Add(eklenecekArac);
            dgwList.DataSource = araclar;
            if (araclar.Count == 0)
            {
                dgwList.Rows[index].Cells["Renk"].Style.BackColor = eklenecekArac.Renk;
                
            }
            else
            {
                dgwList.Rows[araclar.Count - 1].Cells["Renk"].Style.BackColor = eklenecekArac.Renk;
            }
           

            Temizle(grpArac);

        }

        private void btnBisikletEkle_Click(object sender, EventArgs e)
        {
            btnMotorAraba.Enabled = false;
            btnMotorGucuMotor.Enabled = false;
            btnMotorTekne.Enabled = false;

            lblMotorGucuAraba.Enabled = false;
            txtMotorGucuAraba.Enabled = false;
            lblMotorTekne.Enabled = false;
            txtMotorTekne.Enabled = false;
            txtMotorGucuMotor.Enabled = false;
            lblMotorGucuMotor.Enabled = false;

            Bisiklet eklenecekBisiklet = new Bisiklet();
            eklenecekBisiklet.Marka = txtMarkaArac.Text;
            eklenecekBisiklet.Model = txtModelArac.Text;
            eklenecekBisiklet.UretimTarihi = dtpUretimTarihi.Value;
            eklenecekBisiklet.Renk = Color.FromArgb(Convert.ToInt32(nmrR.Value), Convert.ToInt32(nmrG.Value), Convert.ToInt32(nmrB.Value));
            eklenecekBisiklet.KoltukSayisi = nmrKoltukSayisi.Value.ToString();
            if (chkSeles.Checked)
            {
                eklenecekBisiklet.SelesiVarMi = true;
            }
            else
            {
                eklenecekBisiklet.SelesiVarMi = false;
            }
            if (chkVites.Checked)
            {
                eklenecekBisiklet.VitesiVarMi = true;
            }
            else
            {
                eklenecekBisiklet.VitesiVarMi = false;
            }

            bisikletler.Add(eklenecekBisiklet);
            dgwList.DataSource = bisikletler;
            if (bisikletler.Count == 0)
            {
                dgwList.Rows[index].Cells["Renk"].Style.BackColor = eklenecekBisiklet.Renk;

            }
            else
            {
                dgwList.Rows[bisikletler.Count - 1].Cells["Renk"].Style.BackColor = eklenecekBisiklet.Renk;
            }
            
            Temizle(grpBisiklet);
            Temizle(grpArac);


        }

        private void txtMarkaArac_TextChanged(object sender, EventArgs e)
        {
            
            grpAraba.Enabled = true;
            grpTekne.Enabled = true;
            grpMotosiklet.Enabled = true;
            grpBisiklet.Enabled = true;
        }
        public static void Temizle(GroupBox groupbox)
        {
            foreach (Control ctr in groupbox.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }

                else if (ctr is CheckBox)
                {
                    ((CheckBox)ctr).Checked = false;
                }
                else if (ctr is ComboBox)
                {
                    ((ComboBox)ctr).SelectedIndex = 0;
                }
                else if (ctr is DateTimePicker)
                {
                    ((DateTimePicker)ctr).Value = DateTime.Now;

                }
                else if (ctr is NumericUpDown)
                {
                    ((NumericUpDown)ctr).Value = 0;
                }
            }
        }

        private void btnArabaEkle_Click(object sender, EventArgs e)
        {
            btnMotorAraba.Enabled = false;
            btnMotorGucuMotor.Enabled = false;
            btnMotorTekne.Enabled = false;

            lblMotorGucuAraba.Enabled = false;
            txtMotorGucuAraba.Enabled = false;
            lblMotorTekne.Enabled = false;
            txtMotorTekne.Enabled = false;
            txtMotorGucuMotor.Enabled = false;
            lblMotorGucuMotor.Enabled = false;

            Araba eklenecekAraba = new Araba();
            eklenecekAraba.Marka = txtMarkaArac.Text;
            eklenecekAraba.Model = txtModelArac.Text;
            eklenecekAraba.UretimTarihi = dtpUretimTarihi.Value;
            eklenecekAraba.Renk = Color.FromArgb(Convert.ToInt32(nmrR.Value), Convert.ToInt32(nmrG.Value), Convert.ToInt32(nmrB.Value));
            eklenecekAraba.KoltukSayisi = nmrKoltukSayisi.Value.ToString();
            eklenecekAraba.VitesTuru = (VitesTuru)cmbVitesAraba.SelectedItem;
            eklenecekAraba.YakitTuru = (YakitTuru)cmbYakitAraba.SelectedItem;
            eklenecekAraba.BeygirGucu = Convert.ToDouble(nmrBeygirAraba.Value);
            arabalar.Add(eklenecekAraba);
            dgwList.DataSource = arabalar;
            if (arabalar.Count == 0)
            {
                dgwList.Rows[index].Cells["Renk"].Style.BackColor = eklenecekAraba.Renk;

            }
            else
            {
                dgwList.Rows[arabalar.Count - 1].Cells["Renk"].Style.BackColor = eklenecekAraba.Renk;
            }

            

            Temizle(grpArac);
            Temizle(grpAraba);
           

        }

        private void btnTekneEkle_Click(object sender, EventArgs e)
        {
            btnMotorAraba.Enabled = false;
            btnMotorGucuMotor.Enabled = false;
            btnMotorTekne.Enabled = false;

            lblMotorGucuAraba.Enabled = false;
            txtMotorGucuAraba.Enabled = false;
            lblMotorTekne.Enabled = false;
            txtMotorTekne.Enabled = false;
            txtMotorGucuMotor.Enabled = false;
            lblMotorGucuMotor.Enabled = false;

            Tekne eklenecekTekne = new Tekne();
            eklenecekTekne.Marka = txtMarkaArac.Text;
            eklenecekTekne.Model = txtModelArac.Text;
            eklenecekTekne.UretimTarihi = dtpUretimTarihi.Value;
            eklenecekTekne.Renk = Color.FromArgb(Convert.ToInt32(nmrR.Value), Convert.ToInt32(nmrG.Value), Convert.ToInt32(nmrB.Value));
            eklenecekTekne.KoltukSayisi = nmrKoltukSayisi.Value.ToString();
            eklenecekTekne.YakitTuru = (YakitTuru)cmbYakitAraba.SelectedItem;
            eklenecekTekne.BeygirGucu = Convert.ToDouble(nmrBeygirTekne.Value);
            tekneler.Add(eklenecekTekne);
            dgwList.DataSource = tekneler;
            if (tekneler.Count == 0)
            {
                dgwList.Rows[index].Cells["Renk"].Style.BackColor = eklenecekTekne.Renk;

            }
            else
            {
                dgwList.Rows[tekneler.Count - 1].Cells["Renk"].Style.BackColor = eklenecekTekne.Renk;
            }

            Temizle(grpArac);
            Temizle(grpTekne);

        }

        private void btnMotorEkle_Click(object sender, EventArgs e)
        {
            btnMotorAraba.Enabled = false;
            btnMotorGucuMotor.Enabled = false;
            btnMotorTekne.Enabled = false;

            lblMotorGucuAraba.Enabled = false;
            txtMotorGucuAraba.Enabled = false;
            lblMotorTekne.Enabled = false;
            txtMotorTekne.Enabled = false;
            txtMotorGucuMotor.Enabled = false;
            lblMotorGucuMotor.Enabled = false;

            Motorsiklet eklenecekMotor = new Motorsiklet();
            eklenecekMotor.Marka = txtMarkaArac.Text;
            eklenecekMotor.Model = txtModelArac.Text;
            eklenecekMotor.UretimTarihi = dtpUretimTarihi.Value;
            eklenecekMotor.Renk = Color.FromArgb(Convert.ToInt32(nmrR.Value), Convert.ToInt32(nmrG.Value), Convert.ToInt32(nmrB.Value));
            eklenecekMotor.KoltukSayisi = nmrKoltukSayisi.Value.ToString();
            eklenecekMotor.YakitTuru = (YakitTuru)cmbYakitAraba.SelectedItem;
            eklenecekMotor.VitesTuru = (VitesTuru)cmbVitesMotor.SelectedItem;
            eklenecekMotor.BeygirGucu = Convert.ToDouble(nmrBeygirMotor.Value);
            motorsikletler.Add(eklenecekMotor);
            dgwList.DataSource = motorsikletler;
            if (motorsikletler.Count == 0)
            {
                dgwList.Rows[index].Cells["Renk"].Style.BackColor = eklenecekMotor.Renk;

            }
            else
            {
                dgwList.Rows[motorsikletler.Count - 1].Cells["Renk"].Style.BackColor = eklenecekMotor.Renk;
            }


            Temizle(grpArac);
            Temizle(grpMotosiklet);
        }

        private void dgwList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnMotorAraba.Enabled = false;
            btnMotorGucuMotor.Enabled = false;
            btnMotorTekne.Enabled = false;
            if (dgwList.DataSource == arabalar)
            {
                btnMotorAraba.Enabled = true;
            }
            if (dgwList.DataSource == motorsikletler)
            {
                btnMotorGucuMotor.Enabled = true;
            }
            if (dgwList.DataSource == tekneler)
            {
                btnMotorTekne.Enabled = true;
            }
        }

        private void btnMotorAraba_Click(object sender, EventArgs e)
        {
            lblMotorGucuAraba.Enabled = true;
            txtMotorGucuAraba.Enabled = true;
            int rowIndex = dgwList.CurrentCell.RowIndex;
            double veri = Convert.ToDouble(dgwList.Rows[rowIndex].Cells[0].Value.ToString());
            double motorGucu = MotorGucuHesapla(veri);
            txtMotorGucuAraba.Text = motorGucu.ToString();
            
            btnMotorAraba.Enabled = false;


        }
        public static double MotorGucuHesapla(double _BeygirGucu)
        {
            double guc = _BeygirGucu * 0.745;
            return guc;
        }

        private void btnMotorTekne_Click(object sender, EventArgs e)
        {
            lblMotorTekne.Enabled = true;
            txtMotorTekne.Enabled = true;
            int rowIndex = dgwList.CurrentCell.RowIndex;
            double veri = Convert.ToDouble(dgwList.Rows[rowIndex].Cells[0].Value.ToString());
            double motorGucu = MotorGucuHesapla(veri);
            txtMotorTekne.Text = motorGucu.ToString();

            btnMotorTekne.Enabled = false;


        }

        private void btnMotorGucuMotor_Click(object sender, EventArgs e)
        {
            lblMotorGucuMotor.Enabled = true;
            txtMotorGucuMotor.Enabled = true;
            int rowIndex = dgwList.CurrentCell.RowIndex;
            double veri = Convert.ToDouble(dgwList.Rows[rowIndex].Cells[0].Value.ToString());
            double motorGucu = MotorGucuHesapla(veri);
            txtMotorGucuMotor.Text = motorGucu.ToString();

            btnMotorGucuMotor.Enabled = false;


        }
    }
    
}
