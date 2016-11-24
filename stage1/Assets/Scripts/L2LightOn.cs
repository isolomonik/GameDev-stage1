using UnityEngine;
using System.Collections;

public class L2LightOn : MonoBehaviour {

 LampStagger LampStagger;

 void   OnTriggerStay(Collider smbd)
    {
        if (smbd.CompareTag("Player")) {

            if (Input.GetKeyUp("e")) {

                LampStagger.SetLightOn();
            }
            
        }
    }

}

