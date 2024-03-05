using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;


    private void Awake()
    {
        Instance = this;
    }

    public TMP_Text Scoretext;

    public int score;


    private void Start()
    {
        Scoretext.text = "Skor: 0";
    }
    public void UpScore()
    {
        score++;
        Scoretext.text = "Skor:" + score;


    }

    public void OnMouseDown()
    {
        score--;
        Scoretext.text= "Skor: " + score;
    }











}
