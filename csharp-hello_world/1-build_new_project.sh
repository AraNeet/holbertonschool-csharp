#!/usr/bin/env bash

if [ ! -d "1-new_project" ]; then
    dotnet new console -n 1-new_project
fi
cd 1-new_project
dotnet build 1-new_project
