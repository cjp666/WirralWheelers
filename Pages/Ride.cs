using System;

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