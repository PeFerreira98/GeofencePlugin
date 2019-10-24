using System;

namespace Plugin.Geofence.Abstractions
{
    /// <summary>
    /// GeofenceNotInitializedException Exception class
    /// Exception thown when plugin is not initialized
    /// </summary>
    [Serializable]
    public class GeofenceNotInitializedException : Exception
    {
        public GeofenceNotInitializedException()
        {

        }

        public GeofenceNotInitializedException(string message) : base(message)
        {

        }

        public GeofenceNotInitializedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected GeofenceNotInitializedException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
        {
        }
    }
}
