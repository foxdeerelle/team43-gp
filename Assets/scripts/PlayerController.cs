using UnityEngine;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{

    public float movespeed = 20f;
    public float jumpforce = 20f;


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
