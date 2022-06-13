#!/bin/bash

set -e

until /root/.dotnet/tools/dotnet-ef database update --no-build --connection "Host=postgres; Password= $POSTGRES_PASSWORD; Username=$POSTGRES_USER; Database=$POSTGRES_DB"; do
>&2 echo "SQL Server is starting up"
sleep 1
done

>&2 echo "SQL Server is up - executing command"

/root/.dotnet/tools/dotnet-ef database update --connection "Host=postgres; Password= $POSTGRES_PASSWORD; Username=$POSTGRES_USER; Database=$POSTGRES_DB"