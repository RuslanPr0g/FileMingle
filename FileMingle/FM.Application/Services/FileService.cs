using FM.Domain.Entities;
using FM.Integration;

namespace FM.Application.Services;

public sealed class FileService : IFileService
{
    private readonly IFileClient _fileClient;
    
    public FileService(IFileClient fileClient)
    {
        _fileClient = fileClient;
    }
    
    public bool Upload(StorableFile file) => _fileClient.SaveRemotely(file.Name.Value, file.Content.Value);
}