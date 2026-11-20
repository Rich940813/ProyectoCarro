using UnityEngine;

public class CrearAvion : MonoBehaviour
{
    
    Rigidbody rigidbody;
    public float velocidad;
    public float speed;

    private bool startTurn = true;
    private bool startTurn2 = false;
   
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
         if (transform.position.z > 120 && startTurn)
        {
            rigidbody.AddTorque(Vector3.up*speed,ForceMode.Impulse);
           
            
            if (transform.eulerAngles.y >= 180)
            {
                startTurn = false;
                //speed = 0;
                rigidbody.angularVelocity = Vector3.zero;
                rigidbody.linearVelocity = Vector3.zero;
                Debug.Log("Funcionó la de transform");
                startTurn2 = true; 
            }
            
        }

         if (transform.position.z < 100 && startTurn2)
        {
             rigidbody.AddTorque(Vector3.up*speed,ForceMode.Impulse);
             Debug.Log(transform.eulerAngles.y);
             if (transform.eulerAngles.y >359)
            {
                startTurn = true;
                //speed = 0;
                rigidbody.angularVelocity = Vector3.zero;
                rigidbody.linearVelocity = Vector3.zero;
                Debug.Log("Funcionó la de transform22222");
                startTurn2 = false ; 
            }
        }
    }

    
}
