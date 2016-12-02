using UnityEngine;
using System.Collections;

public class L4Trigger : MonoBehaviour {
    private float timer=0f;
    private GameObject[] pins;
    public GameObject Replacer;
    private Vector3[] _pinPosition = new[] { new Vector3(0f, 1.5f, 19.7f),
                                             new Vector3(-1.4f, 1.5f, 21.3f),
                                             new Vector3(1.4f, 1.5f, 21.3f),
                                             new Vector3(-2.4f, 1.5f, 23f),
                                             new Vector3(0, 1.5f, 23f),
                                             new Vector3(2.4f, 1.5f, 23f),
                                             new Vector3(-3.6f, 1.5f, 25f),
                                             new Vector3(-1.4f, 1.5f, 25f),
                                             new Vector3(1.4f, 1.5f, 25f),
                                             new Vector3(3.6f, 1.5f, 25f)};

    void OnTriggerEnter(Collider smbd)
    {
        if (smbd.CompareTag("Ball"))
        {
            timer += Time.deltaTime;
         //   Replacer.transform.position += new Vector3(0, -5f, 0);
        }
    }

    // Use this for initialization
    void Start () {
        pins = GameObject.FindGameObjectsWithTag("pin");
        SetPins();
    }
	
	// Update is called once per frame
	void Update () {
       // Debug.LogWarning(timer);
        //if (timer > 2) {
           Replacer.transform.position += new Vector3 (0,-5f,0);
          //     SetPins();
          //      }
    }

    void SetPins() {
        for (int i=0; i< pins.Length; i++)
        {
            pins[i].GetComponent<Transform>().position=_pinPosition[i];
        }
    }
}
