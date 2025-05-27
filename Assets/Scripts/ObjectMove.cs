using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public float moveSpeed;
    public float moveRange;

    public  float oldPosition;
    // Start is called before the first frame update
    void Start()
    {
        oldPosition = 6;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1 * Time.deltaTime*moveSpeed , 0, 0));

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject .tag.Equals ("ResetWall"))
        {
            transform.position = new Vector3(oldPosition, Random.Range(-2, 2), 0);
        }
            
    }
}
