#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PdpAssist/Server/PdpAssist.Server.csproj", "PdpAssist/Server/"]
COPY ["PdpAssist/Shared/PdpAssist.Shared.csproj", "PdpAssist/Shared/"]
COPY ["PdpAssist/Client/PdpAssist.Client.csproj", "PdpAssist/Client/"]
RUN dotnet restore "PdpAssist/Server/PdpAssist.Server.csproj"
COPY . .
WORKDIR "/src/PdpAssist/Server"
RUN dotnet build "PdpAssist.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PdpAssist.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PdpAssist.Server.dll"]