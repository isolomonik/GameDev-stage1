using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {
    public GameObject door;

    void OnTriggerEnter(Collider smbd) {
        if (smbd.CompareTag("Player")) { 
       // door.GetComponent<MeshRenderer>().
       }
	}

    void OnTriggerExit(Collider smbd)
    {
        if (smbd.CompareTag("Player"))
        {
            // door.GetComponent<MeshRenderer>().
        }
    }
}
