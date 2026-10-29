using UnityEngine;

public class GalagaMovement : MonoBehaviour
{
    public float speed = 5;

    public GameObject bullet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-transform.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(transform.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-transform.up * speed * Time.deltaTime);
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(bullet, transform.position + new Vector3(0,.5f,0), Quaternion.identity);
        }

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7, 7), Mathf.Clamp(transform.position.y, -4, 4), 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {

        }
    }
}
