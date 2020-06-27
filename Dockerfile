FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine AS package-restore
COPY ./src/ResolveJuros/ResolveJuros.csproj /src/ResolveJuros/ResolveJuros.csproj
COPY ./src/ResolveJurosTests/ResolveJurosTests.csproj /src/ResolveJurosTests/ResolveJurosTests.csproj
RUN dotnet restore /src/ResolveJuros/ResolveJuros.csproj
RUN dotnet restore /src/ResolveJurosTests/ResolveJurosTests.csproj

FROM package-restore as builder
COPY ./src /src
RUN dotnet publish -c Release /src/ResolveJuros/ResolveJuros.csproj
RUN dotnet publish -c Release /src/ResolveJurosTests/ResolveJurosTests.csproj

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine AS release
RUN mkdir /service
COPY --from=builder /src/ResolveJuros/bin/Release/netcoreapp3.1/publish /service
WORKDIR /service

CMD [ "dotnet", "/service/ResolveJuros.dll" ]
