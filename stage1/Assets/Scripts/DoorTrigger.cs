using UnityEngine;

namespace Assets.Scripts
{
    public class DoorTrigger : MonoBehaviour {

        void OnTriggerEnter(Collider smbd)
        {
            if (smbd.CompareTag("Player"))
            {
                // SceneManager.LoadScene(0);
            }
        }
    }
}
