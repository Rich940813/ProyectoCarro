using UnityEngine;

public class DispararBala : MonoBehaviour
{
    
    private Rigidbody rigidbody;
    public float velocidad;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        IniciarBala();
    }

    public void IniciarBala()
    {
        rigidbody.AddForce(transform.forward*velocidad,ForceMode.Impulse);
    }
}
