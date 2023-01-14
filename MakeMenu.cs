using System;
using WorldAPI.ButtonAPI;
using WorldAPI.ButtonAPI.Buttons;
using WorldAPI.ButtonAPI.Groups;
using WorldAPI.Buttons;

namespace Example;

internal class MakeMenu // Outside call, so we dont put everything on the main class (skids do this a lot, its messy ~w~)
{
    public static VRCPage MainPage;
    public static ButtonGroup MainGrp;

    internal static void MakeMainMenu() { // So, here we make the Make it internal, this means it can only be called withen the Example Namespace
        MainPage = new("Example Menu"); // Making a new VRCPage, cause the we're assining a field, we can just use the new() keyword as the IDE already the new class we're making, basiclly the same as doing new VRCPage(..);
        new Tab(MainPage, "Buy WCv2 <3"); // Making a new tab, i dout we'll ever need to mess with this in the furter time, so we dont need to assine it a field

        MainGrp = new ButtonGroup(MainPage, "Btn Grp"); // the first parm is the menu ur wanting to put the button Grp's, this Grp will hold all of ur menus

        SubMenu.MakeSubMenu(); // Making sure this is called AFTER!! the mainMenu is made

        // now we are going to add buttons, there are a few ways we can do this, both pretty much do the same thing
        // First we're going to make a button buy making a new inst of the button class

        new VRCButton(MainGrp, "HIII", "UwU", () => {
            // You can write any action here, if its just a oneliner action, you can do without the brackets
            Console.WriteLine("<3 Button One Pressed <3");
        });

        // now we're going to use the extention Method, its pretty much the same ~w~

        MainGrp.AddButton("HIII 2", "UwU", () => {
            // You can write any action here, if its just a oneliner action, you can do without the brackets
            Console.WriteLine("<3 Button Two Pressed <3");
        });

        // Now were going to do toggles, my api does toggles a little diffrent then most of what ur used too, but it should be much more easier once u understand it <3
        // This can be made very much like the buttons, so ima skip showing you both ways you can do this

        new VRCToggle(MainGrp, "Test Tgl", (val /*here we have a var, this var will be the state of the toggle*/) => {
            if (val) { // you can write you own code here
                Console.WriteLine(val);
            } else { 
                // Write Off Code here
            }
        });

        // we got the basics down, but this API can do so much more
        // We're going to make a CollapsibleButtonGroup
        var colbBtnGrp = new CollapsibleButtonGroup(MainPage, "You can Close me!");

        colbBtnGrp.AddDuoButtons("Duo Buttons!", "Top Button", ()=>{
            // Press Action
        }, "Bottomm", "Bottom Button ;3", () => { 
            // Press Action
        });

        colbBtnGrp.AddGrpOfButtons("1", "1", () => {
            // Press Action
        }, "2", "2", () => {
            // Press Action
        }, "3", "3", () => {
            // Press Action
        });
        colbBtnGrp.AddGrpToggles("Top", "On", "Off", (val) => {
            Console.WriteLine(val);
        }, "Bottom", "On", "Off", (val) => {
            Console.WriteLine(val);
        });

        ExtraMenus(); // Make the WingMenu and MM Stuff
    }

    private static void ExtraMenus() {
        WingMenu.MakeWingMenu();
        VRCMainMenu.MakeMainMenu();
    }
}