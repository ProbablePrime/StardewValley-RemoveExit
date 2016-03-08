using System;
using System.Threading;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Inheritance.Menus;
using StardewModdingAPI.Inheritance;
using System.Collections.Generic;
using StardewValley.Menus;

namespace RemoveExit
{
    public class RemoveExit : Mod
    {
        ExitPage menu;
        bool done = false;
        public override string Name
        {
            get { return "Remove Exit"; }
        }

        public override string Authour
        {
            get { return "ProbablePrime"; }
        }

        public override string Version
        {
            get { return "0.1.0"; }
        }

        public override string Description
        {
            get { return "Removes the exit button from the menu. Because yeah. Don't ask why."; }
        }

        private Thread t;
        public override void Entry(params object[] objects)
        {
            Console.WriteLine("Pork Pie");
            GameEvents.UpdateTick += Events_Tick;
        }

        void Events_Tick(object sender, EventArgs e)
        {
            if(!SGame.hasLoadedGame)
                return;
            if (SGame.activeClickableMenu != null && SGame.activeClickableMenu is GameMenu)
            {
                
                GameMenu menuInstance = (GameMenu)SGame.activeClickableMenu;
                if (menuInstance.currentTab == SGameMenu.exitTab)
                {
                    menuInstance.exitThisMenu(true);
                }
            }

        }


    }
}
