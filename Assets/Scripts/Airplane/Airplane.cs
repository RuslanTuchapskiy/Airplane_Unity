using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Airplane : MonoBehaviour
{
    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private int _healthValue;

    private int _scoreValue;
    public int  HealthValue =>_healthValue;

    public event UnityAction <int> HealthChenged;

    private void Start()=> _healthText.text = _healthValue.ToString();
private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Coin coin))
        {
            Destroy(coin.gameObject);
            _scoreValue++;
            _scoreText.text =_scoreValue.ToString();
        }
            
        else if (other.TryGetComponent(out Bomb bomb))
        {
            _healthValue--;
            _healthText.text = _healthValue.ToString();
            HealthChenged?.Invoke(_healthValue);
            Destroy(other.gameObject);
        }
           
    }
 
}
