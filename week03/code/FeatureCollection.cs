using System.Reflection.Metadata;

public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public Feature[] Features { get; set; }
}

public class Feature
{
    public Properties Properties { get; set; }
}

public class Properties
{
    public double Mag { get; set; } // Magnitude
    public string Place { get; set; } // Location name
}