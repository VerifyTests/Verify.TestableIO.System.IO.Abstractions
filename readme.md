# <img src="/src/icon.png" height="30px"> Verify.TestableIO.System.IO.Abstractions

[![Discussions](https://img.shields.io/badge/Verify-Discussions-yellow?svg=true&label=)](https://github.com/orgs/VerifyTests/discussions)
[![Build status](https://ci.appveyor.com/api/projects/status/bgvkfjn26l5b4kba?svg=true)](https://ci.appveyor.com/project/SimonCropp/verify-testableio-system-io-abstractions)
[![NuGet Status](https://img.shields.io/nuget/v/Verify.TestableIO.System.IO.Abstractions.svg)](https://www.nuget.org/packages/Verify.TestableIO.System.IO.Abstractions/)

Extends [Verify](https://github.com/VerifyTests/Verify) to allow verification of [Verify.TestableIO.System.IO.Abstractions](https://github.com/TestableIO/System.IO.Abstractions) bits.<!-- singleLineInclude: intro. path: /docs/intro.include.md -->

**See [Milestones](../../milestones?state=closed) for release notes.**


## Sponsors


### Entity Framework Extensions<!-- include: zzz. path: /docs/zzz.include.md -->

[Entity Framework Extensions](https://entityframework-extensions.net/?utm_source=simoncropp&utm_medium=https://github.com/VerifyTests/Verify.TestableIO.System.IO.Abstractions) is a major sponsor and is proud to contribute to the development this project.

[![Entity Framework Extensions](https://raw.githubusercontent.com/VerifyTests/Verify.TestableIO.System.IO.Abstractions/refs/heads/main/docs/zzz.png)](https://entityframework-extensions.net/?utm_source=simoncropp&utm_medium=Verify.TestableIO.System.IO.Abstractions)<!-- endInclude -->


## NuGet

 * https://nuget.org/packages/TestableIO.System.IO.Abstractions


## Usage

<!-- snippet: Enable -->
<a id='snippet-Enable'></a>
```cs
[ModuleInitializer]
public static void Initialize() =>
    VerifyTestableIOSystemIOAbstractions.Initialize();
```
<sup><a href='/src/Tests/ModuleInitializer.cs#L6-L12' title='Snippet source file'>snippet source</a> | <a href='#snippet-Enable' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

<!-- snippet: Usage -->
<a id='snippet-Usage'></a>
```cs
[Test]
public async Task Usage()
{
    IFileSystem fileSystem = new FileSystem();
    var fileInfo = fileSystem.FileInfo.New(@"C:\temp\temp.txt");
    await Verify(fileInfo);
}
```
<sup><a href='/src/Tests/Tests.cs#L4-L14' title='Snippet source file'>snippet source</a> | <a href='#snippet-Usage' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

Results in:

<!-- snippet: Tests.Usage.verified.txt -->
<a id='snippet-Tests.Usage.verified.txt'></a>
```txt
C:\temp\temp.txt
```
<sup><a href='/src/Tests/Tests.Usage.verified.txt#L1-L1' title='Snippet source file'>snippet source</a> | <a href='#snippet-Tests.Usage.verified.txt' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->
