using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public GameObject player;
    private PlayerMovement playerMovement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        playerMovement = player.GetComponent<PlayerMovement>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up,playerMovement.speed/12.3f*playerMovement.movePlayer.x*Time.deltaTime);
        transform.position = player.transform.position;
    }
}
