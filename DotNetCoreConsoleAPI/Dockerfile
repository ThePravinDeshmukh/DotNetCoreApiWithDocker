FROM microsoft/dotnet:2.1-runtime AS base
WORKDIR /app
EXPOSE 5000

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY DotNetCoreConsoleAPI.csproj ./
RUN dotnet restore /DotNetCoreConsoleAPI.csproj
COPY . .
WORKDIR /src/
RUN dotnet build DotNetCoreConsoleAPI.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish DotNetCoreConsoleAPI.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DotNetCoreConsoleAPI.dll"]
