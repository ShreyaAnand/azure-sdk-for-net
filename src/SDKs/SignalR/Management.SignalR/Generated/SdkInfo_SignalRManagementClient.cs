
using System;
using System.Collections.Generic;
using System.Linq;

internal static partial class SdkInfo
{
    public static IEnumerable<Tuple<string, string, string>> ApiInfo_SignalRManagementClient
    {
        get
        {
            return new Tuple<string, string, string>[]
            {
                new Tuple<string, string, string>("SignalRService", "Operations", "2018-03-01-preview"),
                new Tuple<string, string, string>("SignalRService", "SignalR", "2018-03-01-preview"),
            }.AsEnumerable();
        }
    }
}
