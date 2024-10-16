using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TriggerEvent : MonoBehaviour
{
    [SerializeField]
    GameObject Box;

    float speed = 10f;

    public void Right()
    {
        var Pos = Box.transform.position;
        Pos.x += (Time.deltaTime * speed);
        Box.transform.position = Pos;   
    }

    public void Left()
    {
        var Pos = Box.transform.position;
        Pos.x -= (Time.deltaTime * speed);
        Box.transform.position = Pos;
    }

    public void Up()
    {
        var Pos = Box.transform.position;
        Pos.y += (Time.deltaTime * speed);
        Box.transform.position = Pos;
    }

    public void Bottom()
    {
        var Pos = Box.transform.position;
        Pos.y -= (Time.deltaTime * speed);
        Box.transform.position = Pos;
    }

    public void LeftDrag()
    {
        var Pos = Box.transform.position;
        Pos.x -= (Time.deltaTime * speed);
        Box.transform.position = Pos;
    }

    public void RightDrag()
    {
        var Pos = Box.transform.position;
        Pos.x += (Time.deltaTime * speed);
        Box.transform.position = Pos;
    }

    public void Check(PointerEventData Data)
    {
        // Access the drag delta
        Vector2 dragDelta = Data.delta;

        // Check if the drag is left or right
        if (dragDelta.x > 0)
        {
            Debug.Log("Dragging Right: " + dragDelta.x);
        }
        else if (dragDelta.x < 0)
        {
            Debug.Log("Dragging Left: " + dragDelta.x);
        }
    }

}
