using System;

namespace Plugin.Geofence.Abstractions
{
    public interface IGeofenceListener
    {
        void OnMonitoringStarted(string identifier);
        void OnMonitoringStopped();
        void OnMonitoringStopped(string identifier);
        void OnRegionStateChanged(GeofenceResult result);
        void OnError(String error);
        void OnAppStarted();
        void OnLocationChanged(GeofenceLocation location);
    }
}
