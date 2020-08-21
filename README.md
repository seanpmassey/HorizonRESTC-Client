## VMware Horizon Rest C# Client

This repo, is an example of the VMware Horizon REST API, converted using Swagger Codegen, for native use in .Net Framework (>4.5) c#. To speed up the process of digestion of the API, I've created a helper class to wrap up the authentication, refresh and log off attributes and embedded the sub API's under a single object to be utilized.

The documentation for the sub API's can be found here: 

https://code.vmware.com/apis/1007/view-rest-api

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

## Example Usage:

``` c#
     HorizonRESTClient client = new HorizonRESTClient("https://yourconnectionserver/rest");

    try
    {
        client.Logon("username", "password", "domain");
        var farms = client.Monitoring.ListFarmMonitors();
        var RDSHServers = client.Monitoring.ListRDSServerMonitors();
        var ConnectionServers = client.Monitoring.ListConnectionServerMonitors();


        // demo the ability to refresh
        client.TryRefreshSession();

        var pools = client.Inventory.ListDesktopPools();

        var pool = client.Inventory.GetDesktopPool(pools[0].Id);
        var sessions = client.Inventory.ListSessionInfo();

        // log out when complete
        client.LogOut();
    }
    catch(Exception ex)
    {
        Console.WriteLine("Exception trapped during routine: {0}", ex.ToString());
    }
  

```

## Quick start Guide:

1: Grab a copy of the dll's in the bin folder and add them as a references to a c# project.
Once
