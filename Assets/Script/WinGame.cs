using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinGame : MonoBehaviour
{
    public GameObject MainWwin;
    public double total = 0;
    public Point p;
    public TextMeshProUGUI text;
    private float time_play = 60f;
    private void Update()
    {
        time_play -= Time.deltaTime;
        if(time_play <=0)
        {
            wingame();
        }    
        if(time_play >0)
        {
            Time.timeScale = 1;
        }    
    }

    public void wingame()
    {
        total = p.point;
        Time.timeScale = 0;
        MainWwin.SetActive(true);
        ShowScore();
    }
    public void ShowScore()
    {
        text.text = " Total " + total;
    }
}
