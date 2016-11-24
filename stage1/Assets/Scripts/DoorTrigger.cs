using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DoorTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider smbd)
    {
        if (smbd.CompareTag("Player"))
        {
           // SceneManager.LoadScene(0);
        }
    }
}
