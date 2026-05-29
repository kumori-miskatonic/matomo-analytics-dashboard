using NPoco;

namespace matomo_dashboard.data.actions;

[TableName("location")]
[PrimaryKey("id")]
public class Location
{
    public int id { get; }
    public string route { get; }
    public string label { get; }
    public bool promoted { get; }
    public string description { get; }
    public bool home_page { get; }
}