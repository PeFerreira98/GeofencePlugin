using System;

namespace Plugin.Geofence.Abstractions
{
    /// <summary>
    /// GeofenceNotInitializedException Exception class
    /// Exception thown when plugin is not initialized
    /// </summary>
    public class GeofenceNotInitializedException : Exception
    {
        public GeofenceNotInitializedException()
        {

        }

        public GeofenceNotInitializedException(string message) : base(message)
        {

        }
    }
}
