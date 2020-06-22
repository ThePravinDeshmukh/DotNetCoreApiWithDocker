FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["DotNetCoreAPI/DotNetCoreAPI.csproj", "DotNetCoreAPI/"]
RUN dotnet restore "DotNetCoreAPI/DotNetCoreAPI.csproj"
COPY . .
WORKDIR "/src/DotNetCoreAPI"
RUN dotnet build "DotNetCoreAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "DotNetCoreAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DotNetCoreAPI.dll"]