using Unity.Mathematics;
using UnityEngine;

public class BulletShip : MonoBehaviour
{
    public float speed = 3;
    public GameObject bullet;
    public GameObject explosion;

    public float bulletTimer = 0, bulletWait = 3;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-transform.up * speed * Time.deltaTime);

        bulletTimer += Time.deltaTime;
        if(bulletTimer > bulletWait)
        {
            bulletTimer = 0;
            Instantiate(bullet, transform.position - new Vector3(0, .5f, 0), Quaternion.identity);
        }
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if(collision.gameObject.CompareTag("PlayerBullet") || collision.gameObject.CompareTag("GalagaPlayer"))
        {
            if (collision.gameObject.CompareTag("PlayerBullet"))
                Destroy(collision.gameObject);
    
            GameObject temp = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(temp, 1.0f);
            Destroy(gameObject);
        }
    }
}