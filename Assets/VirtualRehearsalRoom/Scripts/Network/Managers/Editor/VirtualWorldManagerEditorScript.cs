﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(VirtualWorldManager))]
public class VirtualWorldManagerEditorScript : Editor 
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        VirtualWorldManager virtualWorldManager = (VirtualWorldManager)target;

        //if (GUILayout.Button("Go Outdoors"))
        //{
        //    virtualWorldManager.GoOutdoors();
        //}

        //if (GUILayout.Button("Go to Theatre"))
        //{
        //    virtualWorldManager.GoToTheatre();
        //}
    }
}
