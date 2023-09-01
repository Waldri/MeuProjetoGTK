# MeuProjetoGTK
Template using gtkSharp on Ubuntu. Gnome UI on dotNet C#

## 1st: install packages:
```
sudo apt-get update
sudo apt-get install mono-complete
sudo apt-get install libgtk2.0-cil libgtk3.0-cil
editor gráfico:
sudo apt-get install glade
```
dotnet sdk Ubuntu:
https://learn.microsoft.com/en-us/dotnet/core/install/linux-ubuntu
dotnet sdk Raspberry
https://learn.microsoft.com/en-us/dotnet/iot/deployment

## 2nd: create folder and file (MeuProjetoGtk.csproj)
mkdir MeuProjetoGtk
cd MeuProjetoGtk

```
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net6.0</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="GtkSharp" Version="3.24.26" />
  </ItemGroup>

</Project>
```

## 3td: install GtkSarp
```
dotnet add package GtkSharp --version 3.22.30
```

## 4th: Compile and Run:
```
mcs -pkg:gtk-sharp-3.0 main.cs
mono main.exe
```
or
```
dotnet build
dotnet run
```
## Run copiled code
copy the UI (glade file) to bin/Debug/Net##/ and run ./MeuProjetoGTK
