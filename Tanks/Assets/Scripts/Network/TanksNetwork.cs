using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using Unity.Collections;
using UnityEngine.UI;

public class TanksNetwork : NetworkBehaviour
{
    [SerializeField] private Transform spawnedObjectPrefab;
    private Transform spawnedObjectTransform;
    private void Update()
    {
        if (!IsOwner) return;

        //if (Input.GetKeyUp(KeyCode.T))
        //{
        //    spawnedObjectTransform = Instantiate(spawnedObjectPrefab);
        //    spawnedObjectTransform.GetComponent<NetworkObject>().Spawn(true);
        //}
        //if (Input.GetKeyUp(KeyCode.Y))
        //{
        //    Destroy(spawnedObjectTransform.gameObject);
        //}
    }
}
