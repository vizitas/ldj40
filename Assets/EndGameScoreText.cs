using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameScoreText : MonoBehaviour
{
    void Start()
    {
        Text text = GetComponent<Text>();

        text.text = "Treasure Collected: " + GameStateController.Instance.Score + " / 3\n";
        if (GameStateController.Instance.Score >= 3)
            text.text += "Congratulations!\nYou Won!";
    }

}
