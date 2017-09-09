using UnityEngine;
using System.Collections;

public class Impactos : MonoBehaviour {


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemigo"))
        {
            Debug.Log(other.name);
        }

        
    }
}
