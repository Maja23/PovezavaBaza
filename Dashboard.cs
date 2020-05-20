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

        public Dashboard()
        {
            InitializeComponent();

            DataAccess db = new DataAccess();

            people = db.GetPeople(nazDelText.Text); //pridobljen podatki iz baze

            foreach (Person a in people) //iz lista prepisem v combobox
            {

                peopleComboBox.Items.Add(a.nazdel.ToString());
            }



            UpdateBinding();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void UpdateBinding() //izpisi dejansko na UI
        {
       /*     peopleListBox.DataSource = people;
            peopleListBox.DisplayMember = "FullInfro";*/

       /*     peopleComboBox.DataSource = people;
            peopleComboBox.DisplayMember = "nazdel"; */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetPeople(nazDelText.Text); //pridobljen podatki iz baze

            foreach (Person a in people) //iz lista prepisem v combobox
            {

                peopleComboBox.Items.Add(a.nazdel.ToString());
            }
            

            UpdateBinding();



            
        }

        private void potrdi_Click(object sender, EventArgs e)
        {

            int selectedIndex = peopleComboBox.SelectedIndex;
            Object selectedItem = peopleComboBox.SelectedItem;



            /*     MessageBox.Show("Selected Item Text: " + selectedItem.ToString() + "\n" +
                        "Index: " + selectedIndex.ToString());*/

            if (selectedIndex == -1)
                MessageBox.Show("Izberi vrednost");
            else
                MessageBox.Show("Selected Item Text: " + selectedItem.ToString());

        }
    }
}
