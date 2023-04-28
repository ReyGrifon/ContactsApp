using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ContactsApp.Model
{
    internal class ProjectManager
    {
        /// <summary>
        /// путь к папке appData
        /// </summary>
        private static string _appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        /// <summary>
        /// путь к сохраняемому файлу
        /// </summary>
        private static string _pathFile = $@"{_appDataPath}\Pchelnik\ContactsApp\ContactsApp.notes";

        /// <summary>
        /// Сохраняет проект по пути _pathFile
        /// </summary>
        /// <param name="project"></param>
        public void SaveProject(Project project)
        {
            if (!Directory.Exists(_pathFile))
            {
                Directory.CreateDirectory(_pathFile);
            }
            File.WriteAllText(_pathFile, JsonConvert.SerializeObject(project));
        }

        /// <summary>
        /// Загружает данные из пути _pathFile
        /// </summary>
        /// <returns></returns>
        public Project LoadProject()
        {
            Project project;
            using(StreamReader reader = new StreamReader(_pathFile)) 
            {
                string jsonData = reader.ReadToEnd();

                project = JsonConvert.DeserializeObject<Project>(jsonData);
            }
            return project;
        }

    }
}
