using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRb;
    [SerializeField] private float playerSpeed;
    [SerializeField] private GameObject bullet;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Translate();
    }

    private void Update()
    {
        Rotate();
        if (Input.GetMouseButtonDown(0)) Shoot();
    }

    private void Translate()
    {
        Vector2 currPos = new Vector2(transform.position.x, transform.position.y);
        Vector2 move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        playerRb.MovePosition(currPos + (move * playerSpeed * Time.fixedDeltaTime));
    }

    private void Rotate()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mousePos);

        float dy = mouseWorldPos.y - transform.position.y;
        float dx = mouseWorldPos.x - transform.position.x;

        float angleInDeg = Mathf.Atan2(dy, dx) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angleInDeg - 90.0f);
        // subtracting by 90 just to compensate for original gun orientation wrt player
    }

    private void Shoot()
    {
        Object.Instantiate(bullet, transform.position + transform.up, transform.rotation);
        // using transform.up to offset bullet by 1 unit as gun tip is 1 unit away from player position
    }
}
