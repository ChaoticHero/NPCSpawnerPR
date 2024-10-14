using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Champion : INPC
    {
        public void Speak()
        {
            Debug.Log("Here he is folks, the moment you all been waiting for, It is the GRAND CHAMPION!!!!");
        }
    }
}
