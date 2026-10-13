using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int[] secuenciaJugador;
    [SerializeField] int indiceActualJugador;
    [SerializeField] GenerarSecuencia generarSecuencia;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ComprobarSecuencia(int boton)
    {
        if (generarSecuencia.puedeJugar == false)
        {
            return;
        }
        secuenciaJugador[indiceActualJugador] = boton;

        if (generarSecuencia.secuencia[indiceActualJugador] != secuenciaJugador[indiceActualJugador])
        {
            Debug.Log("Game Over");
        }
        else
        {
            indiceActualJugador++;
        }
        if (indiceActualJugador == generarSecuencia.indiceActual)
        {
            if (indiceActualJugador == secuenciaJugador.Length)
            {
                Debug.Log("He Ganado");
                return;
            }
            StartCoroutine(generarSecuencia.CrearSecuencia());
            indiceActualJugador = 0;

        }

    }
    public void Perder()
    {
        indiceActualJugador = 0;
        generarSecuencia.indiceActual = 0;
        for (int i = 0; i < secuenciaJugador.Length; i++)
        {
            secuenciaJugador[i] = 0;
            generarSecuencia.secuencia[i] = 0;
        }
        StartCoroutine(generarSecuencia.CrearSecuencia());
    }
}
