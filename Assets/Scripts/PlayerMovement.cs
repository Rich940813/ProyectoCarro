
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rB;
    public float speed;

    void Awake()
    {
        rB = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        rB.AddForce(Vector3.forward*speed,ForceMode.Impulse);
    }



}
