Set-StrictMode -Version Latest
$templateName = "template"
$templatePath =     "./$templateName/mtr"
$contentDirectory = "./$templateName/mtr/content"
$nugetPath = "./$templateName/nuget.exe"
$nugetOut =  "./$templateName/nuget"
$nugetUrl = "https://dist.nuget.org/win-x86-commandline/v5.9.1/nuget.exe"


Write-Output "Copy CleanArchTemplate.Api template"
Copy-Item -Path "./content/CleanArchTemplate.Api" -Recurse -Destination "$contentDirectory/CleanArchTemplate.Api" -Container

Write-Output "Copy CleanArchTemplate.BlazorServer template"
Copy-Item -Path "./content/CleanArchTemplate.BlazorServer" -Recurse -Destination "$contentDirectory/CleanArchTemplate.BlazorServer" -Container

Write-Output "Copy CleanArchTemplate.BlazorWASM template"
Copy-Item -Path "./content/CleanArchTemplate.BlazorWASM" -Recurse -Destination "$contentDirectory/CleanArchTemplate.BlazorWASM" -Container

Write-Output "Copy CleanArchTemplate.BlazorWebApp template"
Copy-Item -Path "./content/CleanArchTemplate.BlazorWebApp" -Recurse -Destination "$contentDirectory/CleanArchTemplate.BlazorWebApp" -Container

Write-Output "Copy CleanArchTemplate.MVC template"
Copy-Item -Path "./content/CleanArchTemplate.MVC" -Recurse -Destination "$contentDirectory/CleanArchTemplate.MVC" -Container

Write-Output "Copy nuspec"
Copy-item -Force -Recurse "CleanArch.Templates.nuspec" -Destination $templatePath

Write-Output "Download nuget.exe from $nugetUrl"
Invoke-WebRequest -Uri $nugetUrl -OutFile $nugetPath

Write-Output "Pack nuget"
$cmdArgList = @( "pack", "$templatePath\CleanArch.Templates.nuspec",
				 "-OutputDirectory", "$nugetOut", "-NoDefaultExcludes")
& $nugetPath $cmdArgList 