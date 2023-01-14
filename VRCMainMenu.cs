using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldAPI;
using WorldAPI.ButtonAPI.Groups;
using WorldAPI.ButtonAPI.MM;

namespace Example;

internal class VRCMainMenu
{
    internal static void MakeMainMenu()
    { // So a few thing about the MM, its support is pretty beta, but it should support the exact objects that the QM Supports 
        // REMEMEBER, YOU CANT USE QM PAGES AND OPENING HERE ~w~

        var page = new MMPage("TestMenu", true); // Make sure to update, as the lastest doesn't really support RootPages
        var subPage = new MMPage("TestMenu");
        new MMTab(page, "Test Menu", APIBase.DefaultButtonSprite);

        var subGrp = new ButtonGroup(subPage, "SubMenu");
        var mainGrp = new ButtonGroup(page, "TEST");

        mainGrp.AddButton("Same as QM", "You can use QM Elements here, or make ur own :3", () => { });
        mainGrp.AddButton("SubMenu", "SubMenus too", () => subPage.OpenMenu());


        subGrp.AddButton("UwU", "Baller", () => { });
    }
}
