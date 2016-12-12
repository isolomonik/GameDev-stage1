using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class L5PictureManager : MonoBehaviour
    {
        public GameObject ButtonMore;
        public Text PictureInfo;
        public Text MorePictureInfoText;

        private GameObject[] _pictures;
        private float _maxDistance = 3;
        private GameObject _actualPicture;

        // Use this for initialization
        void Start()
        {
            _pictures = GameObject.FindGameObjectsWithTag("Picture");
            _actualPicture = _pictures[0];
        }

        // Update is called once per frame
        void Update()
        {
            float dist = (transform.position - _actualPicture.transform.position).sqrMagnitude;
            foreach (GameObject picture in _pictures)
            {
                if ((transform.position - picture.transform.position).sqrMagnitude < dist)
                {
                    _actualPicture = picture;
                    dist = (transform.position - picture.transform.position).sqrMagnitude;
                }
            }

            ButtonMore.SetActive((transform.position - _actualPicture.transform.position).sqrMagnitude <
                                 _maxDistance*_maxDistance);
            PictureInfo.text = _actualPicture.GetComponent<Assets.Scripts.L5Picture>().GetName();
            MorePictureInfoText.text = _actualPicture.GetComponent<Assets.Scripts.L5Picture>().ShowPictureInfo();
        }

        public void ButtonOnClick()
        {
            Debug.Log("Pressed");
        }
    }
}