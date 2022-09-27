using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMono<T> : MonoBehaviour where T: SingletonMono<T>
{
    private static T instance;

    public static T Instance { get => instance; }

    protected virtual void Awake()
    {
        if (instance != null) Destroy(gameObject);
        else instance = (T)this;
        DontDestroyOnLoad(this);
    }
    
}
