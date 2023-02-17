FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY BlazorNavTmplt.csproj .
RUN dotnet restore BlazorNavTmplt.csproj
COPY . .
RUN dotnet build BlazorNavTmplt.csproj -c Release -o /app/build

FROM build AS publish
RUN dotnet publish BlazorNavTmplt.csproj -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .