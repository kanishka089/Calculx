using CalculXBase.Entities;
using Microsoft.AspNetCore.Http;

namespace CalculXBase.Services;

public class ResourceService
{
    private readonly string _basePath;
    private const string _defaultPath = "Resources";

    //public ResourceService(IWebHostEnvironment iWebHostEnvironment)
    //{
    //    _basePath = string.IsNullOrWhiteSpace(iWebHostEnvironment.WebRootPath)
    //        ? iWebHostEnvironment.ContentRootPath : iWebHostEnvironment.WebRootPath;
    //}

    public async Task<Resource> SaveFileResource(IFormFile file)
    {
        var saveFileResource = await SaveFileResource(file, _defaultPath);

        return saveFileResource;
    }

    public async Task<Resource> SaveFileResource(IFormFile file, string directory)
    {
        //if (file.Length > 0)
        //{
        //    string extension = Path.GetExtension(file.FileName);
        //    string tempName = Path.GetRandomFileName().Replace(".", "");

        //    directory = Path.Combine(_basePath, directory);
        //    var fileName = $"{tempName}{extension}";

        //    await SaveFile(file, directory, fileName);

        //    var resource = new Resource()
        //    {
        //        //Id = 0,
        //        Path = Path.Combine(_basePath, directory, fileName),
        //        Name = Path.GetFileNameWithoutExtension(file.FileName),
        //        Extension = extension
        //    };

        //    return resource;
        //}

        return null;
    }

    public async Task SaveFile(IFormFile file, string directory, string fileName)
    {
        Directory.CreateDirectory(directory); ;

        string filePath = Path.Combine(directory, fileName);

        using var stream = File.Create(filePath);
        await file.CopyToAsync(stream);
    }
}
