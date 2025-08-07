using System;
using System.Collections.Generic;
using Unity.Android.Gradle.Manifest;
using UnityEngine;
using Object = System.Object;

public class ServiceLocator : MonoBehaviour
{
    private Dictionary<Type, object> services = new Dictionary<Type, object>();

    public T GetService<T>() where T : class
    {
        if (services.TryGetValue(typeof(T), out object service))
        {
            return service as T;
        }
        return null;
    }

    public void RegisterService<T>(T service)
    {
       services[typeof(T)] = service; 
    }

    public void UnregisterService<T>(T service)
    {
        services.Remove(typeof(T));
    }
}