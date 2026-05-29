using Microsoft.AspNetCore.Mvc;
using NPoco;

namespace matomo_dashboard.data.actions;

[TableName("object")]
[PrimaryKey("id")]
public class DcObject
{
    // I definitely don't need all of these, but best to get them all jotted down early
    // and then delete the ones I don't need later
    // as opposed to having to hunt for the column names again down the line.
    public int id { get; }
    public DateTime created { get; }
    public int job { get; }
    public string ead_id { get; }
    public string catalog_id { get; }
    public int location_id { get; }
    public string title { get; set; }
    public string description { get; set; }
    public string edtf_date { get; }
    public string identifier { get; }
    public bool unindexed { get; }
    public bool meta_lock { get; }
    public float xcm { get; }
    public float ycm { get; }
    public float zcm { get; }
    public bool has_tei { get; set; }
    public int folder_pid { get; set; }
    public int folder_pos { get; set; }
    public string bd_identifier { get; set; }
    public string bd_filesize { get; set; }
    public string unindexed_note { get; set; }
    public bool online { get; }
}