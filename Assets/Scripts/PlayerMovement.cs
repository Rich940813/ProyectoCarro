
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rB;
    public float speed;
    //Agregando nuevo sistema de inputs
    private InputSystem_Actions inputActions;
    void Awake()
    {
        rB = GetComponent<Rigidbody>();
    }
    void OnEnable()
    {
        inputActions.Player.Enable();
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
