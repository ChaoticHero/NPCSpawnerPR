using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Farmer : INPC
    {
        string name;
        public void Speak()
        {
            Debug.Log("You reap what you sow!");
        }
    }
}
