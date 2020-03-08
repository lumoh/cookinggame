using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitchen : MonoBehaviour
{
    public static Kitchen instance;
    public KitchenGraph graph;

    public void Awake()
    {
        instance = this;
    }
}
