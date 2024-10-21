using UnityEngine;
using UnityEngine.EventSystems;

public class CannonDragHandler : MonoBehaviour, IEndDragHandler
{
    private Vector3 startPosition;
    private float moveSpeed = 2.0f;

    public void OnBeginDrag(BaseEventData EventData)
    {
        PointerEventData eventData = EventData as PointerEventData;
        startPosition = transform.position;
    }

    public void OnDrag(BaseEventData EventData)
    {
        PointerEventData eventData = EventData as PointerEventData;
        Vector3 newPosition = transform.position + new Vector3(eventData.delta.x, 0, 0) * moveSpeed * Time.deltaTime;
        transform.position = newPosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // Optional: Add logic for when the drag ends
    }
}
