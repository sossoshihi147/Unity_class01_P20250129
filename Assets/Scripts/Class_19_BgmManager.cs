using OLIVER.Class_15;
using UnityEngine;

namespace OLIVER.Class_19.Event
{
    /// <summary>
    /// �I�����ֺ޲z��
    /// </summary>
    public class Class_19_BgmManager : MonoBehaviour
    {
        [SerializeField]
        private Class_19_Event class_19_event;

        // �B�J 3. �q�\�ƥ� (Unity �ߺD�b Awake �� Start �q�\)
        private void Awake()
        {
            // �ƥ� : ��J += �i�H�ϥ� Tab �۰ʧ��� > �R�W��k�� > Enter ����
            class_19_event.onDead += ChangeBgm;
            class_19_event.onDeadAction += ChangeBgmViaHP;
            class_19_event.onEvent += ChangeBgmEvent;
            class_19_event.onEventWithHP += ChangeBgmEventWithHP;
        }

        private void ChangeBgmEventWithHP(object sender, float e)
        {
            LogSystem.LogWithColor($"�o�e�ƥ��:{sender}, �Ѽ� : {e}", "#ff3");
        }

        private void ChangeBgmEvent(object sender, System.EventArgs e)
        {
            LogSystem.LogWithColor($"�o�e�ƥ��:{sender}, �Ѽ� : {e}", "#ff3");
        }

        private void ChangeBgmViaHP(string playerName, float hp)
        {
            LogSystem.LogWithColor($"{playerName}, | ��q : {hp}", "#78f");
            if (hp <= -5) LogSystem.LogWithColor("�ܧ󬰹C����������", "#fdd");
        }

        private void ChangeBgm()
        {
            LogSystem.LogWithColor("�ܧ󭵼�", "#3f3");
        }
    }
}