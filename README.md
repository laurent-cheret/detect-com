# detect-com
Detect COM ports in use Win32_SerialPort (vendor ID, product ID, description, name...)
## setup
Create a project (recommended Visual Studio) .Net Core.

## libraries

System.Management need to be installed in the project folder (where C# file is located)

```
cd ~path-to-c#file
dotnet add package System.Management --version 5.0.0-preview.6.20305.6
```

For more information, visit:
https://www.nuget.org/packages/System.Management/
