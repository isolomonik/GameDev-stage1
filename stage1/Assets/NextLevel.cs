using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

    void OnTriggerEnter(Collider smbd) {
        if (smbd.CompareTag("Player")){
   SceneManager.LoadScene("Level2");
    }
   }
}
