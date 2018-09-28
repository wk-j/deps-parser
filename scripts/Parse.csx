#! "netcoreapp2.1"

#r "../src/DepsParser/bin/Debug/netstandard2.0/DepsParser.dll"

using DepsParser;

var parser = Parser.Search("resource", "*.deps.json");

Console.WriteLine(parser.GetLibraryVersion("ScanService.Core"));

