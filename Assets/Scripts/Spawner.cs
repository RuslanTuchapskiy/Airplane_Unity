using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Bomb _bombTemplate;
    [SerializeField] private Coin _coinTemplate;
    [SerializeField] private Heart _heartTemplate;
    [SerializeField] private int _objectsCount;


    private void Start() {

        for(int i =0;i<_objectsCount;i++){
            Vector3 randomSpawnVector = new Vector3(Random.Range(-100,100),Random.Range(-100,100),Random.Range(-100,100));
            var rand = Random.Range(0,3);

            if(rand==0)
                  Instantiate(_coinTemplate,randomSpawnVector,Quaternion.identity,transform);
            else if (rand==1)
                 Instantiate(_bombTemplate,randomSpawnVector,Quaternion.identity,transform);
            else  
                Instantiate(_heartTemplate,randomSpawnVector,Quaternion.identity,transform);
           

        }
        
    }
}
