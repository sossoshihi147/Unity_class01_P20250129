using UnityEngine;

namespace OLIVER
{
    /// <summary>
    /// NPC ���O : NPC �W�ٻP��ܤ��e��ơA����X NPC �W�ٻP���ܪ��\��
    /// </summary>
    public class Class_08_1_NPC
    {
        private string name;
        private string dialogue;

        // �غc�l : �S���Ǧ^���O�A�W�ٻP���O�ۦP�����}��k
        // �w�]�غc�l : �S���Ѽ�
        public Class_08_1_NPC()
        {
            Debug.Log("<color=#f3d>�L�Ѽƪ���ܤ��e:�w�]�غc�l</color>");
        }
        // �غc�l��²�g
        public Class_08_1_NPC(string _name) => name = _name;

        public Class_08_1_NPC(string _name, string _dialogue)
        {
            name = _name;
            dialogue = _dialogue;
            Debug.Log("<color=#f3d>���Ѽƪ��غc�l</color>");
        }

        public void LogName()
        {
            Debug.Log($"<color=#3f0>NPC ���W�� : {name}</color>");
        }
        public void Talk()
        {
            Debug.Log($"<color=#3f0>{dialogue}</color>");
        }
    }
}