namespace TahapAkhirOCBC.Utils;

public class Util
{
    public static string ListToString<T>(List<T> list)
    {
        return $"[{String.Join(", ", list)}]";
    }
    public static string ArrayToString<T>(T[] list)
    {
        return $"[{String.Join(", ", list)}]";
    }
}