using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRenderHelper : MonoBehaviour
{
    public LineRenderer LineRenderer;
    public Transform LineLocalPoint;
    public Transform PlayerAnchor;
    public bool Enabled;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Enabled)
        {

            LineRenderer.enabled = Enabled;
            LineRenderer.useWorldSpace = true;
            LineRenderer.SetPosition(0, PlayerAnchor.position);
            LineRenderer.SetPosition(1, LineLocalPoint.position);

        }
    }
}
