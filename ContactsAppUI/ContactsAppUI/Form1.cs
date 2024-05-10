using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Номер_телефона phoneNumber = new Номер_телефона();
            phoneNumber.Number = 79991234567;

            Контакт contact = new Контакт();
            contact.Name = "John Doe";
            contact.Phone = phoneNumber;

            Проект project = new Проект();
            project.Name = "New Project";
            project.Description = "This is a new project";

            Менеджер_проекта projectManager = new Менеджер_проекта();
            
            // Вызов первого метода
            _ = new Проект() { Name = "New Project" };
            _ = new Контакт() { Name = "John Doe", Phone = new Номер_телефона { Number = 79991234567 } };
            projectManager.AssignProjectToContact(project, contact);

            // Вызов второго метода
            projectManager.AssignProjectToContact("New Project", "Jane Smith", 79998887766);
        }
    }
}
