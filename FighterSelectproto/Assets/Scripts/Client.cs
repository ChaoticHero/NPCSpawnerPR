using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Client : MonoBehaviour
    {
        public NPCSpawner m_SpawnerNPC;

        public void Update()
        {
                
        }

        void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 200, 20), "Click on the button to spawn in a character.");
            GUI.Label(new Rect(10, 30, 300, 20), "Try to find the secret info about the characters.");
        }
        public void timber()
        {
            m_SpawnerNPC.TimberFighter();
        }
        public void Fighter()
        {
            m_SpawnerNPC.Martialartist();
        }
        public void Shopowner()
        {
            m_SpawnerNPC.SpawnVillagers();
        }
        public void SoldierFighter()
        {
            m_SpawnerNPC.Soldier();
        }
    }
}
