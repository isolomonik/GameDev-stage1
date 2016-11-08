using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

    private const float cMaxDistance = 20f;
    public GameObject player;
    public GameObject door;
    public GameObject text;
    private float dist;
    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
        Debug.Log(startPosition);
    }
    private void Update()
    {
        dist = (transform.position - player.transform.position).sqrMagnitude;
        if (dist < cMaxDistance * cMaxDistance)
        {
             door.transform.position = startPosition+(new Vector3(0, 800f/dist, 0))  ;
           // Debug.Log(transform.Find("DoorText").position);
           // Debug.Log(dist);
            text.GetComponent<TextMesh>().color = Color.Lerp(Color.green, Color.black, dist /( cMaxDistance * cMaxDistance));
          }

         else {door.transform.position = startPosition;
            text.GetComponent<TextMesh>().color = Color.black;
        }
    }

    void OnTriggerEnter(Collider smbd) {
        if (smbd.CompareTag("Player")){
           SceneManager.LoadScene("Level2");
    }
   }
}
