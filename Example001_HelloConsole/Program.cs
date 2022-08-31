// Получение информации о директориях и файлах путем перебора

void CatalogInfo(string path, string indent = "")    // string indent = "" здесь это отступ, чтобы видеть структуру папки
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + "  ");
    }
    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path = "D:/GeekBrains/C#/Lections/C-Lesson1-new-/Example001_HelloConsole";
CatalogInfo(path);