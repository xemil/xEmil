# Usage: .\DisableNuGetPackageRestore.ps1 C:\Path\To\Solution.sln

# Get the path that the user specified when calling the script
$solution = $args[0]
$solutionPath = Split-Path $solution -Parent
$solutionName = Split-Path $solution -Leaf

# Delete the .nuget directory and all contents
Remove-Item (Join-Path $solutionPath ".nuget") -Force -Recurse -ErrorAction 0

# Create a backup of the solution file
Copy-Item $solution $("$solution.bak")

# Clear out the solution file
Clear-Content $solution

# Flag field used to denote what part of the solution file we are in
#   0: Not inside section
#   1: Beginning and middle of section
#   2: Last line of the section
$foundNuGetSection = 0

# Create the new contents of the solution file without the NuGet section
(Get-Content $("$solution.bak")) |
    Foreach-Object {
        # Parsing the solution file layout is no fun...
        if ($_ -match "^Project.*nuget.*") {
            $foundNuGetSection = 1
        } elseif ($_ -match "^EndProject$" -and $foundNuGetSection -eq 1) {
            $foundNuGetSection = 2
        } elseif ($foundNuGetSection -eq 2) {
            $foundNuGetSection = 0
        }
        
        if ($foundNuGetSection -eq 0) {
            Add-Content -Encoding UTF8 $solution $_
        }
    }

# Remove the temporary solution backup file
Remove-Item $("$solution.bak")

# Find every .csproj file and remove the reference to the NuGet.targets file 
# Example: <Import Project="$(SolutionDir)\.nuget\NuGet.targets" Condition="Exists('$(SolutionDir)\.nuget\NuGet.targets')" />
Get-ChildItem $solutionPath *.csproj -recurse |
    Foreach-Object { 
        (Get-Content $_.PSPath) | Where-Object {$_ -notmatch 'NuGet.targets'} | Set-Content -Encoding UTF8 $_.PSPath
    }
