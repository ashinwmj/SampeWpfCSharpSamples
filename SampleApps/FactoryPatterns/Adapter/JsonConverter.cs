using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Newtonsoft.Json;

namespace FactoryPatterns.Adapter
{
    /// <summary>
    /// Our requirement to convert list to jason. But we have to convert from xml to json
    /// </summary>
public class JsonConverter
{
    private IEnumerable<Manufacturer> _manufacturers;
 
    public JsonConverter(IEnumerable<Manufacturer> manufacturers)
    {
        _manufacturers = manufacturers;
    }
 
    public void ConvertToJson()
    {
        var jsonManufacturers = JsonConvert.SerializeObject(_manufacturers, Newtonsoft.Json.Formatting.Indented);
 
        Console.WriteLine("\nPrinting JSON list\n");
        Console.WriteLine(jsonManufacturers);
    }
} 
}
