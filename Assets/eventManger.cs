using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace DaydreamElements.ClickMenu
{

    public class eventManger : MonoBehaviour
    {
        public ClickMenuRoot menuRoot;
        public Animator target;
        public change sc;

        void Awake()
        {
            menuRoot.OnItemSelected += OnItemSelected;
        }


        private void OnItemSelected(ClickMenuItem item)
        {
            int id = (item ? item.id : -1);
            switch (id)
            {
                case 7: // crossarm
                    target.SetTrigger("Crossarm");
                    break;

                case 8: // dance
                    target.SetTrigger("Dance");
                    break;

                case 9: // death
                    target.SetTrigger("Death");
                    break;

                case 10: // sit
                    target.SetTrigger("Sit");
                    break;

                case 3: // happy
                    sc.changeNormal();
                    break;

                case 4: // sad
                    sc.changeSad();
                    break;

                case 5: // laugh
                    sc.changeHappy();
                    break;

                case 6: // angry
                    sc.changeAngry();
                    break;
                
            }
        }
    }
}
