using UnityEngine;

namespace Assets.Scripts
{
    public class LampStagger : MonoBehaviour {
        private bool _state;
        public GameObject Lamp;
        public  GameObject[] L2Light;
        // Use this for initialization

        void Start () {
            _state = false;
            //    GameObject[] l2light = GameObject.FindGameObjectsWithTag("l2light") as GameObject[];
        }

        public void SetLightOn() {
            _state = !_state;
        }

   
        void Update () {
            if (!_state)
            {
                Lamp.GetComponent<Light>().range = 150;
                Lamp.GetComponent<Light>().intensity =Mathf.Lerp(0.5f, 10f, Random.Range(0.1f, 10f));
                //        GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward + Vector3.left);
                transform.localEulerAngles = (new Vector3(0, 0, Mathf.PingPong(Time.time * 5, 8)));
            
                foreach (GameObject light in L2Light)
                {
                    light.GetComponent<Light>().enabled = false;
                }
            }
            else {
                Lamp.GetComponent<Light>().intensity = 8f;
                Lamp.GetComponent<Light>().range = 250;
                foreach (GameObject light in L2Light)
                {
                    light.GetComponent<Light>().enabled = true;
                }
            }
        }
    }
}
