using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseManager : MonoBehaviour
{
    public GameObject menuPausa;
    private bool menuOn;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuOn = !menuOn;
        }

        if (menuOn == true)
        {
            menuPausa.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;

        }
        else
        {
            MenuDesactivado();
        }

    }
    public void Reanudar()
    {
        MenuDesactivado();
        menuOn = false;
    }
    public void Reiniciar()
    {
        SceneManager.LoadScene("Laberinto");
    }
    public void Salir()
    {
        SceneManager.LoadScene("Interfaz Principal");
    }
    private void MenuDesactivado()
    {
        menuPausa.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
    }
}
