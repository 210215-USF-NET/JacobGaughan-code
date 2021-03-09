FROM mcr.microsoft.com/dotnet/sdk:5.0 as build

WORKDIR /app

COPY *.sln ./
COPY AboutMeMVC/*.csproj AboutMeMVC/

RUN dotnet restore

COPY . ./

RUN dotnet publish AboutMeMVC -c Release -o publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:5.0 as runtime
WORKDIR /app
COPY --from=build /app/publish ./
CMD ["dotnet", "AboutMeMVC.dll"]