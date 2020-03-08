using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewFood", menuName = "Cooking/Create Food", order = 1)]
public class Food : ScriptableObject
{
    public string Name;
    public FoodGraph StateGraph;
    public FoodLocation Location;
}
