using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float movespeed = 5f;
    public float jumpforce = 10f;

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        HandleMovements();
        Jump();


    }

    private void HandleMovements()
    {
        float moveinput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(moveinput * movespeed, rb.linearVelocity.y);
    }

    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))

            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpforce);

    }
 
}
