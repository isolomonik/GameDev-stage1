using UnityEngine;
using System.Collections;

public class L5PictureManager : MonoBehaviour {

    public GameObject ButtonMore; 

    private GameObject[] _pictures;
    private float _maxDistance = 3;
    private GameObject _actualPicture;

	// Use this for initialization
	void Start () {
        _pictures = GameObject.FindGameObjectsWithTag("Picture");
        _actualPicture = _pictures[0];

    }
	
	// Update is called once per frame
	void Update () {
        float dist = (transform.position - _actualPicture.transform.position).sqrMagnitude;
        foreach (GameObject picture in _pictures) {
            if ((transform.position - picture.transform.position).sqrMagnitude <dist )
            {
                _actualPicture = picture;
                dist = (transform.position - picture.transform.position).sqrMagnitude;
            }
        }
        
        if ( (transform.position - _actualPicture.transform.position).sqrMagnitude < _maxDistance * _maxDistance)
        {
            ButtonMore.SetActive(true);
        }
        else
        {ButtonMore.SetActive(false);

        }

        }
}
