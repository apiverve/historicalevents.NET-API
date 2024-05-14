using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("count")]
    public int count { get; set; }

    [JsonProperty("filteredOn")]
    public string[] filteredOn { get; set; }

    [JsonProperty("events")]
    public object[] events { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
