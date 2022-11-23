using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    public GameObject map;
    public float destroyTime;
    public AudioSource engine;

    void Start()
    {
        engine.Play();
        Invoke("destroyer", destroyTime);
    }
    void destroyer()
    {
        Destroy(map);
    }
}
