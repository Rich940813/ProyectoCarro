using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        offset = new Vector3(0,6,-9);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
