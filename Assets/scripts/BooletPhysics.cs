using System;
using UnityEngine;
using Object = System.Object;

public class BooletPhysics : MonoBehaviour
{
    
    // yet again bullet stuff (mostly) from a tutorial from unitycodemonkey !! : https://unitycodemonkey.com/text.php?v=Nke5JKPiQTw
    private Rigidbody2D rbBullet;
    public Rigidbody2D rbHittable;
    [SerializeField] private Rigidbody2D gun;
    
    [SerializeField] private float force;
    PlayerController PlayerController;
    
    public void Setup()
    {
        rbBullet = GetComponent<Rigidbody2D>();
        //rbBullet.AddForce(direction * force, ForceMode2D.Impulse);
        Destroy(gameObject, 5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        float xComp = Mathf.Cos(gun.transform.eulerAngles.z * Mathf.PI / 180f) * force;
        float yComp = Mathf.Sin(gun.transform.eulerAngles.z * Mathf.PI / 180f) * force;

        PlayerController.KapowThatBinch(xComp, yComp);
        
        if (collision.TryGetComponent(out Rigidbody2D rbHittable))
        {
        }
    }

}
