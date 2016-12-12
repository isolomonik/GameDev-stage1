using UnityEngine;
using System.Collections;

public class L4Button : MonoBehaviour
{
    private float _isPressed = -1f;
    private GameObject[] guardrails;

    // Use this for initialization
    void Start () {
        guardrails= GameObject.FindGameObjectsWithTag("guardrail");

    }
	
	
	void OnMouseDown() {
	    transform.position += new Vector3(0,  _isPressed*0.5f, 0);
        foreach (var guardrail in guardrails)
	        {
	            guardrail.transform.position += new Vector3(0, _isPressed*1.8f, 0);
	        }
	    _isPressed = _isPressed*(-1f);
        }
	
}
