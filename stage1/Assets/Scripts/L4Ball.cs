using UnityEngine;

namespace Assets.Scripts
{
    public class L4Ball : MonoBehaviour {
        private float _power=5000f;
        private int _timerPressKey=1;
    
        // Use this for initialization
        void Start () {
	
        }
	
        // Update is called once per frame
        void Update () {
            if (Input.GetKey(KeyCode.Space)|Input.GetMouseButton(0)) {
                _timerPressKey++;
            }
        }

        void OnMouseUp() {
            GetComponent<Rigidbody>().AddForce((_power + _timerPressKey*500f) * transform.forward, ForceMode.Force);
            _timerPressKey = 1;
        }
    }
}
