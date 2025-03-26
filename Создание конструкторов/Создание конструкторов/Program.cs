class Program
{
    static void Main(string[] args)
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string gamesFolderPath = Path.Combine(desktopPath, "Игры");
        GameFolder gameFolder = new GameFolder(gamesFolderPath);
        gameFolder.ShowGameCount();
    }
}
}
