using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Obstacle : MonoBehaviour
{
    public Parallax.Layer layer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Parallax.GetSpeed(layer) * Time.deltaTime);
        if (transform.position.x <= -11.5)
        {
            gameObject.SetActive(false);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Health.TrydamageTarget(other.gameObject, 1);
    }
}
