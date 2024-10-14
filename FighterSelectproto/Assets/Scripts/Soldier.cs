using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Soldier : INPC
    {
        public void Speak()
        {
            Debug.Log("Rise and Shine soldier! Ready for the next round!");
        }
    }
}
