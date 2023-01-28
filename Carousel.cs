using System;
using WorldAPI;
using WorldAPI.ButtonAPI.MM;
using WorldAPI.ButtonAPI.MM.Carousel;
using WorldAPI.ButtonAPI.MM.Carousel.Items;

namespace Example;

internal class Carousel
{
    internal static void Make() {
        var Cmm = new MMCarousel("Root", "WorldClient", null);
        Cmm.SetExtraButtons("Button 1", null, "Tip", "Button 2", null, "Tip", null, null);

        new MMTab(Cmm, "Baller Menu", APIBase.DefaultButtonSprite);
        var mnu = new CMenu(Cmm, "Menu 1");
        var grp = new CGrp(mnu, "Button Grp");
        new CToggle(grp, "<3", (val) => {
            Console.WriteLine(val);
        }); new CToggle(grp, "<3", (val) => {
            Console.WriteLine(val);
        }); new CToggle(grp, "<3", (val) => {
            Console.WriteLine(val);
        });
        new CSlider(grp, "<3", (val) => {
            Console.WriteLine(val);
        });

        mnu = new CMenu(Cmm, "Menu 2");
        grp = new CGrp(mnu, "Button Grp");
        new CToggle(grp, "I love you sweetheart", (val) => {
            Console.WriteLine(val);
        }); new CToggle(grp, "Be mine?", (val) => {
            Console.WriteLine(val);
        }); new CToggle(grp, "You're my Baby <3", (val) => {
            Console.WriteLine(val);
        }); new CToggle(grp, "My Sweetie", (val) => {
            Console.WriteLine(val);
        });
    }
}