using UnityEngine;

public class CrearAvion : MonoBehaviour
{
    
    Rigidbody rigidbody;
    public float velocidad;
   
   void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        rigidbody.AddForce(transform.forward*velocidad,ForceMode.Impulse);
    }

    
}
