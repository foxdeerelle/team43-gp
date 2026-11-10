using System;
using UnityEditor.UI;
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
using Object = UnityEngine.Object;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] private Rigidbody2D rb;
    
    // weapon aiming comes from a tutorial here, big props: https://unitycodemonkey.com/text.php?v=fuGQFdhSPg4
    [SerializeField] private Transform aimTransform;
    [SerializeField] private float force;
    
    bool grounded;

    private void FixedUpdate()
    {
        Vector3 mousePosition = GetMouseWorldPosition();
        Vector3 aimDirection = (mousePosition - aimTransform.position).normalized;
        float angle =  Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        aimTransform.eulerAngles = new Vector3(0, 0, angle);

        if (Input.GetMouseButtonDown(0) && grounded)
        {
            rb.AddForce(-new Vector2(aimDirection.x, aimDirection.y) * force, ForceMode2D.Impulse);
            print("shot: aimX = " + -aimDirection.x + ", aimY = " + -aimDirection.y);
        }

    }
    
    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseScreenPosition = Input.mousePosition;
        mouseScreenPosition.z = 10f;
        return Camera.main.ScreenToWorldPoint(mouseScreenPosition);
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("platform"))
        {
            grounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
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

        if (collision.gameObject.tag == ("platform"))
        {
            grounded = false;
        }
    }
    
}

