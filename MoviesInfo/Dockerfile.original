FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["MoviesInfo/MoviesInfo.csproj", "MoviesInfo/"]
RUN dotnet restore "MoviesInfo/MoviesInfo.csproj"
COPY . .
WORKDIR "/src/MoviesInfo"
RUN dotnet build "MoviesInfo.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MoviesInfo.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MoviesInfo.dll"]