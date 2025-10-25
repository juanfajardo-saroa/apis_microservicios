FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SISPAE.API_Seguridad/SISPAE_API_Seguridad.WebAPI.csproj", "SISPAE.API_Seguridad/"]
RUN dotnet restore "SISPAE.API_Seguridad/SISPAE_API_Seguridad.WebAPI.csproj"
COPY . .
WORKDIR "/src/SISPAE.API_Seguridad"
RUN dotnet build "SISPAE_API_Seguridad.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SISPAE_API_Seguridad.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SISPAE_API_Seguridad.WebAPI.dll"]