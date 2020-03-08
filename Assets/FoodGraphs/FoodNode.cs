using UnityEngine;
using System.Collections.Generic;

namespace XNode.FoodNodes
{
    public class FoodNode : XNode.Node
    {
        [Output] public List<FoodStateNode> NextState;

        public string FoodName;
        public Sprite FoodSprite;
    }
}