cd..
$currentLocation = (Get-Location).ToString() + '\build'
dotnet publish -c Release -p:ZipOutputPath=$currentLocation 