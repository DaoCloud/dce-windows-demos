
FROM microsoft/dotnet-framework:4.7.1-sdk-windowsservercore-1709 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
# 要和 *.csproj 项目名称一样，不让restore没效果
COPY *.sln .
COPY aspnetmvc/*.csproj ./aspnetmvc/
COPY aspnetmvc/*.config ./aspnetmvc/

RUN nuget restore aspnetmvc.sln

WORKDIR /app/aspnetmvc

# copy everything else and build app
COPY aspnetmvc/. .

RUN msbuild /p:Configuration=Release


FROM microsoft/aspnet:4.7.1-windowsservercore-1709 AS runtime
WORKDIR /inetpub/wwwroot
COPY --from=build /app/aspnetmvc/. ./