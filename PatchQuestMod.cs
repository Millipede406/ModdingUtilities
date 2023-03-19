using System;
using MelonLoader;
using PatchQuest;
using HarmonyLib;
using System.Collections.Generic;
using UnityEngine.Events;

namespace ModdingUtilities
{
    public class PatchQuestMod : MelonMod
    {
        public static List<PatchQuestMod> Instances;

        public static void LoadInstance(PatchQuestMod mod)
        {
            Instances.Add(mod);
            ModMain.Msg($"Mod {mod.MelonAssembly.Assembly.GetName()} added to mod instances");
        }
        /// <summary>
        /// IMPORTANT: Your mod will not load if you do not run base.OnInitializeMelon() at the start of this function
        /// </summary>
        public override void OnInitializeMelon()
        {
            if(Instances == null)
            {
                Instances = new List<PatchQuestMod>();
            }
            LoadInstance(this);
        }
        /// <summary>
        /// IMPORTANT: DO NOT USE THIS METHOD. USE `Update()` OR `MainUpdate()` INSTEAD
        /// </summary>
        public override void OnUpdate()
        {
            if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 0)
                return;
            Update();
            if (Game.InMainGame)
            {
                MainUpdate();
                if(Game.State == GameState.BASE_CAMP)
                {
                    BaseCampUpdate();
                }
                else if(Game.State == GameState.QUESTING)
                {
                    QuestUpdate();
                }
            }
        }
        /// <summary>
        /// Called every frame
        /// </summary>
        public virtual void Update()
        {

        }
        /// <summary>
        /// Called every frame while in-game
        /// </summary>
        public virtual void MainUpdate()
        {

        }
        /// <summary>
        /// Called every frame while in base camp
        /// </summary>
        public virtual void BaseCampUpdate()
        {

        }
        /// <summary>
        /// Called every frame while on a quest
        /// </summary>
        public virtual void QuestUpdate()
        {

        }
    }
}
