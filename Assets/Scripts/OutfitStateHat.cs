/*
Full name: Samantha Mondragon, Briana Craig 
Student ID: 2406434,  2394738
Email: mondragonlanderos@chapman.edu, brcraig@chapman.edu
Course & Section: CPSC 245 - 01
Final Exam: Outfit Tool 
*/
/*
This source files contains the override methods for 
the hat state, which is the zoomed in panel where
the player can select a hat. 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitStateHat : OutfitState
{
    public OutfitStateHat(OutfitManager manager) : base(manager){}

    /*
     override OnMyStateEntered 
     This method overrides the virtual OnMyStateEntered
     from the parent OutfitState class, it does not take in
     any parameters or return anything, it only shows
     the canvas that matches the one for this state and hides any
     canvases that could be active before entering this state
     */
    public override void OnMyStateEntered()
    {
        string stateEnteredMessage = "Entered Hat State";
        Debug.Log(stateEnteredMessage);
        outfitManager.HideCanvas("select"); 
        outfitManager.ShowCanvas("hat");
        
    }
}

