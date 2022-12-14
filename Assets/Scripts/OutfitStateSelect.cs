/*
Full name: Samantha Mondragon, Briana Craig 
Student ID: 2406434,  2394738
Email: mondragonlanderos@chapman.edu, brcraig@chapman.edu
Course & Section: CPSC 245 - 01
Final Exam: Outfit Tool 
*/
/*
This source files contains the override methods for 
the select state, which is the zoomed out panel where
the player can select all clothing items and see the 
whole body display of the outfit. 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitStateSelect : OutfitState
{
    public OutfitStateSelect(OutfitManager manager) : base(manager){}

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
        string stateEnteredMessage = "Entered Selection State";
        Debug.Log(stateEnteredMessage);
        outfitManager.HideCanvas("start");
        outfitManager.HideCanvas("hat");
        outfitManager.HideCanvas("shirt");
        outfitManager.HideCanvas("pants");
        outfitManager.HideCanvas("shoes");
        outfitManager.ShowCanvas("select");
        
    }
}