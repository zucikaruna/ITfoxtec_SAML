FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build1
WORKDIR /app
RUN git clone https://github.com/zucikaruna/ITfoxtec_SAML.git

WORKDIR /app/ITfoxtec_SAML/

RUN dotnet restore
RUN dotnet publish -c Release /p:EnvironmentName=Development -o out
	
FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
EXPOSE 8081
COPY --from=build1 /app/ITfoxtec_SAML/out .

ENTRYPOINT ["dotnet", "Okta_SAML_Example.dll"]
