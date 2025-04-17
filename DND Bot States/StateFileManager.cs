using System;
using System.IO;
using System.Xml.Serialization;
using DND_Bot_States.States;

namespace DND_Bot_States;

public static class StateFileManager
{
    public static readonly string StateFolderPath = Path.Combine(AppContext.BaseDirectory, "States");

    public static void Initialize()
    {
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