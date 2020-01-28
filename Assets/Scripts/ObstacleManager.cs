using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    public GameObject effect;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ghost"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            other.GetComponent<GhostManager>().health -= damage;
            Debug.Log(other.GetComponent<GhostManager>().health);
            Destroy(gameObject);
        }
    }
}
