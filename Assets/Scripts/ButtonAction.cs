/*
Full name: Samantha Mondragon, Briana Craig 
Student ID: 2406434,  2394738
Email: mondragonlanderos@chapman.edu, brcraig@chapman.edu
Course & Section: CPSC 245 - 01
Final Exam: Outfit Tool 
*/
/*
This source file contains the OnClick methods for all
of the buttons in our project
 */
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAction : MonoBehaviour
{
    public SoundManager sounds;
    public OutfitManager outfitManager;

    public Button ShirtDisplay;
    public Button BottomDisplay;
    public Button ShoesDisplay;
    public Button HatsDisplay;

    public Button ZoomedShirt;
    public Button ZoomedBottoms;
    public Button ZoomedShoes;
    public Button ZoomedHats;

    public Sprite resetBlank;

    /*
     CloseApplication
     This method has to parameters or return type
     because it is meant to close the app in
     when running the build
     */
    public void CloseApplication()
    {
        sounds.PlayClickSound();
        Application.Quit();
    }

    /*
     ActionStartGame
     This method has no return type or parameters
     and it enters the start state
     when the reset button is clicked
     */
    public void ActionStartGame()
    {
        //Debug.Log("about to play game");
        sounds.PlayClickSound();
        outfitManager.PublishEventToCurrentState(OutfitState.EventType.OutfitStart);
    }

    /*
    ActionSelection
    This method has no return type or parameters
    and it enters the selection state
    when the start or go back/return buttons are clicked
    */
    public void ActionSelection()
    {
        //Debug.Log("about to select something");
        sounds.PlayClickSound();
        outfitManager.PublishEventToCurrentState(OutfitState.EventType.OutfitSelect);
    }
    /*
    ActionSelectHat
    This method has no return type or parameters
    and it enters the hat state
    when the head button is clicked
    */
    public void ActionSelectHat()
    {
        //Debug.Log("about to select a hat");
        sounds.PlayClickSound();
        outfitManager.PublishEventToCurrentState(OutfitState.EventType.OutfitHat);
    }

    /*
    ActionSelectShirt
    This method has no return type or parameters
    and it enters the shirt state
    when the torso button is clicked
    */
    public void ActionSelectShirt()
    {
        //Debug.Log("about to select a shirt");
        sounds.PlayClickSound();
        outfitManager.PublishEventToCurrentState(OutfitState.EventType.OutfitShirt);
    }
    
    /*
     ActionSelectPants
     This method has no return type or parameters
     and it enters the pants state
     when the legs button is clicked
     */
    public void ActionSelectPants()
    {
        //Debug.Log("about to select a pair of pants");
        sounds.PlayClickSound();
        outfitManager.PublishEventToCurrentState(OutfitState.EventType.OutfitPants);
    }

    /*
    ActionSelectShoes
    This method has no return type or parameters
    and it enters the shoes state
    when the feet button is clicked
 */
    public void ActionSelectShoes()
    {
        //Debug.Log("about to select a pair of shoes");
        sounds.PlayClickSound();
        outfitManager.PublishEventToCurrentState(OutfitState.EventType.OutfitShoes);
    }
    
    /*
     ActionEndGame
     This method has no return type or parameters
     and it enters the end state
     when the finish button is clicked. It also
     reset all the sprites back to blank
     */
    public void ActionEndGame()
    {
        //Debug.Log("about to end game");
        sounds.PlayClickSound();
        outfitManager.PublishEventToCurrentState(OutfitState.EventType.OutfitEnd);
        
        ShirtDisplay.GetComponent<Image>().sprite = resetBlank;
        ShirtDisplay.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        ZoomedShirt.GetComponent<Image>().sprite = resetBlank;
        ZoomedShirt.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        
        BottomDisplay.GetComponent<Image>().sprite = resetBlank;
        BottomDisplay.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        ZoomedBottoms.GetComponent<Image>().sprite = resetBlank;
        ZoomedBottoms.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        
        ShoesDisplay.GetComponent<Image>().sprite = resetBlank;
        ShoesDisplay.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        ZoomedShoes.GetComponent<Image>().sprite = resetBlank;
        ZoomedShoes.GetComponent<Image>().color = new Color(255, 255, 255, 255);

        HatsDisplay.GetComponent<Image>().sprite = resetBlank;
        HatsDisplay.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        ZoomedHats.GetComponent<Image>().sprite = resetBlank;
        ZoomedHats.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        
    }
    /*
     OnShirtClick
     This method has no return type and takes in a sprite parameter
     and it enters changes the shirt display to match the sprite
     of the shirt button that was clicked
     */
    
    public void OnShirtClick(Sprite Item)
    {
        //Debug.Log("clicked on a clothing item");
        sounds.PlayClickSound();
        ShirtDisplay.GetComponent<Image>().sprite = Item;
        ShirtDisplay.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        ZoomedShirt.GetComponent<Image>().sprite = Item;
        ZoomedShirt.GetComponent<Image>().color = new Color(255, 255, 255, 255);
    }
    
    /*
     OnBottomsClick
     This method has no return type and takes in a sprite parameter
     and it enters changes the pants display to match the sprite
     of the pants button that was clicked
     */
    public void OnBottomsClick(Sprite Item)
    {
        //Debug.Log("clicked on a clothing item");
        sounds.PlayClickSound();
        BottomDisplay.GetComponent<Image>().sprite = Item;
        BottomDisplay.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        ZoomedBottoms.GetComponent<Image>().sprite = Item;
        ZoomedBottoms.GetComponent<Image>().color = new Color(255, 255, 255, 255);
    }
    
    /*
     OnShoesClick
     This method has no return type and takes in a sprite parameter
     and it enters changes the shoe display to match the sprite
     of the shoe button that was clicked
     */
    public void OnShoesClick(Sprite Item)
    {
        //Debug.Log("clicked on a clothing item");
        sounds.PlayClickSound();
        ShoesDisplay.GetComponent<Image>().sprite = Item;
        ShoesDisplay.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        ZoomedShoes.GetComponent<Image>().sprite = Item;
        ZoomedShoes.GetComponent<Image>().color = new Color(255, 255, 255, 255);
    }
    
    /*
     OnHatClick
     This method has no return type and takes in a sprite parameter
     and it enters changes the hat display to match the sprite
     of the hat button that was clicked
     */
    public void OnHatsClick(Sprite Item)
    {
        //Debug.Log("clicked on a clothing item");
        sounds.PlayClickSound();
        HatsDisplay.GetComponent<Image>().sprite = Item;
        HatsDisplay.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        ZoomedHats.GetComponent<Image>().sprite = Item;
        ZoomedHats.GetComponent<Image>().color = new Color(255, 255, 255, 255);
    }
}

