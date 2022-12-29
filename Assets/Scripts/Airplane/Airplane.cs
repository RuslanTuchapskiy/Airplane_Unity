using UnityEngine;

public class Airplane : MonoBehaviour
{
private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Coin coin))
            Destroy(coin.gameObject);
        else if (other.TryGetComponent(out Bomb bomb))
            Destroy(other.gameObject);
    }
 
}
