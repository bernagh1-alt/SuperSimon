using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciarSalir : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("EscenaBernardo");

    }
    public void Salir()
    {
        Application.Quit();
    }
}
