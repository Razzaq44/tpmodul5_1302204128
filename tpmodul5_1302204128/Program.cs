public class program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo vid = new SayaTubeVideo("Tutorial Design By Contract - [Razzaq Adi Wibowo]");
        vid.PrintVideoDetails();
    }
}

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        this.title = title;
        Random r = new Random();
        this.id = r.Next(99999);
        this.playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        this.playCount += playCount;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("id: " + this.id);
        Console.WriteLine("title: " + this.title);
        Console.WriteLine("playCount: " + this.playCount);
    }


}
