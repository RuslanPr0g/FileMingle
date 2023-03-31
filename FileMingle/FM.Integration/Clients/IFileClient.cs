namespace FM.Integration;

public interface IFileClient
{
    bool SaveRemotely(string filename, byte[] content);
}