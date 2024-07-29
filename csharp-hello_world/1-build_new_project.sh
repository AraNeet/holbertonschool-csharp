#!/usr/bin/env bash

if [ ! -d "2-new_project" ]; then
    dotnet new console -n 2-new_project.csproj
fi
cd 2-new_project
dotnet build 2-new_project.csproj
