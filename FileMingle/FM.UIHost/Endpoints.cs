using FM.Application.Services;
using FM.Domain.Entities;
using FM.UIHost.DTO;
using Microsoft.AspNetCore.Mvc;

namespace FM.UIHost;

public static class Endpoints
{
    public static WebApplication AddEndpoints(this WebApplication app)
    {
        app.MapPost("/upload", ([FromBody] FileUpload fileUpload, IFileService fileService) =>
        {
            StorableFile file = new(new Guid(), new(fileUpload.FileName), new(fileUpload.Content));
            bool uploaded = fileService.Upload(file);
            return Results.Ok(file.Name.Value + " /is uploaded\\ " + uploaded);
        });
        return app;
    }
}