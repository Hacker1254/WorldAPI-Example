using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldAPI.ButtonAPI.Wing;
using WorldAPI.ButtonAPI.Wing.Buttons;
using WorldAPI.ButtonAPI.WIng.Buttons;

namespace Example;

internal class WingMenu
{
    public static WPage wingPage;

    internal static void MakeWingMenu() {
        // now the Wing Support is Beta, there is an extention Method to copy a button to the Wing, but its Mehh

        wingPage = new("Example WingPg", WorldAPI.APIBase.WingSide.Left); // We're going to make a Wing on the left side, YOU HAVE TO MAKE THE OPENER BUTTON ON THE SAME SIDE
        new WButton(WorldAPI.APIBase.WingSide.Left, "Open Example Menu", () => wingPage.OpenMenu(), "Open the Example Wing Menu");
        new WButton(wingPage, "Wing Button", () => { // These are pretty Simple
            Console.WriteLine("Pressed Wing Button");
        }, "ToolTip");
        new WToggle(wingPage, "Wing Tgl", (val) => { // Make sure to update ur install of the API as i think i forgot to put in the support for the ToolTips
            Console.WriteLine(val);
        });
    }
}