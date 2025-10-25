FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SISPAE.API_Seguimiento/SISPAE_API_Seguimiento.WebAPI.csproj", "SISPAE.API_Seguimiento/"]
RUN dotnet restore "SISPAE.API_Seguimiento/SISPAE_API_Seguimiento.WebAPI.csproj"
COPY . .
WORKDIR "/src/SISPAE.API_Seguimiento"
RUN dotnet build "SISPAE_API_Seguimiento.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SISPAE_API_Seguimiento.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SISPAE_API_Seguimiento.WebAPI.dll"]