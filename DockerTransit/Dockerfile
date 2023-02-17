FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DockerTransit.csproj", "DockerTransit/"]
RUN dotnet restore "DockerTransit/DockerTransit.csproj"

COPY . DockerTransit/.
RUN dotnet publish -c Release -o /app DockerTransit/DockerTransit.csproj 

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS publish
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "DockerTransit.dll"]