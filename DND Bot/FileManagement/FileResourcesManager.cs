using System;
using System.Collections.Generic;
using System.IO;

namespace DND_Bot.FileManagement;

public static class FileResourcesManager
{
    private static readonly string PathToResources = Path.Combine(AppContext.BaseDirectory, "Resources");
    
    private static Dictionary<Guid, byte[]> Images = new();
    
    public static void Initialize()
    {
        if (!Directory.Exists(PathToResources))
        {
            throw new NotImplementedException();
        }

        string pathToImages = Path.Combine(PathToResources, "Images");
        var filePaths = Directory.GetFiles(pathToImages, "*", SearchOption.AllDirectories);

        foreach (string filePath in filePaths)
        {
            string relativePath = Path.GetRelativePath(pathToImages, filePath).Replace("\\", "/");
            var pathGuid = GetGuid(relativePath);
            
            Images.Add(pathGuid, File.ReadAllBytes(filePath));
        }
    }

    public static MemoryStream GetImage(string path)
    {
        path += ".png";
        return new MemoryStream(Images[GetGuid(path)]);
    }
    
    private static Guid GetGuid(string path)
    {
        var hash = System.Security.Cryptography.SHA1.HashData(System.Text.Encoding.UTF8.GetBytes(path));
        Array.Resize(ref hash, 16);
            
        return new Guid(hash);
    }
}