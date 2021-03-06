FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY ["SuperDigital.Api/SuperDigital.Api.csproj", "SuperDigital.Api/"]
RUN dotnet restore "SuperDigital.Api/SuperDigital.Api.csproj"
COPY . .
WORKDIR "/src/SuperDigital.Api"
RUN dotnet build "SuperDigital.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SuperDigital.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SuperDigital.dll"]
  