using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyNetworkRoomPlayer : NetworkRoomPlayer
{
    public override void OnStartServer()
    {
        base.OnStartServer();
        Debug.Log("NetworkRoomPlayer: OnStartServer");
    }

    public override void OnClientEnterRoom()
    {
        base.OnClientEnterRoom();
        Debug.Log("NetworkRoomPlayer: OnClientEnterRoom");
    }

    public override void OnClientExitRoom()
    {
        base.OnClientExitRoom();
        Debug.Log("NetworkRoomPlayer: OnClientExitRoom");
    }

    public override void OnStartClient()
    {
        base.OnStartClient();
        Debug.Log("NetworkRoomPlayer: OnStartClient");
    }

    public override void OnStartLocalPlayer()
    {
        base.OnStartLocalPlayer();
        Debug.Log("NetworkRoomPlayer: OnStartLocalPlayer");
    }

    public override void OnStopClient()
    {
        base.OnStopClient();
        Debug.Log("NetworkRoomPlayer: OnStopClient");
    }

    public override void OnStopLocalPlayer()
    {
        base.OnStopLocalPlayer();
        Debug.Log("NetworkRoomPlayer: OnStopLocalPlayer");
    }

    public override void OnStopServer()
    {
        base.OnStopServer();
        Debug.Log("NetworkRoomPlayer: OnStopServer");
    }

    public override void OnGUI()
    {
        base.OnGUI();
        //Debug.Log("NetworkRoomPlayer: OnGUI");
    }
}
