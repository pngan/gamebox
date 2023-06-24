#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443


COPY .git/refs/heads/main /app/githash
RUN echo '/app/githash is '
RUN cat /app/githash

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["gamebox/Server/gamebox.Server.csproj", "Server/"]
COPY ["gamebox/Client/gamebox.Client.csproj", "Client/"]
#COPY ["Shared/gamebox.Shared.csproj", "Shared/"]
RUN dotnet restore "Server/gamebox.Server.csproj"
COPY . .
WORKDIR "/src/Server"
RUN dotnet build "gamebox.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "gamebox.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .


ENTRYPOINT ["dotnet", "gamebox.Server.dll"]
