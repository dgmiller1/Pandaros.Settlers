﻿using Pipliz.APIProvider.Science;
using Server.Science;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pandaros.Settlers.Research
{
    public class SettlerChance
    {
        public static readonly string TEMP_VAL_KEY = GameLoader.NAMESPACE + ".SettlerChance";
        
        [AutoLoadedResearchable]
        public class SettlerChance1 : BaseResearchable
        {
            public SettlerChance1()
            {
                key = TEMP_VAL_KEY + "1";
                icon = GameLoader.ICON_FOLDER_PANDA_REL + "\\SettlerChance1.png";
                PandaLogger.Log("chance 1:" + icon);
                iterationCount = 20;
                AddIterationRequirement(ColonyItems.sciencebagbasic, 10);
                AddIterationRequirement(ColonyItems.sciencebaglife, 20);
                AddIterationRequirement(ColonyItems.torch, 10);
                AddIterationRequirement(ColonyItems.stonebricks, 20);
                AddIterationRequirement(ColonyItems.bread, 5);
                AddIterationRequirement(ColonyItems.goldcoin, 250);
            }

            public override void OnResearchComplete(ScienceManagerPlayer manager)
            {
                manager.Player.SetTemporaryValue(TEMP_VAL_KEY, 0.1f);
            }
        }

        [AutoLoadedResearchable]
        public class SettlerChance2 : BaseResearchable
        {
            public SettlerChance2()
            {
                key = TEMP_VAL_KEY + "2";
                icon = GameLoader.ICON_FOLDER_PANDA_REL + "\\SettlerChance2.png";
                iterationCount = 25;
                AddIterationRequirement(ColonyItems.sciencebagbasic, 20);
                AddIterationRequirement(ColonyItems.sciencebaglife, 40);
                AddIterationRequirement(ColonyItems.torch, 20);
                AddIterationRequirement(ColonyItems.stonebricks, 40);
                AddIterationRequirement(ColonyItems.bread, 5);
                AddIterationRequirement(ColonyItems.goldcoin, 500);
                AddDependency(TEMP_VAL_KEY + "1");
            }

            public override void OnResearchComplete(ScienceManagerPlayer manager)
            {
                manager.Player.SetTemporaryValue(TEMP_VAL_KEY, 0.2f);
            }
        }

        [AutoLoadedResearchable]
        public class SettlerChance3 : BaseResearchable
        {
            public SettlerChance3()
            {
                key = TEMP_VAL_KEY + "3";
                icon = GameLoader.ICON_FOLDER_PANDA_REL + "\\SettlerChance3.png";
                iterationCount = 30;
                AddIterationRequirement(ColonyItems.sciencebagbasic, 40);
                AddIterationRequirement(ColonyItems.sciencebaglife, 80);
                AddIterationRequirement(ColonyItems.torch, 40);
                AddIterationRequirement(ColonyItems.stonebricks, 80);
                AddIterationRequirement(ColonyItems.bread, 10);
                AddIterationRequirement(ColonyItems.goldcoin, 1000);
                AddDependency(TEMP_VAL_KEY + "2");
            }

            public override void OnResearchComplete(ScienceManagerPlayer manager)
            {
                manager.Player.SetTemporaryValue(TEMP_VAL_KEY, 0.3f);
            }
        }

        [AutoLoadedResearchable]
        public class SettlerChance4 : BaseResearchable
        {
            public SettlerChance4()
            {
                key = TEMP_VAL_KEY + "4";
                icon = GameLoader.ICON_FOLDER_PANDA_REL + "\\SettlerChance4.png";
                iterationCount = 35;
                AddIterationRequirement(ColonyItems.sciencebagbasic, 80);
                AddIterationRequirement(ColonyItems.sciencebaglife, 160);
                AddIterationRequirement(ColonyItems.torch, 80);
                AddIterationRequirement(ColonyItems.stonebricks, 160);
                AddIterationRequirement(ColonyItems.bread, 10);
                AddIterationRequirement(ColonyItems.goldcoin, 2000);
                AddDependency(TEMP_VAL_KEY + "3");
            }

            public override void OnResearchComplete(ScienceManagerPlayer manager)
            {
                manager.Player.SetTemporaryValue(TEMP_VAL_KEY, 0.4f);
            }
        }

        [AutoLoadedResearchable]
        public class SettlerChance5 : BaseResearchable
        {
            public SettlerChance5()
            {
                key = TEMP_VAL_KEY + "5";
                icon = GameLoader.ICON_FOLDER_PANDA_REL + "\\SettlerChance5.png";
                iterationCount = 40;
                AddIterationRequirement(ColonyItems.sciencebagbasic, 160);
                AddIterationRequirement(ColonyItems.sciencebaglife, 340);
                AddIterationRequirement(ColonyItems.torch, 160);
                AddIterationRequirement(ColonyItems.stonebricks, 340);
                AddIterationRequirement(ColonyItems.bread, 15);
                AddIterationRequirement(ColonyItems.goldcoin, 4000);
                AddDependency(TEMP_VAL_KEY + "4");
            }

            public override void OnResearchComplete(ScienceManagerPlayer manager)
            {
                manager.Player.SetTemporaryValue(TEMP_VAL_KEY, 0.5f);
            }
        }
    }
}