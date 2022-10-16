using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Low_Poly_Model : MonoBehaviour
{
    //array to hold all found mesh renderers in attached GameObject
    MeshRenderer[] meshes;

    private void Awake()
    {
        // find and add mesh renderes to array
        meshes = GetComponentsInChildren<MeshRenderer>();
    }

    public void Activate()
    {
        //Activate all meshrenderes within GameObject
        foreach (var mesh in meshes)
            mesh.enabled = true;
    }

    public void Deactivate()
    {
        //Activate all meshrenderes within GameObject
        foreach (var mesh in meshes)
            mesh.enabled = false;
    }
}

