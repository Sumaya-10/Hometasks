namespace _20okttask;

 class Program
{
    static void Main(string[] args)
    {
        Singer singer = new Singer("Maral ","Tahirqizi ",180);

        Console.WriteLine(singer.name  + " " + singer.Surname  + " " + singer.Age);

        Song song = new Song("Summertime Sadness", "pop", "Maral");

        Console.Write(song.songName + " " + song.genre + " " + song.singer);
    }
}
