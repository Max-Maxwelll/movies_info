#!/bin/bash
dotnet ef migrations add ApplicationContext --context ApplicationDbContext --output-dir Data/Migrations
dotnet ef migrations add ShowContext --context ShowContext --output-dir Data/Migrations