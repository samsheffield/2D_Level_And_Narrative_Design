using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int points = 10;
    protected int pointModifier = 5;
    private int score;
    public Color overColor;

    private SpriteRenderer spriteRenderer;

    protected virtual void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        score = points * pointModifier;
    }

    protected virtual void Update()
    {
        Debug.Log("Score " + score);
    }

    private void OnMouseOver()
    {
        spriteRenderer.color = overColor;
    }
}
