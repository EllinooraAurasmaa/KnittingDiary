using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin; //Teema

namespace KnittingDiary2
{
    public partial class KnittingDiary : MaterialSkin.Controls.MaterialForm
    {
        public KnittingDiary()
        {
            //muutetaan ulkoasua materialskinillä
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey800, Primary.BlueGrey500, Accent.LightBlue100, TextShade.WHITE);
        }

        private void KnittingDiary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Table' table. You can move, or remove it, as needed.
           this.tableTableAdapter.Fill(this.appData.Table);
            Muokkaa(false);
        }
        private void Muokkaa(bool value)

        {
            txtTyönnimi.Enabled = value;
            txtKenelle.Enabled = value;
            txtKuvaus.Enabled = value;
            txtMateriaali.Enabled = value;

        }

        private void btnUusi_Click(object sender, EventArgs e)
        {
            try
            {
                Muokkaa(true);
                appData.Table.AddTableRow(appData.Table.NewTableRow());
                tableBindingSource.MoveLast(); //Lisää uuden rivin viimeiseksi
                txtTyönnimi.Focus();



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ilmoitus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.Table.RejectChanges(); //Errorin tapahtuessa muutoksia ei tehdä

            }
        }

        private void btnMuokkaa_Click(object sender, EventArgs e)
        {
            Muokkaa(true);
            txtTyönnimi.Focus();
        }

        private void btnPeruuta_Click(object sender, EventArgs e)
        {
            Muokkaa(false);
            tableBindingSource.ResetBindings(false);
        }

        private void btnTallenna_Click(object sender, EventArgs e)
        {
            try
            {
                Muokkaa(false);
                tableBindingSource.EndEdit();
                tableTableAdapter.Update(appData.Table);
                dataGridView1.Refresh();
                txtTyönnimi.Focus();
                MessageBox.Show("Käsityö on tallennettu onnistuneesti.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ilmoitus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.Table.RejectChanges(); //Errorin tapahtuessa muutoksia ei tehdä

            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //enter
            {
                if (MessageBox.Show("Haluatko varmasti poistaa tämän käsityön?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    tableBindingSource.RemoveCurrent(); //varmistetaan haluaako käyttäjä poistaa tietueen

            }

        }

        private void txtEtsi_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
         
           {
                //if (!string.IsNullOrEmpty(txtEtsi.Text)) ;
               
            }
        }

        private void btnEtsi_Click(object sender, EventArgs e)
        {
            {
                string searchValue = txtEtsi.Text;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                tableBindingSource.Filter = string.Format("{0}  ", "Työn nimi", searchValue);
                //here you can do selection if you need

            }
        }

        private void txtTyönnimi_Click(object sender, EventArgs e)
        {

        }
    }
}