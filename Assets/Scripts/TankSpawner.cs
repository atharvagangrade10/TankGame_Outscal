using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankView;
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
        TankModel tankModel = new TankModel();
        TankController controller = new TankController(tankModel, tankView);
    }
}
