using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreRenderer : MonoBehaviour
{
    public HealthScript player;

    void Update()
    {
        GetComponent<Text>().text = "Score: " + player.health.ToString(); 
    }
}
