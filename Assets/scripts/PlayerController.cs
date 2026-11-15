using System;
using UnityEditor.UI;
using UnityEngine;
using Object = UnityEngine.Object;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] private Rigidbody2D rb;
    
    // weapon aiming comes from a tutorial here, big props: https://unitycodemonkey.com/text.php?v=fuGQFdhSPg4
    [SerializeField] private Transform aimTransform;
    [SerializeField] private float force;
    
    bool grounded = true;

    private void FixedUpdate()
    {
        Vector3 mousePosition = GetMouseWorldPosition();
        Vector3 aimDirection = (mousePosition - aimTransform.position).normalized;
        float angle =  Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        aimTransform.eulerAngles = new Vector3(0, 0, angle);

        if (Input.GetMouseButtonDown(0) && grounded)
        {
            rb.linearVelocity = Vector2.zero;
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
        if (collision.gameObject.CompareTag("platform") || rb.transform.position.x < 1)
        {
            grounded = true;
        }
        print("grounded: " + grounded);
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("platform"))
        {
            grounded = false;
        }
        print("grounded: " + grounded);
    }
    
}

