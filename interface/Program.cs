using _22octinterface.Interface;

namespace _22octinterface;

internal class Program : ITextEditor
{
    static void Main(string[] args)
    {
        
     ITextEditor text = new WordPad(); 
      text.Open();
      text.Write("");
      text.Save();
      text.SaveAndClose("");

        Console.WriteLine("-----------------------------------");

        ITextEditor suma = new Word();
        suma.Open();
        suma.Write("");
        suma.Save();
        suma.SaveAndClose("");

        Console.WriteLine("-----------------------------------");

        ITextEditor ab = new Notepad();
        ab.Open();
        ab.Write("");
        ab.Save();
        ab.SaveAndClose("");
    }
    public void Open()
    {
        throw new NotImplementedException();
    }

    public void Save()
    {
        throw new NotImplementedException();
    }

    public void SaveAndClose(string filename)
    {
        throw new NotImplementedException();
    }

    public void Write(string text)
    {
        throw new NotImplementedException();
    }
}
