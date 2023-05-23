using System;
using Newtonsoft.Json;

namespace ContactsApp.Model
{
    public class ProjectManager
    {
        /// <summary>
        /// Путь к папке appData.
        /// </summary>
        private static string _appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        /// <summary>
        /// Путь к сохраняемой папке.
        /// </summary>
        private static string _folderPath = $"{_appDataPath}\\Pchelnik\\ContactsApp";

        /// <summary>
        /// Путь к сохраняемому файлу.
        /// </summary>
        private static string _filePath = _folderPath + "\\ContactsApp.notes";

        /// <summary>
        /// Сохраняет проект по пути _folderPath.
        /// </summary>
        /// <param name="project"></param>
        public void SaveProject(Project project)
        {
            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }
            if (!File.Exists(_filePath)) 
            {
                var fileStream = File.Create(_filePath);
                fileStream.Close();
            }
            File.WriteAllText(_filePath, JsonConvert.SerializeObject(project));
        }

        /// <summary>
        /// Загружает данные из пути _folderPath.
        /// </summary>
        /// <returns></returns>
        public Project LoadProject()
        {
            try
            {
                Project project;
                if (!File.Exists(_filePath))
                {
                    return new Project();
                }
                using (StreamReader reader = new StreamReader(_filePath))
                {
                    string jsonData = reader.ReadToEnd();
                    project = JsonConvert.DeserializeObject<Project>(jsonData);
                }
                return project ?? new Project();
            }
            catch (Exception e)
            {
                return new Project();
            }

        }

    }
}
