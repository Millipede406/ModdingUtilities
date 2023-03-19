using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using UnityEngine;
using PatchQuest;

namespace ModdingUtilities
{
    public class ModMain : PatchQuestMod
    {
        public static ModMain Instance { get; private set; }

        public override void OnInitializeMelon()
        {
            Instance = this;
            base.OnInitializeMelon();
        }
        public static void Msg(string msg)
        {
            Instance.PrivateMsg(msg);
        }

        void PrivateMsg(string msg)
        {
            LoggerInstance.Msg(msg);
        }
    }
}
