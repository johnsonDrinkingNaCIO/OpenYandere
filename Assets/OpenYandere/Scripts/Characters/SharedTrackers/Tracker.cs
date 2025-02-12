using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace OpenYandere.Characters.SharedTrackers
{
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Character))]
    public abstract class Tracker : MonoBehaviour
    {
        [SerializeField] public bool TrackerActive;
        protected Character owner;
        protected bool init;
       
        protected void Awake()
        {
            owner = GetComponent<Character>();
        }

        // Update is called once per frame
        protected void Update()
        {
           
        }
        public abstract bool IsThatAppealingToMe(SharedMind.Mind.Reaction data);
        public void ShowDebugInfo() { }
    }
}
