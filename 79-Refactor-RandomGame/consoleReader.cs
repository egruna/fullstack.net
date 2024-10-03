public static class consoleReader 
{
    public static bool TryReadInt(string message, out int value)
    {
        Console.Write(message);
        return int.TryParse(Console.ReadLine(), out value);
    }
}