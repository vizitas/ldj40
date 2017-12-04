using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepthSound : MonoBehaviour
{
    public Transform PlayerDepth;
    public Transform MaxDepth;
    AudioSource audioSource;
    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        audioSource.volume = PlayerDepth.position.y / MaxDepth.position.y;
    }
}
