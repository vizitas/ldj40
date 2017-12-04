using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TresureController : MonoBehaviour
{
    public Transform PlayerAnchor;
    public Rigidbody2D PlayerBody;
    public bool connected = false;
    public LineRenderHelper line;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!connected && collision.gameObject.tag == "Player")
        {
            DistanceJoint2D join = gameObject.GetComponent<DistanceJoint2D>();
            join.connectedAnchor = PlayerAnchor.localPosition;
            join.connectedBody = PlayerBody; //.rigidbody2D = PlayerBody;
            line.Enabled = true;
            connected = true;
        }
    }
}
