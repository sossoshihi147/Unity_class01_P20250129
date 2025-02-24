using UnityEngine;

namespace OLIVER
{
    public class homework_10 : MonoBehaviour
    {
        private void Start()
        {
            var redWater = new Potion("紅色藥水");
            var blueWater = new Potion("藍色藥水");
            Equipage helmet = new Equipage("頭盔");

            redWater.Use();
            blueWater.Use(50);
            helmet.Use();  
        }

        public class Item
        {
            public string name;
            public Item(string _name)
            {
                name = _name;
            }
            public virtual void Use()
            {
                LogSystem.LogWithColor($"道具名稱：{name}", "#8f0");
            }
        }

        public class Potion : Item
        {
            public Potion(string _name) : base(_name)
            {
            }
            public void Use(int efficacy)
            {
                LogSystem.LogWithColor($"道具名稱：{name}，恢復了{efficacy} MP", "#ff0");
            }
        }

        public class Equipage : Item
        {
            public Equipage(string _name) : base(_name)
            {
            }
            public override void Use()
            {
                LogSystem.LogWithColor($"這是裝備：{name}", "#0f8");
            }
        }
    }
}
