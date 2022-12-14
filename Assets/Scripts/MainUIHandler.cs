using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainUIHandler : MonoBehaviour
{
    public TMP_Text highScore;

    // Start is called before the first frame update
    void Start()
    {
        highScore.text = new string("Highscore: " + GameManager.Instance.playerNameWithHighscore + " " + GameManager.Instance.highScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
