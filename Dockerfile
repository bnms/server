FROM microsoft/aspnetcore-build:2.1 AS build-env
WORKDIR /app
ADD . ./
RUN dotnet restore
EXPOSE 80/tcp
ENTRYPOINT ["dotnet", "run"]
