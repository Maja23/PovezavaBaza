using PovezavaBaza.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PovezavaBaza
{
    public partial class DelovniNalog : Form
    {
        List<NalogGlava> Nalog_glava = new List<NalogGlava>();
        List<NalogPostavke> Nalog_postavke = new List<NalogPostavke>();
        List<SifraArtikli> Sifra_Artikli = new List<SifraArtikli>();
        List<TehnoloskiPostopkiPOS> Tehnoloski_potopki_POS = new List<TehnoloskiPostopkiPOS>();
        List<TehnoloskiPostopki> Tehnoloski_potopki = new List<TehnoloskiPostopki>();



        readonly DataAccess db = new DataAccess();

        public DelovniNalog()
        {
            InitializeComponent();

            UpdateBinding();
        }


        private void UpdateBinding() //izpisi dejansko na UI
        {
            podatkiListBox.DataSource = Tehnoloski_potopki;
            podatkiListBox.DisplayMember = "FullInfro";

        }

        private void DN_button_Click(object sender, EventArgs e) //glede na st.naloga najdi postavke na nalogu
        {
            string st_nalog = DN_textbox.Text;

            db.SifraBlaga(st_nalog);

        }

        private void podatkiButton_Click(object sender, EventArgs e)
        {
            Tehnoloski_potopki = db.TehnoloskiPostopki();

            UpdateBinding();
        }

        private void brisiButton_Click(object sender, EventArgs e)
        {
            DN_textbox.Clear();
            kodaKupca_listBox.Items.Clear();
        }
    }
}
