
FROM microsoft/dotnet-framework:4.7.1-sdk-windowsservercore-1709 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY WebForm/*.csproj ./WebForm/
COPY WebForm/*.config ./WebForm/

RUN nuget restore

WORKDIR /app/WebForm

# copy everything else and build app
COPY webform/. .

RUN msbuild /p:Configuration=Release


FROM microsoft/aspnet:4.7.1-windowsservercore-1709 AS runtime
WORKDIR /inetpub/wwwroot
COPY --from=build /app/WebForm/. ./
