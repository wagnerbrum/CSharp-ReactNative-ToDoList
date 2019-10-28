FROM microsoft/dotnet:2.2-aspnetcore-runtime

LABEL version="1.0" maintainer="Wagner Brum"

WORKDIR /app

COPY ./publish .

ENTRYPOINT [ "dotnet", "Todo.API.dll" ]