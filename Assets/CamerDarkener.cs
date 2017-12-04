using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerDarkener : MonoBehaviour
{
    public Camera mainCamera;
    public Transform MaxDepth;
    public Transform PlayerDepth;
    public Color minColor;
    public Color maxColor;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mainCamera.backgroundColor = Color.Lerp(minColor, maxColor, PlayerDepth.position.y / MaxDepth.position.y);
    }
}
