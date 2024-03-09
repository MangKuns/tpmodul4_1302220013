// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class KodePos
{
    public enum kecamatan
    {
        Batununggal,
        AKujangsari,
        Mengger,
        Wates,
        Cijaura,
        Jatisari,
        Margasari,
        Sekejati,
        Kebonwaru,
        Maleer,
        Samoja
    }

    public static string GetKodePost(kecamatan Kec)
    {
        string[] kodepost = { "40266", "40287", "40267",
            "40256", "40287", "40286", "40286", "40286", "40272", "40274", "40273" };

        return kodepost[(int)Kec];
    }



}