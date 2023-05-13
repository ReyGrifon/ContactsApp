using System;
using Newtonsoft.Json;

namespace ContactsApp.Model
{
    public class ProjectManager
    {
        /// <summary>
        /// путь к папке appData
        /// </summary>
        private static string _appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        /// <summary>
        /// путь к сохраняемой папке
        /// </summary>
        private static string _docPath = $"{_appDataPath}\\Pchelnik\\ContactsApp";

        /// <summary>
        /// путь к сохраняемому файлу
        /// </summary>
        private static string _filePath = _docPath + "\\ContactsApp.notes";

        /// <summary>
        /// Сохраняет проект по пути _docPath
        /// </summary>
        /// <param name="project"></param>
        public void SaveProject(Project project)
        {
            if (!Directory.Exists(_docPath))
            {
                Directory.CreateDirectory(_docPath);
            }
            File.WriteAllText(_filePath, JsonConvert.SerializeObject(project));
        }

        /// <summary>
        /// Загружает данные из пути _docPath
        /// </summary>
        /// <returns></returns>
        public Project LoadProject()
        {
            try
            {
                Project project;
                JsonSerializer serializer = new JsonSerializer();
                if (!Directory.Exists(_docPath))
                {
                    Directory.CreateDirectory(_docPath);
                }
                if (!File.Exists(_filePath))
                {
                    var fileStream = File.Create(_filePath);
                    fileStream.Close();
                }
                using (StreamReader reader = new StreamReader(_filePath))
                {
                    string jsonData = reader.ReadToEnd();
                    project = JsonConvert.DeserializeObject<Project>(jsonData);
                }
                return project ?? new Project();
            }
            catch (Exception ex)
            {
                return new Project();
            }

        }

    }
}
