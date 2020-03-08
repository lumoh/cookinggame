using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FoodState
{
    public string StateName;
    public Sprite StateSprite;
    public List<FoodState> StateTree;
}
