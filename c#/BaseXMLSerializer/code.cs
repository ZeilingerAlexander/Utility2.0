List<string> listToSerialize = new List<string>
{
    "Test",
    "Example",
    "Hello",
    "World",
    "</string>"
};

XmlSerializer serializer = new XmlSerializer(typeof(List<string>));

// Serializing
FileStream fs = new FileStream(@"C:\TestForConfigs\default.txt", FileMode.Truncate);
using (StreamWriter sr = new(fs))
{
    serializer.Serialize(sr, listToSerialize);
}

// Deserializating
FileStream fs2 = new FileStream(@"C:\TestForConfigs\default.txt", FileMode.Open);
using (StreamReader sr = new StreamReader(fs2))
{
    List<string>? newList = serializer.Deserialize(sr) as List<string>;
    if (newList != null)
    {
        foreach (string item in newList)
        {
            Console.WriteLine(item);
        }
    }
}



// Example without File

// Serializing
TextWriter writer = new StringWriter();
serializer.Serialize(writer, listToSerialize);
string Serialized = writer.ToString();

// Deserializing
TextReader reader = new StringReader(Serialized);
List<string> Deserialized = serializer.Deserialize(reader) as List<string>;