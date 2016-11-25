using UnityEngine;
using System.Collections;

public class L2LightOn : MonoBehaviour {

 public LampStagger LampStagger;
    public GameObject lever;

 void   OnTriggerStay(Collider smbd)
    {
        if (smbd.CompareTag("Player")) {

           if (Input.GetKeyUp("e")) {
                LampStagger.SetLightOn();
                lever.transform.rotation =Quaternion.Euler(lever.transform.rotation.eulerAngles.x*(-1), 0, 0);

            }
            
        }
    }

}

