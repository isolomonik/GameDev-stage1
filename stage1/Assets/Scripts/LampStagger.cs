using UnityEngine;
using System.Collections;

public class LampStagger : MonoBehaviour {
    public int state;
    public GameObject lamp;
	// Use this for initialization
	void Start () {
      //  state = 1;
	}
	
	// Update is called once per frame
	void Update () {
        if (state == 1)
        {
            lamp.GetComponent<Light>().intensity =Mathf.Lerp(0.5f, 10f, Random.Range(0.1f, 10f));
            transform.localEulerAngles=(new Vector3(0, 0, Mathf.PingPong(Time.time * 50, 120)));
         //    transform.RotateAround(Vector3.zero, Vector3.left, Mathf.PingPong(Time.deltaTime,1f));
        }
        else { lamp.GetComponent<Light>().intensity = 8f; }
    }
}
