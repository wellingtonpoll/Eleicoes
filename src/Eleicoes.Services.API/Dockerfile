FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-bionic AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-bionic AS build
WORKDIR /src
COPY ["Eleicoes.Services.API/Eleicoes.Services.API.csproj", "Eleicoes.Services.API/"]
RUN dotnet restore "Eleicoes.Services.API/Eleicoes.Services.API.csproj"
COPY . .
WORKDIR "/src/Eleicoes.Services.API"
RUN dotnet build "Eleicoes.Services.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Eleicoes.Services.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Eleicoes.Services.API.dll"]