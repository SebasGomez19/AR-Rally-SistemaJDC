using UnityEngine;
using UnityEngine.UI;

public class SeleccionPersonaje : MonoBehaviour
{
    [Header("Lista de personajes disponibles")]
    public GameObject[] personajes; // arrastra tus modelos o prefabs aquí

    private int personajeSeleccionado = -1;

    public void SeleccionarPersonaje(int indice)
    {
        personajeSeleccionado = indice;
        Debug.Log("Personaje seleccionado: " + personajes[indice].name);

        // Guarda el índice para usarlo en otra escena
        PlayerPrefs.SetInt("PersonajeSeleccionado", indice);
        PlayerPrefs.Save();
    }

    public int ObtenerPersonajeSeleccionado()
    {
        return PlayerPrefs.GetInt("PersonajeSeleccionado", 0);
    }
}
