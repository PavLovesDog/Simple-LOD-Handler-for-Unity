using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class High_Poly_Model : MonoBehaviour
{
    //array to hold all found mesh renderers in attached gameobject
    MeshRenderer[] meshes;

    private void Awake()
    {
        meshes = GetComponentsInChildren<MeshRenderer>(); // find and add mesh renderes to array
    }

    //Activate all meshrenderes within GameObject
    public void Activate()
    {
        foreach (var mesh in meshes)
            mesh.enabled = true;
    }

    //Dectivate all meshrenderes within GameObject
    public void Deactivate()
    {
        foreach (var mesh in meshes)
            mesh.enabled = false;
    }
}

