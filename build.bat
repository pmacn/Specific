@echo off
cls
tools\nuget\nuget.exe install FAKE.Core -OutputDirectory tools -ExcludeVersion
tools\nuget\nuget.exe install xunit.runner.console -OutputDirectory tools -ExcludeVersion
tools\nuget\nuget.exe restore src\Specific.sln
tools\FAKE.Core\tools\Fake.exe build.fsx %1