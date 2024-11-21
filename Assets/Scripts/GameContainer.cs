using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
namespace Assigment20
{

    public class GameContainer<T>
    {
        T item;
        public GameContainer(T item)
        {
            this.item = item;
        }
        public void SetItem(T item)
        {
            this.item = item;
        }
        public T GetItem()
        {
            return item;
        }

    }
}

