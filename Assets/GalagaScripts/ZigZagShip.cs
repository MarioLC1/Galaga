using UnityEngine;

public class ZigZagShip : MonoBehaviour
{
    public float speed = 3;
    public float sideSpeed = 2;
    public bool goingRight = true;

    public GameObject explosion;

    void Update()
    {
        transform.Translate(-transform.up * speed * Time.deltaTime);

        if (goingRight == true)
        {
            transform.Translate(transform.right * sideSpeed * Time.deltaTime);
        }

        if (goingRight == false)
        {
            transform.Translate(-transform.right * sideSpeed * Time.deltaTime);
        }

        if (transform.position.x > 7)
        {
            goingRight = false;
        }

        if (transform.position.x < -7)
        {
            goingRight = true;
        }

        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet") || collision.gameObject.CompareTag("GalagaPlayer"))
        {
            if (collision.gameObject.CompareTag("PlayerBullet"))
                Destroy(collision.gameObject);

            GameObject temp = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(temp, 1.0f);
            Destroy(gameObject);
        }
    }
}