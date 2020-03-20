#/bin/sh

set -e

dotnet test -l "trx;LogFileName=tests.trx" -l "console;verbosity=minimal"
