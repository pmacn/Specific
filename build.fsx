#r "tools/FAKE.Core/tools/FakeLib.dll"
open Fake
open System
open Fake.XUnit2Helper

// Properties
let buildDir = "./build/"
let testBuildDir = "./tests/"
let testResultsDir = "./testresults/"
let buildMode = getBuildParamOrDefault "buildMode" "Release"

// Targets
Target "Clean" (fun _ ->
  CleanDirs [ buildDir; testResultsDir ]
)

Target "Build" (fun _ ->
  !! "src/Specific/**/*.csproj"
    |> MSBuildRelease buildDir "Build"
    |> Log "AppBuild-Output: "
)

Target "BuildTests" (fun _ ->
  !! "src/Specific.Tests/**/*.csproj"
    |> MSBuildRelease testBuildDir "Build"
    |> Log "AppBuild-Output: "
)

Target "Test" (fun _ ->
  !! (sprintf "%s/*.Tests.dll" testBuildDir)
  |> xUnit2 (fun p ->
    {p with 
      OutputDir = testResultsDir })
)

Target "Default" DoNothing

// Dependencies
"Clean"
  ==> "Build"
  ==> "BuildTests"
  ==> "Test"
  ==> "Default"

// Start
RunTargetOrDefault "Default"