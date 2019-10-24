using System;

namespace Plugin.Geofence.Abstractions
{
    public class GeofenceLocation
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime Date { get; set; }
        public double Accuracy { get; set; }

        public GeofenceLocation()
        {
        }

        public GeofenceLocation(GeofenceLocation loc)
        {
            Latitude = loc.Latitude;
            Longitude = loc.Longitude;
            Date = loc.Date;
            Accuracy = loc.Accuracy;
        }

    }
}
