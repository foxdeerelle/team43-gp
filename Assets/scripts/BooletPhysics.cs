using UnityEngine;

public class BooletPhysics : MonoBehaviour
{
    
    // yet again bullet stuff (mostly) from a tutorial from unitycodemonkey !! : https://unitycodemonkey.com/text.php?v=Nke5JKPiQTw
    private Rigidbody2D rbBullet;
    public Rigidbody2D rbHittable;
    
    public void Setup()
    {
        rbBullet = GetComponent<Rigidbody2D>();
        //rbBullet.AddForce(direction * force, ForceMode2D.Impulse);
        Destroy(gameObject, 5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Rigidbody2D rbHittable))
        {
            // handling for creating force to launch player goes here !
        }
    }

}
