﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Display Mode that the Custom Inspector of an AIWaypointNetwork
// component can be in
public enum PathDisplayMode { None, Connections, Paths }

// -------------------------------------------------------------------
// CLASS	:	AIWaypointNetwork
// DESC		:	Contains a list of waypoints. Each waypoint is a 
//				reference to a transform. Also contains settings
//				for the Custom Inspector
// ------------------------------------------------------------------
public class AIWaypointNet : MonoBehaviour {
    [HideInInspector]
    public PathDisplayMode DisplayMode = PathDisplayMode.Connections;   // Current Display Mode
    [HideInInspector]
    public int UIStart = 0;                                         // Start wayopoint index for Paths mode
    [HideInInspector]
    public int UIEnd = 0;                                           // End waypoint index for Paths mode

    // List of Transform references
    public List<Transform> Waypoints = new List<Transform>();
}
