using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public Texture2D idleCursor, activeCursor;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    private void Start()
    {
        Cursor.SetCursor(idleCursor, hotSpot, cursorMode);
    }
    private void Update()
    {
        if (Input.GetMouseButton (0))
        {
            Cursor.SetCursor(activeCursor, hotSpot, cursorMode);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Cursor.SetCursor(idleCursor, hotSpot, cursorMode);
        }
    }
}
