// Include the Newtonsoft.Json library to enable JSON serialization and deserialization features.
using Newtonsoft.Json;

// Declare a namespace for the current code. This helps in organizing and grouping related classes and functions.
namespace Company.Function
{
    // Define a public class named 'Counter'. This class represents a model for counting something, 
    // with each instance holding an ID and a count value.
    public class Counter
    {
        // Apply the JsonProperty attribute to the Id property.
        // This specifies the name of the property as it should appear in JSON when the object is serialized or deserialized.
        // Here, it ensures the JSON property name for 'Id' is always lowercase "id".
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        // Apply the JsonProperty attribute to the Count property.
        // This specifies the name of the property as it should appear in JSON when the object is serialized or deserialized.
        // Here, it ensures the JSON property name for 'Count' is always lowercase "count".
        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }
    }
}
