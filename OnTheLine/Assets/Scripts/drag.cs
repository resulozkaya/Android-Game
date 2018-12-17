using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour {
    float distance = 5;
    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToViewportPoint(mousePosition);
        transform.position = objPosition;
    }
}
