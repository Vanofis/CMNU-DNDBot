using System;
using System.Collections.Generic;
using System.IO;

namespace DND_Bot.FileManagement;

public static class ImageLibrary
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    #region Data    
    
    public static readonly string PathToImages = Path.Combine(AppContext.BaseDirectory, "Images");
    
    private static Dictionary<Guid, byte[]> Images = new();
    
    public static void Initialize()
    {
        if (!Directory.Exists(PathToImages))
        {
            Directory.CreateDirectory(PathToImages);
        }
        else
        {
            var filePaths = Directory.GetFiles(PathToImages, "*", SearchOption.AllDirectories);

            foreach (string filePath in filePaths)
            {
                string relativePath = Path.GetRelativePath(PathToImages, filePath).Replace("\\", "/");
                var pathGuid = GetGuid(relativePath);
            
                Images.Add(pathGuid, File.ReadAllBytes(filePath));
            }
        }
    }

    #endregion

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    
    #region Interface
    
    public static MemoryStream GetImage(string path)
    {
        return new MemoryStream(Images[GetGuid(path)]);
    }
    
    #endregion
    
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    
    #region Private
    
    private static Guid GetGuid(string path)
    {
        var hash = System.Security.Cryptography.SHA1.HashData(System.Text.Encoding.UTF8.GetBytes(path));
        Array.Resize(ref hash, 16);
            
        return new Guid(hash);
    }
    
    #endregion
    
    ////////////////////////////////////////////////////////////////////////////////////////////////////
}