using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class NextLevel : MonoBehaviour
    {
        private readonly float _cMaxDistance = 20f;
        public GameObject Player;
        public GameObject Door;
        public GameObject Text;
        private float _dist;
        private Vector3 _startPosition;

        private void Start()
        {
            _startPosition = transform.position;
            Debug.Log(_startPosition);
        }

        private void Update()
        {
            _dist = (transform.position - Player.transform.position).sqrMagnitude;
            if (_dist < _cMaxDistance*_cMaxDistance)
            {
                Door.transform.position = _startPosition + (new Vector3(0, 800f/_dist, 0));
                // Debug.Log(transform.Find("DoorText").position);
                // Debug.Log(dist);
                Text.GetComponent<TextMesh>().color = Color.Lerp(Color.green, Color.black,
                    _dist/(_cMaxDistance*_cMaxDistance));
            }

            else
            {
                Door.transform.position = _startPosition;
                Text.GetComponent<TextMesh>().color = Color.black;
            }
        }

        void OnTriggerEnter(Collider smbd)
        {
            if (smbd.CompareTag("Player"))
            {
                SceneManager.LoadScene("Level2");
            }
        }
    }
}