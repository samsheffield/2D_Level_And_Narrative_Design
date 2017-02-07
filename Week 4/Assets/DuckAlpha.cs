using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckAlpha : MonoBehaviour {
    private Transform player;
    private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if(player.position.y > transform.position.y)
        {
            spriteRenderer.color = new Color(1, 1, 1, .25f);
        }
        else
        {
            spriteRenderer.color = Color.white;
        }
	}


}
