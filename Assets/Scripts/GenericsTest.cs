using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assigment20
{
    public class GenericsTest : MonoBehaviour
    {

        void Start()
        {
            GameContainer<string> gameContainer = new GameContainer<string>("Healing Potion");
            Debug.Log(gameContainer.GetItem());
            Debug.Log(GameUtils.DescribeItem(gameContainer.GetItem()));

        }


    }
}
