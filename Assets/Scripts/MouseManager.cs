using UnityEngine;
using UnityEngine.InputSystem;

public class MouseManager : MonoBehaviour
{
    public GameObject bala; 
     public Transform firePoint;
    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.Log("Mouse was Pressed");
            InstanciarBala();
        }
    }

    public void InstanciarBala()
    {
       GameObject mybala = Instantiate(bala,firePoint.transform.position,firePoint.transform.rotation);
       Destroy (mybala,4f);
    }
}
