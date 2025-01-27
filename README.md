# EpiDoc for .NET

## Overview

This is a work-in-progress project that sets out to provide an API for interacting with and querying [TEI](https://tei-c.org/)
[EpiDoc](https://epidoc.stoa.org/) XML files. The aims are similar to those of [PyEpiDoc](https://github.com/rsdc2/PyEpiDoc). However, the .NET ecosystem offers significant advantages over Python, both for querying and for structuring the API in an easily readable and maintainable way in particular:

- [LINQ to XML](https://learn.microsoft.com/en-us/dotnet/standard/linq/linq-xml-overview) provides first class support for query expressions within the language itself.
- [XML Literals](https://learn.microsoft.com/en-us/dotnet/visual-basic/programming-guide/language-features/xml/xml-literals-overview) in Visual Basic provides a very intuitive and declarative interface for interacting with XML.

## Structure

The project comprises the following components:

- **`EpiDoc` API**: Written primarily in Visual Basic, this will provide the primary structures for interacting with EpiDoc files, leveraging the declarative power of _XML literals_. The structure will be analogous to component-based Web frameworks (like React or Blazor).
- **Web backend**: Written primarily in C#, this will provide a RESTful API for querying the the EpiDoc.
- **Web frontend**: Written in C# (Blazor), this will provide an interface for the user to explore and query the EpiDoc files.

## Licenses

The software for this project is licensed under MIT.

Example and test ```.xml``` files are taken from the [I.Sicily corpus](https://github.com/ISicily/ISicily), which are made available under the [CC-BY-4.0 licence](https://creativecommons.org/licenses/by/4.0/) (see ```LICENSE-texts.txt```).
