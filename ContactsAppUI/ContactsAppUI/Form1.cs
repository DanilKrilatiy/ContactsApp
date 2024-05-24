using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ContactsApp;
using Newtonsoft.Json;
using System.Timers;

namespace ContactsAppUI
{
    public partial class Form1 : Form
    {
        private Проект _currentProject;
        private Менеджер_проекта _projectManager;

        public Form1()
        {
            InitializeComponent();
            _currentProject = new Проект();
            _projectManager = new Менеджер_проекта();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DisplayContacts()
        {
            lstContacts.Items.Clear();
            foreach (var contact in _currentProject.Contacts)
            {
                lstContacts.Items.Add($"{contact.LastName} {contact.FirstName} - {contact.PhoneNumber.Number} - {contact.Email}");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _projectManager.SaveProject(_currentProject);
                MessageBox.Show("Project saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving project: {ex.Message}");
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                _currentProject = _projectManager.LoadProject();
                DisplayContacts();
                MessageBox.Show("Project loaded successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading project: {ex.Message}");
            }
        }

        private void BtnaddContact_Click(object sender, EventArgs e)
        {
            try
            {
                var lastName = txtLastName.Text;
                var firstName = txtfirstName.Text;
                var phoneNumber = new Номер_телефона(txtPhoneNumber.Text);
                var birthDate = dateBirthDate.Text ?? throw new ArgumentException("BirthDate is required");
                var email = txtEmail.Text;
                var vkId = txtVkId.Text;

                var newContact = new Контакт(lastName, firstName, phoneNumber, birthDate, email, vkId);
                _currentProject.AddContact(newContact);
                DisplayContacts();
                ClearInputFields();
                MessageBox.Show("Contact added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding contact: {ex.Message}");
            }
        }

        private void ClearInputFields()
        {
            txtLastName.Clear();
            txtfirstName.Clear();
            txtPhoneNumber.Clear();
            dateBirthDate.Text = null;
            txtEmail.Clear();
            txtVkId.Clear();
        }
    }
}
