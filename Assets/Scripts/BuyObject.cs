using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class BuyObject : MonoBehaviour
{

    [SerializeField]

    private int cost;
    [SerializeField]

    private InstantiatePoolObjects objectPool;
    [SerializeField]

    private CoinsManager coinsManager;
    [SerializeField]

    private Text costText;
    [SerializeField]

    private UnityEvent<Transform> onObjectBought;

    private void Start()
    {
        if (coinsManager.CanBuy(cost))
        {
            costText.text = cost.ToString();
        }
    }

    public void TryBuyObject()
    {
        if (coinsManager.CanBuy(cost))
        {
            objectPool.InstantiateObject(transform);
            GameObject boughtObject = objectPool.GetCurrentObject();
            onObjectBought?.Invoke(boughtObject.transform);


        }
    }



}
