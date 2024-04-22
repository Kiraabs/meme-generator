namespace MemeGenerator
{
    /// <summary>
    /// Обслуживающий класс для файлов шаблонов.
    /// </summary>
    public static class Template
    {
        /// <summary>
        /// Название директории шаблонов.
        /// </summary>
        const string TemplateDirName = "Templates";
        /// <summary>
        /// Корневая директория шаблонов.
        /// </summary>
        static readonly DirectoryInfo dir;
        /// <summary>
        /// Информация о внешнем файле.
        /// </summary>
        static FileInfo? sourceFileInfo;
        /// <summary>
        /// Путь к шаблону, относительно корневой директории.
        /// </summary>
        static string localPath = string.Empty;
        /// <summary>
        /// Директория шаблонов.
        /// </summary>
        public static DirectoryInfo Dir { get => dir; }

        static Template()
        {
            dir = new(TemplateDirName);
            if (!dir.Exists) dir.Create();
        }

        /// <summary>
        /// Проверяет существование внешнего файла в корневой директории шаблонов.
        /// </summary>
        /// <param name="name">Имя внешнего файла.</param>
        /// <returns></returns>
        public static bool Exists(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return false;
            Localize(name);
            return File.Exists(localPath);
        }

        /// <summary>
        /// Создает шаблон в корневой директории.
        /// </summary>
        /// <param name="name">Имя шаблона (внешнего файла).</param>
        /// <returns></returns>
        public static bool Create(string name)
        {
            if (Exists(name))  
            {
                MessageBox.Show
                (
                    "Файл с таким именем уже существует.",
                    "Внимание",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                try
                {
                    File.Copy(name, localPath);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
        }

        /// <summary>
        /// Преобразовывает внешнее имя файла и название директории шаблонов в локальный путь к шаблону.
        /// </summary>
        /// <param name="name"></param>
        static void Localize(string name)
        {
            sourceFileInfo = new FileInfo(name);
            localPath = @$"{TemplateDirName}\{sourceFileInfo.Name}";
        }
    }
}
