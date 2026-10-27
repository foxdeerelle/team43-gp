using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    // weapon aiming comes from a tutorial here, big props: https://unitycodemonkey.com/text.php?v=fuGQFdhSPg4
    [SerializeField] private Transform aimTransform;

    void Update()
    {

        Vector3 mousePosition = GetMouseWorldPosition();
        Vector3 aimDirection = (mousePosition - aimTransform.position).normalized;
        
        float angle =  Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        
        aimTransform.eulerAngles = new Vector3(0, 0, angle);

    }
    
    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mouseScreenPosition = Input.mousePosition;
        mouseScreenPosition.z = 10f;
        return Camera.main.ScreenToWorldPoint(mouseScreenPosition);
    }
}

