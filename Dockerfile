# Этап сборки
FROM mcr.microsoft.com/dotnet/sdk:8.0-windowsservercore-ltsc2022 AS build

WORKDIR /src

# Копируем проект и восстанавливаем зависимости
COPY ["LabaInformationTechnologicsNew.csproj", "LabaInformationTechnologicsNew/"]
RUN dotnet restore "./LabaInformationTechnologicsNew.csproj"

# Копируем все остальные файлы проекта
COPY . .

# Публикуем проект
WORKDIR "/src/LabaInformationTechnologicsNew"
RUN dotnet publish "LabaInformationTechnologicsNew.csproj" -c Release -o /app

# Этап для запуска приложения
FROM mcr.microsoft.com/dotnet/aspnet:8.0-windowsservercore-ltsc2022

WORKDIR /app
COPY --from=build /app .

# Указываем точку входа
ENTRYPOINT ["dotnet", "LabaInformationTechnologicsNew.dll"]
