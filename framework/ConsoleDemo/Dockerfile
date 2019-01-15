

# run time
FROM microsoft/aspnet:4.7.1-windowsservercore-1709 AS runtime
WORKDIR /app

RUN net user /add custom-admin
RUN net localgroup Administrators custom-admin /add
USER custom-admin

COPY ConsoleDemo/bin/Release ./

ENTRYPOINT ["ConsoleDemo.exe"]
