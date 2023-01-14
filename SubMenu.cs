using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldAPI.ButtonAPI;
using WorldAPI.ButtonAPI.Groups;
using WorldAPI.Buttons;

namespace Example;

internal class SubMenu // We're putting submenus into seprate classes as it looks 100x better then putting it into one class (let alone one method ~w~)
{
    internal static void MakeSubMenu() {
        // Now were going to make a sub menu, its very close to how the tab/ MainMemu is done, but instead of making a tab to open the menu, we're making a button and calling the OpenMenu Func on the VRCPage

        var subPage = new VRCPage("SubMenu"); // Making a new page
        new VRCButton(MakeMenu.MainGrp, "SubMenu", "UwU", () => subPage.OpenMenu()); // As all we're calling is the open menu, we dont need the brackets
        var subPageGrp = new ButtonGroup(subPage, "SubPage Grp");
        subPageGrp.AddButton("Hi :3", "This is now under the sub page ^w^", () => { return; });
        subPageGrp.AddLable("Info Lable", "Data"); // you can set this to a field, and edit the LowerUgi text to change the data
    }
}