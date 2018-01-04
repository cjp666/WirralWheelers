using System;
using System.Collections.Generic;

public class Ride
{
    public int Id
    {
        get
        {
            return int.Parse(Date.ToString("yyyyMMdd"));
        }
    }
    public string Title { get; set; }
    public DateTime Date { get; set; }
    public string StartLocation { get; set; }
    public string RideLeader { get; set; }
    public string Level { get; set; }
    public string Description { get; set; }
    public string Comments1 { get; set; } = "";
    public string Comments1By { get; set; } = "";
    public List<string> Comment1Photos { get; set; } = new List<string>();
    public string Comments2 { get; set; } = "";
    public string Comments2By { get; set; } = "";
    public List<string> Comment2Photos { get; set; } = new List<string>();

    public string Map
    {
        get
        {
            return $"{Id.ToString()}map.jpg";
        }
    }

    public string Distance
    {
        get
        {
            return $"{Id.ToString()}distance.jpg";
        }
    }

    public string Elevation
    {
        get
        {
            return $"{Id.ToString()}elevation.jpg";
        }
    }
}