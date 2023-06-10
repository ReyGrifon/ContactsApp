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
        private static string _path = $"{_appDataPath}\\Pchelnik\\ContactsApp";

        /// <summary>
        /// Путь к сохраняемому файлу.
        /// </summary>
        private static string _fileName = "\\ContactsApp.notes";

        public string Path
        {
            set
            {
                _path = value;
            }
            get
            {
                return _path;
            }
        }

        public string FileName { get { return _fileName;} }

        /// <summary>
        /// Сохраняет проект по пути _folderPath.
        /// </summary>
        /// <param name="project"></param>
        public void SaveProject(Project project)
        {
            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }
            if (!File.Exists(_path + _fileName)) 
            {
                var fileStream = File.Create(_path + _fileName);
                fileStream.Close();
            }
            File.WriteAllText(_path + _fileName, JsonConvert.SerializeObject(project));
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
                if (!File.Exists(_path + _fileName))
                {
                    return new Project();
                }
                using (StreamReader reader = new StreamReader(_path + _fileName))
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
