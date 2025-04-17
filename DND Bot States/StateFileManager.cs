using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using DND_Bot_States.States;

namespace DND_Bot_States;

public static class StateFileManager
{
    public static string StateFolderPath;

    public static void Initialize()
    {
        var directory = new DirectoryInfo(Directory.GetCurrentDirectory());
        while (directory != null && !directory.GetFiles("*.sln").Any())
        {
            directory = directory.Parent;
        }
        
        StateFolderPath = Path.Combine(directory.Name, "States");
        
        if (!Directory.Exists(StateFolderPath))
        {
            Directory.CreateDirectory(StateFolderPath);
        }
    }
    
    public static MessageState GetState(string path)
    {
        var serializer = new XmlSerializer(typeof(MessageState));
        using var streamReader = new StreamReader(Path.Combine(StateFolderPath, path));
        
        return (MessageState)serializer.Deserialize(streamReader)!;
    }
    
    public static void SaveState(this MessageState state, string path)
    {
        path += ".xml";
        var serializer = new XmlSerializer(typeof(MessageState));
        using var streamWriter = new StreamWriter(Path.Combine(StateFolderPath, path));
        
        serializer.Serialize(streamWriter, state);
    }
}