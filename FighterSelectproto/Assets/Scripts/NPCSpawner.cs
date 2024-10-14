using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class NPCSpawner : MonoBehaviour
    {
        public NPCFactory m_Factory;

        private INPC m_Farmer;
        private INPC m_Beggar;
        private INPC m_Shopowner;
        private INPC m_Soldier;
        private INPC m_Champion;
        public void SpawnVillagers()
        {
            
            
            m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);


           
            m_Shopowner.Speak();
        }
        public void TimberFighter()
        {
            m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
            m_Farmer.Speak();
        }
        public void Martialartist()
        {
            m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
            m_Beggar.Speak();
        }
        public void Soldier()
        {
            m_Soldier = m_Factory.GetNPC(NPCType.Soldier);
            m_Soldier.Speak();
        }
        public void GrandChampion()
        {
            m_Champion = m_Factory.GetNPC(NPCType.Champion);
            m_Champion.Speak();
        }
    }
}
