using UnityEngine;

public class CrearCarros : MonoBehaviour
{
    public GameObject carros;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       InvokeRepeating ("instanciarCarros",1f,2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void instanciarCarros()
    {
        GameObject miscarros =  Instantiate(carros,new Vector3 (-88,2,Random.Range(240f,260f)),carros.transform.rotation);
        Destroy (miscarros,5f);
    }
}
