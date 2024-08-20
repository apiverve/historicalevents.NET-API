using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class events
{
    [JsonProperty("year")]
    public string year { get; set; }

    [JsonProperty("month")]
    public string month { get; set; }

    [JsonProperty("day")]
    public string day { get; set; }

    [JsonProperty("date")]
    public string date { get; set; }

    [JsonProperty("event")]
    public string event { get; set; }

    [JsonProperty("range")]
    public string range { get; set; }

    [JsonProperty("granularity")]
    public string granularity { get; set; }

}

public class data
{
    [JsonProperty("count")]
    public int count { get; set; }

    [JsonProperty("filteredOn")]
    public string[] filteredOn { get; set; }

    [JsonProperty("events")]
    public events[] events { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
