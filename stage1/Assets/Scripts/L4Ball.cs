using UnityEngine;
using System.Collections;

public class L4Ball : MonoBehaviour {
    private float _power=10000;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown() {
        GetComponent<Rigidbody>().AddForce(_power*transform.forward);
    }
}
