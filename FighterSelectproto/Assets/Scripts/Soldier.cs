using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Soldier : INPC
    {
        string name;
        public void Speak()
        {
            Debug.Log("Rise and Shine soldier! Ready for the next round!");
        }
    }
}
