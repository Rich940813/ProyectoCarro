using UnityEngine;

public class MoverCarros : MonoBehaviour
{
    Rigidbody rigidbody;
    public float velocidad;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
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
        rigidbody.AddForce(transform.forward*velocidad,ForceMode.Impulse);
    }
}
