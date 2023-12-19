using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiyatro_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tiyatro tiyatro;
        List<Tiyatro> tiyatrolist = new List<Tiyatro>();

        private void Form1_Load(object sender, EventArgs e)
        {
            tiyatrolist.Add(new Tiyatro(1, 120, ("Ben Medea Değilim "), new DateTime(2023, 12, 20), ("Gaziosmanpaşa Sahnesi"), 120, true));
            dgvTiyatro.DataSource = tiyatrolist;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            int sure = Convert.ToInt32(nduSure.Text);
            string ad = cmbAd.Text;
            DateTime tarih = dtpTarih.Value;
            string sahne = cmbSahne.Text;
            int fiyat = Convert.ToInt32(txtFiyat.Text);
            bool muzikal = chkMuzikal.Checked;
            Tiyatro tiyatro = new Tiyatro(id, sure, ad, tarih, sahne, fiyat, muzikal);
            tiyatrolist.Add(tiyatro);
            dgvTiyatro.DataSource = tiyatrolist.ToList();
        }

        private void dgvTiyatro_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvTiyatro.CurrentRow.Cells["id"].Value.ToString();
            cmbAd.Text = dgvTiyatro.CurrentRow.Cells["ad"].Value.ToString();
            nduSure.Text=dgvTiyatro.CurrentRow.Cells["sure"].Value.ToString();
            dtpTarih.Value = (DateTime)dgvTiyatro.CurrentRow.Cells["tarih"].Value;
            cmbSahne.Text = dgvTiyatro.CurrentRow.Cells["sahne"].Value.ToString();
            txtFiyat.Text = dgvTiyatro.CurrentRow.Cells["fiyat"].Value.ToString();
            chkMuzikal.Checked = (bool)dgvTiyatro.CurrentRow.Cells["muzikal"].Value;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilensatir = dgvTiyatro.Rows[0];
            Tiyatro secilentiyatro=secilensatir.DataBoundItem as Tiyatro;
            int id = Convert.ToInt32(txtId.Text);
            int sure = Convert.ToInt32(nduSure.Text);
            string ad = cmbAd.Text;
            DateTime tarih = dtpTarih.Value;
            string sahne = cmbSahne.Text;
            int fiyat = Convert.ToInt32(txtFiyat.Text);
            bool muzikal = chkMuzikal.Checked;
            secilentiyatro.Id = id;
            secilentiyatro.Sure= sure;
            secilentiyatro.Ad = ad;
            secilentiyatro.Tarih = tarih;
            secilentiyatro.Sahne= sahne;
            secilentiyatro.Fiyat= fiyat;
            secilentiyatro.Muzikal= muzikal;
            dgvTiyatro.DataSource=null;
            dgvTiyatro.DataSource = tiyatrolist.ToList();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilensatir = dgvTiyatro.Rows[0];
            Tiyatro secilentiyatro = secilensatir.DataBoundItem as Tiyatro;
            DialogResult result = MessageBox.Show("Seçilen Tiyatro Silisin mi?", "Tiyatro Sil", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                tiyatrolist.Remove(secilentiyatro);
            }

        }
    }
}
        

