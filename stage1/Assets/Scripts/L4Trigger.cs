using UnityEngine;

namespace Assets.Scripts
{
    public class L4Trigger : MonoBehaviour
    {
        private float timer = 5f;
        private int _score = 0;
        private GameObject[] _pins;
        public GameObject Replacer;
        public GameObject Ball;
        private readonly Vector3 _ballPosition = new Vector3(0.5f, 1f, -20f);
        private readonly Quaternion _pinsRotation = new Quaternion(0, 0, 0, 0);

        private readonly Vector3[] _pinPosition = new[]
        {
            new Vector3(0f, 1.5f, 19.7f),
            new Vector3(-1.4f, 1.5f, 21.3f),
            new Vector3(1.4f, 1.5f, 21.3f),
            new Vector3(-2.4f, 1.5f, 23f),
            new Vector3(0, 1.5f, 23f),
            new Vector3(2.4f, 1.5f, 23f),
            new Vector3(-3.6f, 1.5f, 25f),
            new Vector3(-1.4f, 1.5f, 25f),
            new Vector3(1.4f, 1.5f, 25f),
            new Vector3(3.6f, 1.5f, 25f)
        };

        void OnTriggerEnter(Collider smbd)
        {
            if (smbd.CompareTag("Ball"))
            {
                Invoke("SetPins", timer);
            }
        }

        // Use this for initialization
        void Start()
        {
            _pins = GameObject.FindGameObjectsWithTag("pin");
        }

        // Update is called once per frame
        void Update()
        {
        }

        void SetPins()
        {
            Replacer.transform.position += new Vector3(0, -5f, 0);
            for (int i = 0; i < _pins.Length; i++)
            {
                if (_pins[i].transform.position.y != 1.5f)
                {
                    _score++;
                }
                _pins[i].GetComponent<Rigidbody>().isKinematic = true;
                _pins[i].transform.position = _pinPosition[i];
                _pins[i].transform.rotation = _pinsRotation;
                _pins[i].GetComponent<Rigidbody>().isKinematic = false;
            }
            Debug.Log("score=" + _score);
            Invoke("SetNewGame", timer);
        }

        void SetNewGame()
        {
            _score = 0;
            Ball.GetComponent<Rigidbody>().isKinematic = true;
            Ball.transform.position = _ballPosition;
            Ball.transform.rotation = _pinsRotation;
            Ball.GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
            Ball.GetComponent<Rigidbody>().isKinematic = false;
            Replacer.transform.position += new Vector3(0, 5f, 0);
        }
    }
}