FROM mcr.microsoft.com/dotnet/sdk:6.0

RUN mkdir -p /usr/src
WORKDIR /usr/src

COPY Instruments.sln /usr/src/
COPY Lusid.Instruments.Examples/Lusid.Instruments.Examples.csproj /usr/src/Lusid.Instruments.Examples/
RUN dotnet restore Instruments.sln

ENTRYPOINT dotnet test Instruments.sln -l "console;verbosity=detailed"