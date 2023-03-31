FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["FM.UIHost/FM.UIHost.csproj", "FM.UIHost/"]
RUN dotnet restore "FM.UIHost/FM.UIHost.csproj"
COPY . .
WORKDIR "/src/FM.UIHost"
RUN dotnet build "FM.UIHost.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FM.UIHost.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FM.UIHost.dll"]
