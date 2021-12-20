using UnityEngine;

public class cameraScript : MonoBehaviour
{

    public Transform player;

    
    void Update()
    {
        transform.position = player.transform.position + new Vector3(-4, 2, 16);
    }
}