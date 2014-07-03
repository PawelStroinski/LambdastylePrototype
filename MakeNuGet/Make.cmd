md lib\net45
copy ..\bin\Release\Lambdastyle*.dll lib\net45
copy ..\bin\Release\Newtonsoft*.dll lib\net45
nuget pack
pause