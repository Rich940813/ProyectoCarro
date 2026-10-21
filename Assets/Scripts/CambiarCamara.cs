using UnityEngine;

public class CambiarCamara : MonoBehaviour
{
    private InputSystem_Actions inputActions;
    public GameObject camaraFrontal;
    public GameObject camaraTrasera;
    bool controlCamaraFrontal;
    bool controlCamaraTrasera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        inputActions = new InputSystem_Actions();
        controlCamaraFrontal = false;
        controlCamaraTrasera = true;
    }

    void OnEnable()
    {
        inputActions.Player.Enable();
    }

    // Update is called once per frame
    void Update()
    {
         if (inputActions.Player.CambiarCamara.triggered)
        {
            controlCamaraFrontal = !controlCamaraFrontal;
            controlCamaraTrasera = !controlCamaraTrasera;
            camaraFrontal.SetActive(controlCamaraFrontal);
            camaraTrasera.SetActive(controlCamaraTrasera);
        }
    }
}
