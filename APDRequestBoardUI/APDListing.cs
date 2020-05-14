using APDRequestBoardLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APDRequestBoardUI
{
    public partial class APDListing : Form
    {
        List<ComboBox> RAPDItemList = new List<ComboBox>();
        List<ComboBox> PAPDItemList = new List<ComboBox>();
        List<NumericUpDown> RAPDItemCount = new List<NumericUpDown>();
        List<NumericUpDown> PAPDItemCount = new List<NumericUpDown>();

        public APDListing()
        {
            InitializeComponent();
            LoadDataToListBox(GlobalConfig.Connections[0].ReadAllPersonData());
        }

        private void APDListing_Load(object sender, EventArgs e)
        {

            RAPDItemList.Add(RAPDItem1);
            RAPDItemList.Add(RAPDItem2);
            RAPDItemList.Add(RAPDItem3);
            RAPDItemList.Add(RAPDItem4);

            PAPDItemList.Add(PAPDItem1);
            PAPDItemList.Add(PAPDItem2);
            PAPDItemList.Add(PAPDItem3);
            PAPDItemList.Add(PAPDItem4);


            RAPDItemCount.Add(numericUpDown1);
            RAPDItemCount.Add(numericUpDown2);
            RAPDItemCount.Add(numericUpDown3);
            RAPDItemCount.Add(numericUpDown4);

            PAPDItemCount.Add(numericUpDown5);
            PAPDItemCount.Add(numericUpDown6);
            PAPDItemCount.Add(numericUpDown7);
            PAPDItemCount.Add(numericUpDown8);

            foreach (ComboBox combo in RAPDItemList)
            {
                PrepareComboBox(combo);
            }

            foreach(ComboBox combo in PAPDItemList)
            {
                PrepareComboBox(combo);
            }
        }

        private void PrepareComboBox(ComboBox combobox)
        {
            combobox.Items.Add("Masker");
            combobox.Items.Add("Pelindung Mata");
            combobox.Items.Add("Pelindung Wajah");
            combobox.Items.Add("Gaun Medis");
            combobox.Items.Add("Sarung Tangan Medis");
            combobox.Items.Add("Penutup Kepala");
            combobox.Items.Add("Sepatu Pelindung");

            combobox.SelectedItem = null;
            combobox.SelectedText = "--Pilih jenis APD--";
        }        



        private void RAPDItem1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Person person = new Person();
                Person dboutput = new Person();

                person.Name = PersonName.Text;
                person.Address = PersonAddress.Text;
                person.PhoneNumber = PersonPhoneNumber.Text;
                person.Email = PersonEmail.Text;

                person = InsertAPDList(person);

                foreach(IDataConnection db in GlobalConfig.Connections)
                {
                    dboutput = db.InputPerson(person);
                    LoadDataToListBox(db.ReadAllPersonData());
                }

                if (dboutput.Id != 0)
                {
                    PersonName.Text = "";
                    PersonAddress.Text = "";
                    PersonPhoneNumber.Text = "";
                    PersonEmail.Text = "";
                    foreach(ComboBox item in RAPDItemList)
                    {
                        item.SelectedItem = null;
                    }

                    foreach (ComboBox item in PAPDItemList)
                    {
                        item.SelectedItem = null;
                    }

                    foreach(NumericUpDown item in RAPDItemCount) item.Value = 0;
                    foreach (NumericUpDown item in PAPDItemCount) item.Value = 0;
                }
            }
        }

        private void LoadDataToListBox(List<Person> list)
        {
            apdListBox.Items.Clear();

            foreach(Person person in list)
            {
                string required = "";
                string provided = "";
                foreach(HealthEquipment item in person.Request) required += " - " + getCategoryName(item.Category) + ": " + item.EquipmentCount.ToString() + " Unit\n";
                foreach (HealthEquipment item in person.Providing) provided += " - " + getCategoryName(item.Category) + ": " + item.EquipmentCount.ToString() + " Unit\n";
                apdListBox.Items.Add(
                    "\n" + 
                    "Nama      : " + person.Name + "\n" +
                    "Alamat    : " + person.Address + "\n" +
                    "Nomor HP  : " + person.PhoneNumber + "\n" +
                    "Email     : " + person.Email + "\n\n" +
                    "Daftar APD yang dibutuhkan : \n" +
                    required + "\n" +
                    "Daftar APD yang disediakan: \n" +
                    provided
                    );
            }
        }

        private string getCategoryName(int category)
        {
            switch (category)
            {
                case 1:
                    return "Masker";
                case 2:
                    return "Pelindung Mata";
                case 3:
                    return "Pelindung Wajah";
                case 4:
                    return "Gaun Medis";
                case 5:
                    return "Gaun Medis";
                case 6:
                    return "Penutup Kepala";
                case 7:
                    return "Sepatu Pelindung";
                default:
                    return "Masker";
            }
        }

        private Person InsertAPDList(Person person)
        {
            List<HealthEquipment> requestedAPD = new List<HealthEquipment>();
            List<HealthEquipment> providedAPD = new List<HealthEquipment>();
           
            for(int i = 0; i < RAPDItemList.Count; i++)
            {
                if(RAPDItemList[i].SelectedItem != null)
                {
                    if(Convert.ToInt32(RAPDItemCount[i].Value) != 0)
                    {
                        requestedAPD.Add(new HealthEquipment(
                                    GetSelectedCategory(RAPDItemList[i]),
                                    Convert.ToInt32(RAPDItemCount[i].Value)
                                    ));
                    }
                }
            }

            for (int i = 0; i < PAPDItemList.Count; i++)
            {
                if (PAPDItemList[i].SelectedItem != null)
                {
                    if (Convert.ToInt32(PAPDItemCount[i].Value) != 0)
                    {
                        providedAPD.Add(new HealthEquipment(
                                    GetSelectedCategory(PAPDItemList[i]),
                                    Convert.ToInt32(PAPDItemCount[i].Value)
                                    ));
                    }
                }
            }

            person.Request = requestedAPD;
            person.Providing = providedAPD;

            return person;
        }

        private int GetSelectedCategory(ComboBox selectedItem)
        {
            switch (selectedItem.SelectedItem)
            {
                case "Masker":
                    return 1;
                case "Pelindung Mata":
                    return 2;
                case "Pelindung Wajah":
                    return 3;
                case "Gaun Medis":
                    return 4;
                case "Sarung Tangan Medis":
                    return 5;
                case "Penutup Kepala":
                    return 6;
                case "Sepatu Pelindung":
                    return 7;
                default:
                    return 1;
            }
        }
        private bool ValidateForm()
        {
            bool output = true;

            if (PersonName.Text == "") output = false;
            if (PersonAddress.Text == "") output = false;
            if (PersonPhoneNumber.Text == "") output = false;
            if (PersonEmail.Text == "") output = false;

            return output;
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {


        }

        private void RAPDItem4Count_TextChanged(object sender, EventArgs e)
        {

        }

        private void PersonName_TextChanged(object sender, EventArgs e)
        {

        }

        private void RAPDItem1Count_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
