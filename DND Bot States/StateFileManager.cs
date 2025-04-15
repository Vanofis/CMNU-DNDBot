using System;
using System.IO;
using System.Xml.Serialization;
using DND_Bot_States.States;

namespace DND_Bot_States;

public static class StateFileManager
{
    public static BaseState GetState(string path, Type stateType)
    {
        var serializer = new XmlSerializer(typeof(BaseState));
        using var streamReader = new StreamReader(path);
        
        return (BaseState)serializer.Deserialize(streamReader)!;
    }
    
    public static void SaveState<T>(T state, string path) where T : BaseState
    {
        var serializer = new XmlSerializer(typeof(T));
        using var streamWriter = new StreamWriter(path);
        
        serializer.Serialize(streamWriter, state);
    }
}