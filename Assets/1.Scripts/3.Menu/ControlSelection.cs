using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlSelection : MonoBehaviour
{
    private string selectedControlPlayer1 = "";
    private string selectedControlPlayer2 = "";

    public void SetControlLeftPlayer1()
    {
        selectedControlPlayer1 = "left";
    }

    public void SetControlRightPlayer1()
    {
        selectedControlPlayer1 = "right";
    }

    public void SetControlLeftPlayer2()
    {
        selectedControlPlayer2 = "left";
    }

    public void SetControlRightPlayer2()
    {
        selectedControlPlayer2 = "right";
    }

    // Agrega una función para iniciar la escena del juego con las selecciones actuales.
    public void StartGame()
    {
        PlayerPrefs.SetString("SelectedControlPlayer1", selectedControlPlayer1);
        PlayerPrefs.SetString("SelectedControlPlayer2", selectedControlPlayer2);

        // Imprime las selecciones en la consola.
        Debug.Log("Selección de Player 1: " + selectedControlPlayer1);
        Debug.Log("Selección de Player 2: " + selectedControlPlayer2);

        UnityEngine.SceneManagement.SceneManager.LoadScene("GameScene");
    }
}
