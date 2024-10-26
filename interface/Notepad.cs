using _22octinterface.Interface;

namespace _22octinterface;

class Notepad : ITextEditor
{
    public string currenttext;
    string Currenttext { get; }

    public void Open()
    {
        Console.WriteLine("file opened");
    }

    public void Write(string text)
    {
        currenttext += text;
        Console.WriteLine("yazi yazildi: " + "salam dostlaar");

    }
    public void Save()
    {
        Console.WriteLine("fayl save olundu...");
    }

    public void SaveAndClose(string filename)
    {
        Console.WriteLine("C:/Users/Desktop/filename.txt");
    }
}
