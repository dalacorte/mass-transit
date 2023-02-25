FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DMT.csproj", "DMT/"]
RUN dotnet restore "DMT/DMT.csproj"

COPY . DMT/.
RUN dotnet publish -c Release -o /app DMT/DMT.csproj 

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS publish
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "DMT.dll"]