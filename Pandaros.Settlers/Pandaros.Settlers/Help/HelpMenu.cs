﻿using Pandaros.Settlers.Items;
using Pandaros.Settlers.Models;
using Pandaros.Settlers.Extender;
using Pipliz;
using Shared;
using System.Collections.Generic;
using static Pandaros.Settlers.Items.StaticItems;
using NetworkUI;
using NetworkUI.Items;

namespace Pandaros.Settlers.Help
{
    public enum MenuItemType
    {
        Button,
        Image,
        Text
    }

    [ModLoader.ModManager]
    public class HelpMenuActivator : CSType, IOnConstructInventoryManageColonyUI
    {
        public static string NAME = GameLoader.NAMESPACE + ".HelpMenu";
        public override string name => NAME;
        public override string icon => GameLoader.ICON_PATH + "Help.png";
        public override bool? isPlaceable => false;
        public override int? maxStackSize => 1;
        public override List<string> categories { get; set; } = new List<string>()
        {
            "essential",
            "aaa"
        };
        public override StaticItem StaticItemSettings => new StaticItem() { Name = NAME };
        public override OpenMenuSettings OpensMenuSettings => new OpenMenuSettings()
        {
            ActivateClickType = PlayerClickedData.EClickType.Right,
            ItemName = NAME,
            UIUrl = "Wiki.MainMenu"
        };

        private static localization.LocalizationHelper _localizationHelper = new localization.LocalizationHelper("Wiki");

        public void OnConstructInventoryManageColonyUI(Players.Player player, NetworkMenu networkMenu)
        {
            networkMenu.Items.Add(new ButtonCallback(GameLoader.NAMESPACE + ".Wiki.Help", new LabelData(_localizationHelper.GetLocalizationKey("title"), UnityEngine.Color.black), 200));
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnPlayerPushedNetworkUIButton, GameLoader.NAMESPACE + ".Help.HelpMenuActivator.OnPlayerPushedNetworkUIButton")]
        public static void OnPlayerPushedNetworkUIButton(ButtonPressCallbackData data)
        {
            if (data.ButtonIdentifier == GameLoader.NAMESPACE + ".Wiki.Help")
            {
                UIManager.SendMenu(data.Player, "Wiki.MainMenu");
            }
        }
    }
}
