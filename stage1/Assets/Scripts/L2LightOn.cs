using UnityEngine;

namespace Assets.Scripts
{
    public class L2LightOn : MonoBehaviour {

        public LampStagger LampStagger;
        public GameObject Lever;

        void   OnTriggerStay(Collider smbd)
        {
            if (smbd.CompareTag("Player")) {

                if (Input.GetKeyUp("e")) {
                    LampStagger.SetLightOn();
                    Lever.transform.rotation =Quaternion.Euler(Lever.transform.rotation.eulerAngles.x*(-1), 0, 0);

                }
            
            }
        }

    }
}

