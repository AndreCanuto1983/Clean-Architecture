FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Simis/Simis.Application/Simis.csproj", "Simis/Simis.Application"]
RUN dotnet restore "Simis/Simis.Application/Simis.csproj"
COPY . .
WORKDIR "/src/Simis/Simis.Application"
RUN dotnet build "Simis.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Simis.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Simis.dll"]