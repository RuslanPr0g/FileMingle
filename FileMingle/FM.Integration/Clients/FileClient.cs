using RestSharp;

namespace FM.Integration;

public class FileClient : IFileClient
{
    public bool SaveRemotely(string filename, byte[] content)
    {
        try
        {
            RestClient client = new();
            // TODO: Inject settings and get the url from there
            RestRequest request = new("http://localhost:5015/file/upload", Method.Post);
            RestResponse response = client.Post(request);
            return response.IsSuccessful;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }
}