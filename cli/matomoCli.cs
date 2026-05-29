using NPoco;
using Xunit;
using DocumentFormat.OpenXml;
using matomo_dashboard.data.models;
using YamlDotNet;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace matomo_dashboard.cli;

public class matomoCli
{
    public FauxdoraDatabase fauxdora;
    public static string yamlpath = "../../config.yaml";
    
    // note to self: ensure to amend so that this is the entry point
    public static void Main(string[] args)
    {
        var config = ParseYaml();
        
        // string mode = config.mode;
        // string matomo_key = config.matomo_key;
        // int siteID = config.siteID;
        // string output_folder = config.output_folder;
        // int reporting_year = config.reporting_year;

        if (config.mode == "csv")
        {
            
        }
        else if (config.mode == "database")
        {
            
        }
        else
        {
            
        }
    }

    public static Config ParseYaml()
    {
        var yamlFileStr = File.ReadAllText(yamlpath);
        
        var deserializer = new DeserializerBuilder()
            .WithNamingConvention(UnderscoredNamingConvention.Instance)
            .Build();
        
        var yaml = deserializer.Deserialize<Config>(yamlFileStr);
        return yaml;
        
    }
    
}