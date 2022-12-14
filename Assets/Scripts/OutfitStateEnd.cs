/*
Full name: Samantha Mondragon, Briana Craig 
Student ID: 2406434,  2394738
Email: mondragonlanderos@chapman.edu, brcraig@chapman.edu
Course & Section: CPSC 245 - 01
Final Exam: Outfit Tool 
*/
/*
This source file contains the override methods for the 
end state, which is the last panel shown at the end
that allows the user to exit or reset the game
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitStateEnd : OutfitState
{
    public OutfitStateEnd(OutfitManager manager) : base(manager){}

    public override void OnMyStateEntered()
    {
        string stateEnteredMessage = "Entered Ending State";
        Debug.Log(stateEnteredMessage);
        outfitManager.HideCanvas("select");
        outfitManager.ShowCanvas("end");
        
    }
}
