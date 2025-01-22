# ���� ������
FROM mcr.microsoft.com/dotnet/sdk:8.0-windowsservercore-ltsc2022 AS build

WORKDIR /src

# �������� ������ � ��������������� �����������
COPY ["LabaInformationTechnologicsNew.csproj", "LabaInformationTechnologicsNew/"]
RUN dotnet restore "./LabaInformationTechnologicsNew.csproj"

# �������� ��� ��������� ����� �������
COPY . .

# ��������� ������
WORKDIR "/src/LabaInformationTechnologicsNew"
RUN dotnet publish "LabaInformationTechnologicsNew.csproj" -c Release -o /app

# ���� ��� ������� ����������
FROM mcr.microsoft.com/dotnet/aspnet:8.0-windowsservercore-ltsc2022

WORKDIR /app
COPY --from=build /app .

# ��������� ����� �����
ENTRYPOINT ["dotnet", "LabaInformationTechnologicsNew.dll"]
