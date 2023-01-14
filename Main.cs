using System.Collections;
using UnityEngine;
using WorldLoader.Attributes;
using WorldLoader.Mods;
using WorldLoader.Utils;

namespace Example;

[Mod("Example Mod", "Default", "_1254")] // Mod Info
public class Main : UnityMod // Add the base type so the loader could find and inti the class 
{
    public override void OnInject() // This runs the moment the loader intis the dll, its only ran once during the Inti
    {
        waitForQM().Start(); // Start, this is an extention Method, you could call CoroutinesHandler.Start(enmu); | Needs to have "using WorldLoader.Utils;"
        IEnumerator waitForQM() {
            while (GameObject.Find("Canvas_QuickMenu(Clone)") == null) yield return null; // Trys to find the Qm, if the Find Return null, it will wait for the next frame and check
            yield return null; // wait one more frame, this is needed, but shut up

            MakeMenu.MakeMainMenu();

            yield break; // This stops the IEnum
        }
    }
}