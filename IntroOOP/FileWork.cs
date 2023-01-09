public class FileWork
{
    private string _StrinLine;

    public string StrinLine { get => _StrinLine; set => _StrinLine = value; }

    public string ReverseString(string StringLine)
    {
        char[] arr = StringLine.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
