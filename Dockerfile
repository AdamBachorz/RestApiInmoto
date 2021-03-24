#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src

COPY ["RestApiInmoto.API/RestApiInmoto.API.csproj", "RestApiInmoto.API/"]
COPY ["RestApiInmoto.Common/RestApiInmoto.Common.csproj", "RestApiInmoto.Common/"]
COPY ["RestApiInmoto.Model/RestApiInmoto.Model.csproj", "RestApiInmoto.Model/"]
COPY ["RestApiInmoto.DAL/RestApiInmoto.DAL.csproj", "RestApiInmoto.DAL/"]
#COPY ["RestApiInmoto.csproj", "RestApiInmoto/"]

RUN dotnet restore "RestApiInmoto.API/RestApiInmoto.API.csproj"
COPY . .
WORKDIR "/src/RestApiInmoto.API"
#WORKDIR "/src/RestApiInmoto"
#COPY . .
RUN dotnet build "RestApiInmoto.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RestApiInmoto.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "RestApiInmoto.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet RestApiInmoto.API.dll