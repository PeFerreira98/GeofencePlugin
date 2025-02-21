﻿namespace Plugin.Geofence.Abstractions
{
    /// <summary>
    /// GeofenceTransition enum
    /// </summary>
    public enum GeofenceTransition
    {
        /// <summary>
        /// Entry transition
        /// </summary>
        Entered,
        /// <summary>
        /// Exit transition
        /// </summary>
        Exited,
        /// <summary>
        /// Stayed in transition
        /// </summary>
        Stayed,
        /// <summary>
        /// Unknown transition
        /// </summary>
        Unknown
    }
}
