using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {
    public GameObject door;

    void OnTriggerEnter(Collider smbd) {
        if (smbd.CompareTag("Player")) {
            door.GetComponent<MeshRenderer>().transform.Translate(Vector3.up * 1f * 10f);
       }
	}

    void OnTriggerExit(Collider smbd)
    {
        if (smbd.CompareTag("Player"))
        {
            door.GetComponent<MeshRenderer>().transform.Translate(Vector3.down * 1f * 10f);
        }
    }
}
