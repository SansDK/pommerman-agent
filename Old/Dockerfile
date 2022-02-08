#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
ENV ASPNETCORE_URLS=http://+:10080
WORKDIR /app
EXPOSE 10080

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PommermanAgentDotNet.csproj", "."]
RUN dotnet restore "./PommermanAgentDotNet.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "PommermanAgentDotNet.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PommermanAgentDotNet.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PommermanAgentDotNet.dll"]