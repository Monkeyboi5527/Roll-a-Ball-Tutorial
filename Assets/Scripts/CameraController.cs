using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("CameraController is starting...");
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called once per frame after all the standard Update methods
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
