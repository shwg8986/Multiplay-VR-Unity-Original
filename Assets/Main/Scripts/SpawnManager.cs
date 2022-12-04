using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.XR.Interaction.Toolkit;

public class SpawnManager : MonoBehaviour
//public class SpawnManager : MonoBehaviourPunCallbacks
{

    [SerializeField]
    GameObject GenericVRPlayerPrefab;

    //public GameObject LocalXROriginGameobject; //追加


    public Vector3 spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        if (PhotonNetwork.IsConnectedAndReady)
        {
            PhotonNetwork.Instantiate(GenericVRPlayerPrefab.name, spawnPosition, Quaternion.identity);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (photonView.IsMine)
        //{
        //    LocalXROriginGameobject.transform.parent = GenericVRPlayerPrefab.transform;

        //    TeleportationArea[] teleportationAreas = GameObject.FindObjectsOfType<TeleportationArea>();
        //    if (teleportationAreas.Length > 0)
        //    {
        //        Debug.Log("Found " + teleportationAreas.Length + "teleporttation area. ");
        //        foreach (var item in teleportationAreas)
        //        {
        //            item.teleportationProvider = LocalXROriginGameobject.GetComponent<TeleportationProvider>();
        //        }
        //    }
        //}
    }
}
