using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float speed = 2f;
    public float var1 = -5;
    public float var2 = 16;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(-transform.up * speed * Time.deltaTime);
        if(transform.position.y < var1)
            transform.position = new Vector3(transform.position.x, var2, transform.position.z);
    }
}
