public enum KELURAHAN
{
    BATUNANGGAL,
    KUJANGSARI,
    MENGGER,
    WATES,
    CIJAURA,
    JATISARI,
    MARGASARI,
    SEKEJATI,
    KEBONWARU,
    MALEER,
    SAMOJA,
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public class KodePos
{
    public static int getKodePos(KELURAHAN kelurahan)
    {
        int[] kodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
        return kodePos[(int)kelurahan];
    }
}