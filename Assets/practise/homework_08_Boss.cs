using UnityEngine;

namespace OLIVER
{
    public struct homework_08_Boss
    {
        private string bossName;
        private string uniqueSkill;
        private int bossHp;

        public homework_08_Boss(string _name, string _skill, int _hp)
        {
            bossName = _name;
            uniqueSkill = _skill;
            bossHp = _hp;
        }

        public void Talk()
        {
            Debug.Log($"<color=#ff0>!!!{bossName}出現了，血量 :{bossHp} ，絕招是 :{uniqueSkill}!!!!</color>");
        }

    }

}

