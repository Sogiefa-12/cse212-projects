using System.Text.Json.Serialization;

  // TO DO Problem 5 - ADD YOUR CODE HERE
    // 1. Create a class called FeatureCollection



public class Feature
{
    public Properties Properties { get; set; }
}

public class Properties
{
    [JsonPropertyName("place")]
    public string Location { get; set; }

    [JsonPropertyName("mag")]
    public decimal Magnitude { get; set; }
}

public class FeatureCollection
{
    public List<Feature> Features { get; set; }
}
