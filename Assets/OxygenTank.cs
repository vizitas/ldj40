using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenTank : MonoBehaviour
{
    bool used = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!used && collision.gameObject.tag == "Player")
        {
            used = true;
            var playerOxygenController = collision.gameObject.GetComponentInChildren<OxygenController>();
            playerOxygenController.Ammount = playerOxygenController.StartingAmmount;
            var audioSource = GetComponent<AudioSource>();
            audioSource.Play();
            Destroy(gameObject, 4);
        }
    }
}
