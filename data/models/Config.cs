namespace matomo_dashboard.data.models;

public class Config
{
    public string mode { get; set; }
    public string matomo_url { get; set; }
    public string matomo_key { get; set; }
    public int siteID { get; set; }
    public string output_folder { get; set; }
    public int reporting_year { get; set; }
}