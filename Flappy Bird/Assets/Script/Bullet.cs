using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	Rigidbody2D rb2d;
	
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
		Destroy(gameObject, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.AddForce(new Vector2(15, 18));
    }

	private void OnTriggerEnter2D(Collider2D collision)
    {
        //Memusnahkan object ketika bersentuhan
        Destroy(this.gameObject);
    }
	
	
}
