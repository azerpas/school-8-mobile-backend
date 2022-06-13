FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["Tracker/Tracker.csproj", "Tracker/"]
COPY ["Tracker/Setup.sh", "Tracker/"]

RUN dotnet tool install --global dotnet-ef

RUN dotnet restore "Tracker/Tracker.csproj"
COPY . .
WORKDIR "/src/Tracker"

RUN chmod +x ./Setup.sh
CMD /bin/bash ./Setup.sh