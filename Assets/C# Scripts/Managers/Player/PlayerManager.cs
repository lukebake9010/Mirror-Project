using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : NetworkBehaviour
{



    //Various Managers
    [SerializeField]
    private CommandManager commandManager;

    private void Awake()
    {
        Initialise();
    }

    private void Initialise()
    {
        if (commandManager == null) InitialiseManager(commandManager);
    }

    private  void InitialiseManager<T>(T manager)  where T : new()
    {
        if (TryGetComponent<T>(out T component))
        {
            manager = component;
        }
        else
        {
            manager = new T();
        }
    }

}
