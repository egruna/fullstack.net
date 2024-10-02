namespace _75_Refactor74_Repository;

public class ListStringRepository
{
    public void save(List<string> input, string path)
    {
        //  مدیریت نوشتن در اکسل و دیتا بیس و اینجاست
        // در اینجا نوشتن در تکست است
        File.WriteAllLines(path, input);
    }

    public List<string> GetLinesStrings(string path)
    {
        var lines = File.ReadAllLines(path).ToList();
        return lines;
    }
}
