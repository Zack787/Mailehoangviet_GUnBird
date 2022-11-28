using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasScript : MonoBehaviour
{
    public TextMeshProUGUI text;

    public void ShowScore(double score)
    {
        text.text = "Point: " + score;
    }    
}
