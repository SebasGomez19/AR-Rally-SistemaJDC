using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonJugar : MonoBehaviour
{
    // Nombre de la escena a la que quieres ir
    public string nombreEscenaJuego = "SeleccionPersonaje";

    public void Jugar()
    {
        Debug.Log("Botón Jugar presionado");

        // Verificar si la escena existe en los Build Settings
        if (Application.CanStreamedLevelBeLoaded(nombreEscenaJuego))
        {
            SceneManager.LoadScene(nombreEscenaJuego);
        }
        else
        {
            Debug.LogError("⚠️ La escena '" + nombreEscenaJuego + "' no está agregada en los Build Settings.");
        }
    }

    public void QuitarSonido()
    {
        Debug.Log("Botón Quitar Sonido presionado");
        // Aquí luego puedes pausar el audio o cambiar un ícono
    }

    public void ComoJugar()
    {
        Debug.Log("Botón Cómo Jugar presionado");
        // Aquí puedes abrir un panel de ayuda o mostrar instrucciones
    }
}
