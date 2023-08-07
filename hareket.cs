using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour {
    Vector3 objectpos;
    private void OnMouseDown()
    {
        objectpos = Camera.main.WorldToScreenPoint(transform.position);
    }
    private void OnMouseDrag()
    {
        Vector3 pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, objectpos.z);
        transform.position = Camera.main.ScreenToWorldPoint(pos);
    }
}
