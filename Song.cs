namespace _20okttask;

 class Song
{
    public string songName;
    public string genre;
    public string singer;
    public int[] ratings = new int[5];
    public int ratingsCount = 0;

    public Song(string name, string genre, string singer)
    {
        this.songName = name;
        this.genre = genre;
        this.singer = singer;
    }
    public string name
    {
        get {  return songName; }
        set
        {
            if (songName.Length < 101)
                this.songName = name;
            else
                Console.WriteLine("yanlisdir");
        }
    }
    public void AddRating(int rating)
    {
        if(ratingsCount < ratings.Length)
        {
            rating = ratings[rating];
            ratingsCount++;
        }
        else
        {
            Console.WriteLine("reytinqe dusmuyub");
        }
    }
    /*public int GetAverageRating()
    { 
        return ratingsCount;
        int sum = 
    }*/

    public string Genre
    {
        get { return genre; }
        set
        {
            if(Genre=="pop" || Genre == "jazz" || Genre == "rock")
                genre = Genre;
        }
    }
}
