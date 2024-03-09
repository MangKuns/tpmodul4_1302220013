// See https://aka.ms/new-console-template for more information
using System;
using static KodePos;

public class KodePos
{
    public enum Kecamatan
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

    public static string GetKodePost(Kecamatan Kec)
    {
        string[] kodepost = { "40266", "40287", "40267",
            "40256", "40287", "40286", "40286", "40286", "40272", "40274", "40273" };

        return kodepost[(int)Kec];
    }



}

public enum trigger { buka, kunci};
public class DoorMachine
{
    private enum status { terkunci, terbuka};
    private status currentStatus;

    public DoorMachine ()
    {
        this.currentStatus = status.terkunci;
    }

    public void action (trigger Trigger) {
        if (Trigger == trigger.buka)
        {
            this.currentStatus = status.terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        } else if (Trigger == trigger.kunci)
        {
            this.currentStatus = status.terkunci;
            Console.WriteLine("Pintu terkunci");
        }
    }

    public static void Main(String[] args)
    {
        Kecamatan kec = Kecamatan.Batununggal;
        Console.WriteLine("=====Nomor1=====" + "\n" + "Kecamatan " + kec + " memiliki kode post " + GetKodePost(kec) + 
           "\n" + "=====Nomor2=====");

        DoorMachine machine = new DoorMachine();
        machine.action (trigger.buka);
        machine.action (trigger.kunci);
    }
}

