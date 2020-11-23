FROM microsoft/dotnet:2.0-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.0-sdk AS build
WORKDIR /src
COPY ["SuperDigital/SuperDigital.Api.csproj", "SuperDigital/"]
RUN dotnet restore "SuperDigital/SuperDigital.Api.csproj"
COPY . .
WORKDIR "/src/SuperDigital"
RUN dotnet build "SuperDigital.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "SuperDigital.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "SuperDigital.dll"]

