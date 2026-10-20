
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rB;
    public float speed;
    //Agregando nuevo sistema de inputs
    private InputSystem_Actions inputActions;
    // Creando un vector para la entrada del usuario.
    public  Vector2 movePlayer;
    void Awake()
    {
        rB = GetComponent<Rigidbody>();
        inputActions = new InputSystem_Actions();// hay que crearlo con new
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
        movePlayer = inputActions.Player.Move.ReadValue<Vector2>();
        transform.Rotate(Vector3.up,speed*Time.deltaTime*movePlayer.x);
       
    }
    void FixedUpdate()
    {
        rB.AddForce(transform.forward*speed*movePlayer.y,ForceMode.Impulse);
       
    }



}
