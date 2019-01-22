FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src

COPY . /src/aspnetmvc

WORKDIR /src/aspnetmvc

RUN dotnet restore
RUN dotnet build -nowarn:msb3202,nu1503,cs1591 -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .


ENTRYPOINT ["dotnet", "aspnetmvc.dll"]