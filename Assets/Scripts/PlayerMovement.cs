
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rB;
    public float speed;
    //Agregando nuevo sistema de inputs
    private InputSystem_Actions inputActions;
    // Creando un vector para la entrada del usuario.
    private Vector2 movePlayer;
    void Awake()
    {
        rB = GetComponent<Rigidbody>();
        inputActions = new InputSystem_Actions();
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
    }
    void FixedUpdate()
    {
        rB.AddForce(Vector3.forward*speed*movePlayer.y,ForceMode.Impulse);
    }



}
