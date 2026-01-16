
public class Data(string name)
{
    public string Name { get; set; } = name;
    public Dictionary<string, Data> Value { get; set; } = [];
}