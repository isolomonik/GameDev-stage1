using UnityEngine;
using System.Collections;

public class L2LightOn : MonoBehaviour {
    
 void   OnTriggerStay(Collider smbd)
    {
        if (smbd.CompareTag("Player")) {

            if (Input.GetKeyUp("e")) {
//GameObject.FindGameObjectWithTag("switch").GetComponent<Script>.
            }
            
        }
    }

}

