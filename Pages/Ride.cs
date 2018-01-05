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
    public List<RideComment> Comments { get; set; } = new List<RideComment>();

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

public class RideComment 
{
    public string Comment { get; set; }

    public string PostedBy { get; set; }

    public List<string> Photos { get; set; } = new List<string>();
}
