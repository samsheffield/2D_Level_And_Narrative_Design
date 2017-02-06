using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSortOrder : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    public bool canMove;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Sort();
    }

    void LateUpdate()
    {
        if (canMove)
        {
            Sort();
        }
    }

    private void Sort()
    {
        spriteRenderer.sortingOrder = -(int)(transform.position.y * 100);
    }

}
