using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public GameObject tankPrefab;
    // Start is called before the first frame update
    void Start()
    {
        SpawnTank();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnTank()
    {
        Instantiate(tankPrefab, gameObject.transform.position, Quaternion.identity);
    }
}
