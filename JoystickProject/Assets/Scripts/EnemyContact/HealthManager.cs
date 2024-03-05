using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Image Heart1;
    public Image Heart2;
    public Image Heart3;

    [SerializeField] private int health;

    [SerializeField] private GameObject LosePanel;
    [SerializeField] private TMP_Text losescore;


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Shark"))
        {
            health--;
            ImageDisabler();
            transform.position = new Vector3(-30, 1.1f, 24);
        }
    }



    private void ImageDisabler()
    {
        if (health == 2)
        {
            Heart3.enabled = false;
        }
        else if (health == 1)
        {
            Heart2.enabled = false;
        }
        else if(health == 0)
        {
            Heart1.enabled = false;
            Time.timeScale = 0;
            LosePanel.SetActive(true);
            losescore.text = "Skor: " + ScoreManager.Instance.score;
        }
    
    
    
    
    
    }

}
