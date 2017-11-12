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
        public AudioSource danceAudio;
        public AudioSource deathAudio;
        public AudioSource thingkingAudio;
        public AudioSource happyAudio;
        public AudioSource laughAudio;
        public AudioSource sadAudio;
        public AudioSource angryAudio;

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
                    thingkingAudio.Play();
                    target.SetTrigger("Crossarm");
                    break;

                case 8: // dance
                    danceAudio.Play();
                    target.SetTrigger("Dance");
                    break;

                case 9: // death
                    deathAudio.Play();
                    target.SetTrigger("Death");
                    break;

                case 10: // sit
                    thingkingAudio.Play();
                    target.SetTrigger("Sit");
                    break;

                case 3: // happy
                    happyAudio.Play();
                    sc.changeNormal();
                    break;

                case 4: // sad
                    sadAudio.Play();
                    sc.changeSad();
                    break;

                case 5: // laugh
                    laughAudio.Play();
                    sc.changeHappy();
                    break;

                case 6: // angry
                    angryAudio.Play();
                    sc.changeAngry();
                    break;
                
            }
        }
    }
}
