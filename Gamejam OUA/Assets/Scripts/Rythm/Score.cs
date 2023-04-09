using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Check forScore;
    public TextMeshProUGUI scoreText;

    private void Start() 
    {
        //scoreText.text = "Score: " + forScore.deletedArrow + "/" + forScore.totalArrow;
    }

    private void Update() 
    {
        if(forScore.arrowDeleted)
        {
            forScore.deletedArrow++;
            scoreText.text = "Score: " + forScore.deletedArrow + "/" + forScore.totalArrow;
            forScore.arrowDeleted = false;
        }
    }
}
