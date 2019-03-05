FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["Multiplication/Multiplication.csproj", "Multiplication/"]
RUN dotnet restore "Multiplication/Multiplication.csproj"
COPY . .
WORKDIR "/src/Multiplication"
RUN dotnet build "Multiplication.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Multiplication.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Multiplication.dll"]