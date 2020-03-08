using UnityEngine;
using System.Collections.Generic;

namespace XNode.FoodNodes
{
    public class FoodStateNode : XNode.Node
    {
        [Output] public List<FoodStateNode> NextState;
        [Input] public FoodStateNode PrevStates;        

        public string StateName;
        public Sprite StateSprite;
    }
}