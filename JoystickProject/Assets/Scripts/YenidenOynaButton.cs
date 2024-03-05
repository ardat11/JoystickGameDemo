using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YenidenOynaButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        Yenidenoyna();
    }

    void Yenidenoyna()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0f;
    }



}
