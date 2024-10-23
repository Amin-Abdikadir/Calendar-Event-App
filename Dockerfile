FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CalendarApp/CalendarApp.csproj", "./"]
RUN dotnet restore "./CalendarApp.csproj"
COPY . .
WORKDIR "/src/CalendarApp"
RUN dotnet build "CalendarApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CalendarApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CalendarApp.dll"]
