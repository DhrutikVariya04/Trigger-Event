using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class TriggerEvent : MonoBehaviour
{
    [SerializeField]
    GameObject Box;

    private Vector3 startPosition;
    private float speed = 10f;

    private void Start()
    {
        startPosition = Box.transform.position;
    }
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

    public void OnDrag(BaseEventData Data)
    {
        PointerEventData eventData = Data as PointerEventData;

        Vector2 dragDelta = new Vector2(eventData.delta.x, 0) * Time.deltaTime;
        dragDelta.x += Mathf.Clamp(dragDelta.x, -455f, 455);
        Box.transform.position += (Vector3)dragDelta;

        print("dragDelta ====> "+ dragDelta.x);
    }

}
