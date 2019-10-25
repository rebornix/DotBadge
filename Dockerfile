# Using SDK image to build
FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build

WORKDIR /app

# Restore first
COPY DotBadge/DotBadge.csproj DotBadge/DotBadge.csproj
COPY DotBadge.CommandLine/DotBadge.CommandLine.csproj DotBadge.CommandLine/DotBadge.CommandLine.csproj
RUN dotnet restore DotBadge.CommandLine/DotBadge.CommandLine.csproj

# Copy everything needed
COPY DotBadge/* DotBadge/
COPY DotBadge.CommandLine/* DotBadge.CommandLine/

# Build dotnet unit tests
RUN dotnet publish -c Release -o /app/out /app/DotBadge.CommandLine/DotBadge.CommandLine.csproj

# Using runtime image + libgdiplus for Drawing
FROM mcr.microsoft.com/dotnet/core/runtime:3.0 as dotnet-tests
WORKDIR /app

RUN apt-get update \
    && apt-get install -y --allow-unauthenticated \
        libc6-dev \
        libgdiplus \
        libx11-dev \
     && rm -rf /var/lib/apt/lists/*

# Copy files from build
COPY --from=build /app/out/ .

#Run
ENTRYPOINT ["dotnet", "DotBadge.CommandLine.dll" ]
