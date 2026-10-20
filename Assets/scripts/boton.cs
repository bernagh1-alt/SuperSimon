using UnityEngine;

public class boton : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PulsarBoton(int boton)
    {
        Debug.Log("hola");
        gameManager.ComprobarSecuencia(boton);
    }
}
