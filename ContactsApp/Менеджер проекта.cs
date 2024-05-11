using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ContactsApp
{
    public class Менеджер_проекта
    {
        private static string filePath = @"C:\Users\Danil\Documents\ContactsApp.notes";

        public static void SaveProject(Проект project)
        {
            string json = JsonConvert.SerializeObject(project, Formatting.Indented);
            try
            {
                File.WriteAllText(filePath, json);
                Console.WriteLine("Project saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving project: " + ex.Message);
            }
        }

        public static Проект LoadProject()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    Проект project = JsonConvert.DeserializeObject<Проект>(json);
                    Console.WriteLine("Project loaded successfully.");
                    return project;
                }
                else
                {
                    Console.WriteLine("Project file not found.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading project: " + ex.Message);
                return null;
            }
        }

        public void AssignProjectToContact(Проект project, Контакт contact)
        {
            Console.WriteLine("Assigned project '{0}' to contact {1} with phone number {2}", project.Name, contact.Name, contact.Phone.Number);
        }

        public void AssignProjectToContact(string projectName, string contactName, long phoneNumber)
        {
            Проект project = new Проект() { Name = projectName };

            Контакт contact = new Контакт()
            {
                Name = contactName,
                Phone = new Номер_телефона { Number = phoneNumber }
            };

            AssignProjectToContact(project, contact);
        }
    }

    class Program
    {
        public static void Main()
        {
            Проект projectToSave = new Проект { Name = "Sample Project", Description = "" };

            Менеджер_проекта.SaveProject(projectToSave);

            Проект loadedProject = Менеджер_проекта.LoadProject();

            if (loadedProject != null)
            {
                Console.WriteLine(loadedProject);
            }
        }
    }
} 

