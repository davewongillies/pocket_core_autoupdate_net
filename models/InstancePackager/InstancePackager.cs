namespace pannella.analoguepocket;

public class InstancePackager
{
    public List<DataSlot> data_slots { get; set; }
    public string output { get; set; }
    public string platform_id { get; set; }
    public Dictionary<string, object> slot_limit { get; set; }
}