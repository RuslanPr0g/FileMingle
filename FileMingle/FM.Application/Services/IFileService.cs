using FM.Domain.Entities;

namespace FM.Application.Services;

public interface IFileService
{
    bool Upload(StorableFile file);
}