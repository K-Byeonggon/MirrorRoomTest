using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
public class MyNetworkRoomManager : NetworkRoomManager
{
    public override void OnServerChangeScene(string newSceneName)
    {
        base.OnServerChangeScene(newSceneName);
        Debug.Log("NetworkRoomManager: OnServerChangeScene " + newSceneName);
    }

    public override void OnRoomStartServer()
    {
        base.OnRoomStartServer();
        Debug.Log("NetworkRoomManager: OnRoomStartServer");
    }

    public override void OnStartServer()
    {
        base.OnStartServer();
        Debug.Log("NetworkRoomManager: OnStartServer");
    }

    public override void OnRoomStartHost()
    {
        base.OnRoomStartHost();
        Debug.Log("NetworkRoomManager: OnRoomStartHost");
    }

    public override void OnStartHost()
    {
        base.OnStartHost();
        Debug.Log("NetworkRoomManager: OnStartHost");
    }

    public override void OnRoomServerConnect(NetworkConnectionToClient conn)
    {
        base.OnRoomServerConnect(conn);
        if (conn.identity != null)
        {
            Debug.Log("NetworkRoomManager: OnRoomServerConnect netId " + conn.identity.netId);
        }
        else
        {
            Debug.Log("NetworkRoomManager: OnRoomServerConnect conn.identity == null");
        }
    }

    public override void OnServerConnect(NetworkConnectionToClient conn)
    {
        base.OnServerConnect(conn);
        if (conn.identity != null)
        {
            Debug.Log("NetworkRoomManager: OnServerConnect netId " + conn.identity.netId);
        }
        else
        {
            Debug.Log("NetworkRoomManager: OnServerConnect conn.netId == null");
        }
    }

    public override void OnRoomStartClient()
    {
        base.OnRoomStartClient();
        Debug.Log("NetworkRoomManager: OnRoomStartClient");
    }

    public override void OnStartClient()
    {
        base.OnStartClient();
        Debug.Log("NetworkRoomManager: OnStartClient");
    }

    public override void OnRoomServerSceneChanged(string sceneName)
    {
        base.OnRoomServerSceneChanged(sceneName);
        Debug.Log("NetworkRoomManager: OnRoomServerSceneChanged " + sceneName);
    }

    public override void OnServerSceneChanged(string sceneName)
    {
        base.OnServerSceneChanged(sceneName);
        Debug.Log("NetworkRoomManager: OnServerSceneChanged " + sceneName);
    }

    public override void OnRoomClientConnect()
    {
        base.OnRoomClientConnect();
        Debug.Log("NetworkRoomManager: OnRoomClientConnect");
    }

    public override void OnClientConnect()
    {
        base.OnClientConnect();
        Debug.Log("NetworkRoomManager: OnClientConnect");
    }

    public override void OnServerReady(NetworkConnectionToClient conn)
    {
        base.OnServerReady(conn);
        if (conn.identity != null)
        {
            Debug.Log("NetworkRoomManager: OnServerReady netId " + conn.identity.netId);
        }
        else
        {
            Debug.Log("NetworkRoomManager: OnServerReady conn.identity == null");
        }
    }

    /*
     NetworkRoomPlayer: OnStartServer
     */

    public override void OnServerAddPlayer(NetworkConnectionToClient conn)
    {
        base.OnServerAddPlayer(conn);
        Debug.Log("NetworkRoomManager: OnServerAddPlayer netId " + conn.identity.netId);
    }

    /*
     NetworkRoomPlayer: OnStartClient
     NetworkRoomPlayer: OnStartLocalPlayer
     */

    public override void OnRoomClientEnter()
    {
        base.OnRoomClientEnter();
        Debug.Log("NetworkRoomManager: OnRoomClientEnter");
    }

    /*
     NetworkRoomPlayer: OnClientEnterRoom
     */

    //======================================= Host Stop Client ==========================================

    public override void OnServerDisconnect(NetworkConnectionToClient conn)
    {
        Debug.Log("NetworkRoomManager: OnServerDisconnect netId " + conn.identity.netId);
        base.OnServerDisconnect(conn);
    }

    public override void OnRoomServerDisconnect(NetworkConnectionToClient conn)
    {
        base.OnRoomServerDisconnect(conn);
        if (conn.identity != null)
        {
            Debug.Log("NetworkRoomManager: OnRoomServerDisconnect netId " + conn.identity.netId);
        }
        else
        {
            Debug.Log("NetworkRoomManager: OnRoomServerDisconnect conn.identity == null");
        }
    }

    /*
    NetworkRoomPlayer: OnStopLocalPlayer
    NetworkRoomPlayer: OnStopClient
    NetworkRoomPlayer: OnStopServer
     */

    public override void OnRoomClientExit()
    {
        base.OnRoomClientExit();
        Debug.Log("NetworkRoomManager: OnRoomClientExit");
    }

    public override void OnRoomClientDisconnect()
    {
        base.OnRoomClientDisconnect();
        Debug.Log("NetworkRoomManager: OnRoomClientDisconnect");
    }

    public override void OnClientDisconnect()
    {
        base.OnClientDisconnect();
        Debug.Log("NetworkRoomManager: OnClientDisconnect");
    }

    public override void OnRoomStopClient()
    {
        base.OnRoomStopClient();
        Debug.Log("NetworkRoomManager: OnRoomStopClient");
    }

    /*
    OnRoomClientExit (왠지 모르지만 한번 더 불림)
     */


    //========================= 클라 입장시 ====================================

    /*
    OnRoomStartClient
    OnStartClient
    OnRoomClientConnect
    OnClientConnect
    OnClientEnter
     */

    public override void OnRoomClientSceneChanged()
    {
        base.OnRoomClientSceneChanged();
        Debug.Log("NetworkRoomManager: OnRoomClientSceneChanged");
    }

    public override void OnClientSceneChanged()
    {
        base.OnClientSceneChanged();
        Debug.Log("NetworkRoomManager: OnClientSceneChanged");
    }

    /*
    NetworkRoomPlayer: OnStartClient
    NetworkRoomPlayer: OnStartLocalPlayer
    OnRoomClientEnter
    NetworkRoomPlayer: OnClientEnterRoom
     */


    //============================== 클라 Stop Client =====================================

    /*
    OnRoomClientDisconnect
    OnClientDisconnect
    OnRoomStopClient
    OnRoomClientExit
    RoomPlayer: OnClientExitRoom
    RoomPlayer: OnStopLocalPlayer
    RoomPlayer: OnStopClient
     */



    //==================================== 언제 쓰이는지 모르는 것들 ===========================================

    public override void OnClientNotReady()
    {
        base.OnClientNotReady();
        Debug.Log("NetworkRoomManager: OnClientNotReady");
    }

    public override void OnRoomServerAddPlayer(NetworkConnectionToClient conn)
    {
        base.OnRoomServerAddPlayer(conn);
        Debug.Log("NetworkRoomManager: OnRoomServerAddPlayer netId " + conn.identity.netId);
    }

    public override void OnRoomServerPlayersNotReady()
    {
        base.OnRoomServerPlayersNotReady();
        Debug.Log("NetworkRoomManager: OnRoomServerPlayersNotReady");
    }

    public override void OnRoomServerPlayersReady()
    {
        base.OnRoomServerPlayersReady();
        Debug.Log("NetworkRoomManager: OnRoomServerPlayersReady");
    }

    public override void OnRoomStopHost()
    {
        base.OnRoomStopHost();
        Debug.Log("NetworkRoomManager: OnRoomStopHost");
    }

    public override void OnRoomStopServer()
    {
        base.OnRoomStopServer();
        Debug.Log("NetworkRoomManager: OnRoomStopServer");
    }

}
