using UnityEngine;
using UnityEngine.EventSystems;

public class TriggerEvent : MonoBehaviour
{
    [SerializeField]
    GameObject Box;

    PointerEventData eventData;
    private Vector3 startPosition;
    private Vector2 initialPosition;
    private float speed = 100f;
    private bool isDragging;

    private void Start()
    {
         startPosition = Box.transform.position;
    }

    void Update()
    {
        if (isDragging)
        {
            Vector2 currentPosition = eventData.position;
            Vector2 delta = currentPosition - initialPosition;

            float maxDelta = Screen.height * 0.2f;
            delta = Vector2.ClampMagnitude(delta, maxDelta);

            Vector2 newPosition = ((Vector2)Box.transform.position + delta.normalized) * speed * Time.deltaTime;

            newPosition.y = startPosition.y;

            Box.transform.position = newPosition;

        }
    }

    //For Drag Box :--

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
        Box.transform.position += (Vector3)dragDelta;

        print("dragDelta ====> "+ dragDelta.x);
    }

    // For Drag Box :--

    public void OnPointerDown(BaseEventData eventData)
    {
        PointerEventData EventData = eventData as PointerEventData;

        this.eventData = EventData;
        isDragging = true;
        initialPosition = EventData.position;
    }

    public void OnPointerUp(BaseEventData eventData)
    {
        PointerEventData EventData = eventData as PointerEventData;
        isDragging = false;
    }
}
