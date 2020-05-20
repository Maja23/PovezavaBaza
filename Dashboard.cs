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
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();

        List<Person> peopleID = new List<Person>();

        readonly DataAccess db = new DataAccess();

        public Dashboard()
        {
            InitializeComponent();

            // za napolnjen combobox
            people = db.GetPeople(); //pridobljen podatki iz baze

            foreach (Person a in people) //iz lista prepisem v combobox
            {

                peopleComboBox.Items.Add(a.nazdel.ToString());
            }

            UpdateBinding();
        }

        private void UpdateBinding() //izpisi dejansko na UI
        {
            peopleListBox.DataSource = peopleID;
            peopleListBox.DisplayMember = "FullInfro";

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  DataAccess db = new DataAccess();

            peopleID = db.GetPeopleWithID(nazDelText.Text); //pridobljen podatki iz baze

            UpdateBinding();
        }

      private void potrdi_Click(object sender, EventArgs e) //samo za to da vem katerega je izbral za naprej
       {

           int selectedIndex = peopleComboBox.SelectedIndex;
            Object selectedItem = peopleComboBox.SelectedItem;

            if (selectedIndex == -1)
                MessageBox.Show("Izberi vrednost");
            else
                MessageBox.Show("Selected Item Text: " + selectedItem.ToString()); 

        }
    }
}
