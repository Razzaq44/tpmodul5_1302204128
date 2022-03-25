using System.Diagnostics;
using System.Diagnostics.Contracts;

public class program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo vid = new SayaTubeVideo("Tutorial Design By Contract - [Razzaq Adi Wibowo]");
        for (int i = 0; i < 220; i++)
        {
            vid.IncreasePlayCount(10000000);
            vid.PrintVideoDetails();
        }
    }
}

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Contract.Requires(title != null);
        Debug.Assert(title.Length > 0 && title.Length <= 100, "Judul video maks 100 karakter dan tidak boleh kosong");
        this.title = title;
        Random r = new Random();
        this.id = r.Next(99999);
        this.playCount = 0;
    }

    public void IncreasePlayCount(int playCount)
    {
        Contract.Requires(playCount != null);
        Debug.Assert(playCount <= 10000000, "Maks playcount 10000000");
        int cek;
        try
        {
            cek = checked(this.playCount + playCount);
            this.playCount += playCount;
        }
        catch (OverflowException error)
        {
            Console.WriteLine();
            Console.WriteLine("---------------================ Integer Overflow ================---------------");
            this.playCount = int.MaxValue;
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine();
        Console.WriteLine("id: " + this.id);
        Console.WriteLine("title: " + this.title);
        Console.WriteLine("playCount: " + this.playCount);
        Console.WriteLine();
        Console.WriteLine("------------------------------------------------------------------------------------");
    }


}
