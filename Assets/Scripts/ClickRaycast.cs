using UnityEngine;
using UnityEngine.Events;

public class ClickRaycast : MonoBehaviour
{
    [SerializeField]
 
    private float raycastDistance = 100f;
 
    [SerializeField]
    private LayerMask layerMask;
    [SerializeField]
 
    private string coinTag = "Coin";
    [SerializeField]
 
    private UnityEvent onConCollected;
    [SerializeField]
 
    private bool isActive = true;
 
    public void SetActive(bool active)
 
    {
        isActive = active;
    }
 
    void Update()
    {
        if (isActive && Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo, raycastDistance, layerMask))
            {
                if (hitInfo.collider.CompareTag(coinTag))
                {
                    PressCoin(hitInfo.collider.gameObject);
                }
            }
        }
    }
    private void PressCoin(GameObject coin)
    {
        onConCollected.Invoke();
        coin.GetComponent<Coin>().Collect();
    }
}
