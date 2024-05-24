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
        private const string FilePath = @"C:\Users\Danil\Documents\ContactsApp.notes"; // Modify according to your environment

        public void SaveProject(Проект project)
        {
            string jsonData = JsonConvert.SerializeObject(project, Formatting.Indented);
            File.WriteAllText(FilePath, jsonData);
        }

        public Проект LoadProject()
        {
            if (!File.Exists(FilePath))
                throw new FileNotFoundException("The project file does not exist.");

            string jsonData = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<Проект>(jsonData);
        }
    }
}

        

  

