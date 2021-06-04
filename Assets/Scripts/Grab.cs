using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Grab : MonoBehaviour
{
    public Transform touchPoint;
    public bool hasMoved = false;
    public TMP_Text movedItemsTxt;
    public int movedItems = 0;

    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = touchPoint.position;
        this.transform.parent = GameObject.Find("TouchPoint").transform;
        this.hasMoved = true;
        movedItems++;
        movedItemsTxt.text = $"Disturbed Items: {movedItems}";
    }

    private void OnMouseUp()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        this.hasMoved = false;
    }
}
