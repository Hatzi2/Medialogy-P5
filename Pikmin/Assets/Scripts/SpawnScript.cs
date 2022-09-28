using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour

{
    public GameObject pikminR;
    public GameObject pikminG;
    public GameObject pikminB;
    public GameObject pikminY;

    public int pikminCount;
    
    void Start()
    {
        for (int i = 0; i < pikminCount; i++){
            Vector3 randomPosition = new Vector3(Random.Range(-50, 50), 1, Random.Range(-50, 50));
            var randomRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
            Instantiate(pikminR, randomPosition, randomRotation);

            Vector3 randomPosition2 = new Vector3(Random.Range(-50, 50), 1, Random.Range(-50, 50));
            var randomRotation2 = Quaternion.Euler(0, Random.Range(0, 360), 0);
            Instantiate(pikminG, randomPosition2, randomRotation2);

            Vector3 randomPosition3 = new Vector3(Random.Range(-50, 50), 1, Random.Range(-50, 50));
            var randomRotation3 = Quaternion.Euler(0, Random.Range(0, 360), 0);
            Instantiate(pikminB, randomPosition3, randomRotation3);

            Vector3 randomPosition4 = new Vector3(Random.Range(-50, 50), 1, Random.Range(-50, 50));
            var randomRotation4 = Quaternion.Euler(0, Random.Range(0, 360), 0);
            Instantiate(pikminY, randomPosition4, randomRotation4);
        }
    }
}
