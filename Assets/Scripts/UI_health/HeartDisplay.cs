using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class HeartDisplay : MonoBehaviour
{
   
    [SerializeField] private Airplane _airplane;
    [SerializeField] private Image _heartImage;
    [SerializeField] private Transform _spawnPoint;

    private List<Image> _images = new List<Image>();

    private void Start(){

        Vector3 spawnPosition = _spawnPoint.position;

        for (int i = 0 ;i<_airplane.HealthValue;i++){
           var image =  Instantiate(_heartImage,spawnPosition,Quaternion.identity,transform);
           _images.Add(image);
            spawnPosition.x+=65;
        }

    }

     private void OnEnable() => _airplane.HealthChenged +=OnHealthChanged;
    private void OnDisable() =>_airplane.HealthChenged -=OnHealthChanged;
    private void OnHealthChanged(int healthValue){
        var deletedHeart = _images[^1];
        _images.Remove(deletedHeart);
        deletedHeart.gameObject.SetActive(false);
    }        
    
}
