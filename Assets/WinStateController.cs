using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinStateController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            int score = 0;
            var tresures = FindObjectsOfType<TresureController>();
            foreach (var tresure in tresures)
            {
                if (tresure.connected)
                    score++;
            }
            GameStateController.Instance.InvokeWin(score);
        }
    }
}
