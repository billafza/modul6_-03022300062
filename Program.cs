using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

class SayaTubeUser
{
    int id;
    List<SayaTubeVideo> uploadedVideos;
    String username;

    SayaTubeUser(String username)
    {
        Random rndmId = new Random();
        this.id = rndmId.Next(00001, 99999);
        this.uploadedVideos = new List<SayaTubeVideo>();
        this.username = username;
    }

    public int GetTotalVideoPlayCount()
    {
        int total;
        foreach (var video in uploadedVideos)
        {
            total += video.IncreasePlayCount;
        }
        return total;
    }

    public void AddVideo(SayaTubeVideo video)
    {
        uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine("User: " + this.username);
        Console.WriteLine("Video 1 judul: " + );
    }
}

class SayaTubeVideo
{
    int id;
    String title;
    int playCount;

    SayaTubeVideo(String title)
    {
        Random rdmId = new Random();
        this.id = rdmId.Next(00001, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int play)
    {
        if(play < 0)
        {
            Console.WriteLine("Jumlah tayangan tidak boleh negatif!");
        }
        this.playCount += play;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID: " + this.id);
        Console.WriteLine("Judul Video: " + this.title);
        Console.WriteLine("Jumlah Tayangan: " + this.playCount);
    }
}

class program
{
    static void Main()
    {
        SayaTubeVideo video = new SayaTubeVideo();
        SayaTubeUser user = new SayaTubeUser();
        user.GetTotalVideoPlayCount();
        user.PrintAllVideoPlayCount();
        video.IncreasePlayCount(1000);
        video.PrintVideoDetails();
    }
}