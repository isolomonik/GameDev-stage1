using UnityEngine;
using System.Collections;

public class LampStagger : MonoBehaviour {
    private int state;
    public GameObject lamp;
   public  GameObject[] l2light;
    // Use this for initialization
    void Start () {
        state = 1;
    //    GameObject[] l2light = GameObject.FindGameObjectsWithTag("l2light") as GameObject[];
	}

    public void SetLightOn() {
        state = 2;
    }

    public void SetLightOff()
    {
        state = 1;
    }

    void Update () {
        if (state == 1)
        {
            lamp.GetComponent<Light>().range = 150;
            lamp.GetComponent<Light>().intensity =Mathf.Lerp(0.5f, 10f, Random.Range(0.1f, 10f));
    //        GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward + Vector3.left);
            transform.localEulerAngles = (new Vector3(0, 0, Mathf.PingPong(Time.time * 5, 8)));
            
            foreach (GameObject light in l2light)
            {
                light.GetComponent<Light>().enabled = false;
            }
        }
        else {
            lamp.GetComponent<Light>().intensity = 8f;
            lamp.GetComponent<Light>().range = 250;
            foreach (GameObject light in l2light)
            {
                light.GetComponent<Light>().enabled = true;
            }
        }
    }
}
