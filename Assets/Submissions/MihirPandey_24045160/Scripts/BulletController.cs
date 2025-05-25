using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Rigidbody2D bulletRb;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float bulletLifetime;

    private void Start()
    {
        bulletRb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        bulletRb.MovePosition(transform.position + (transform.up * bulletSpeed * Time.deltaTime));
        bulletLifetime -= Time.deltaTime;
        if(bulletLifetime < 0) Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) Destroy(collision.gameObject);
        Destroy(this.gameObject);
    }
}
