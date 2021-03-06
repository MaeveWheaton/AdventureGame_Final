/*
 * Maeve Wheaton
 * Mr. T
 * May 18, 2021
 * A short choose your adventure game with three storylines and many possible endings,
 * the variable 'page' is used to advance the story after each choice.
 * Each scene has a picture and sound, not necessarily every page as I wanted to keep some consitentcy in certain scenes.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        //tracked variables
        int page = 1;
        string meleeWeapon, rangeWeapon;        
        bool tunnelMap = false;
        bool spiritWater = false;
        bool littleBoy = false;
        int health = 10;
        int successPercent;
                    
        //resources
        SoundPlayer bgmusicPlayer = new SoundPlayer(Properties.Resources.background_music);
        SoundPlayer soundEffectPlayer;
        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();

            //Start music
            bgmusicPlayer.Play();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //clear button, show info message, show pg 1
            startButton.Visible = false;
            startButton.Enabled = false;            
            storyOutput.Visible = true;
            Refresh();
            Thread.Sleep(5000);

            option1Output.Visible = true;
            option2Output.Visible = true;
            option1Button.Visible = true;
            option2Button.Visible = true;
            healthOutput.Visible = true;

            DisplayPage();            
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                meleeWeapon = "sword";
                page = 2;
            }
            else if (page == 2)
            {
                rangeWeapon = "bow";
                page = 3;
            }
            else if (page == 3) { page = 4; }
            else if (page == 4) { page = 5; }
            else if (page == 5) { page = 6; }
            else if (page == 7) { page = 8; }
            else if (page == 8) { page = 10; }
            else if (page == 9) { page = 10; }
            else if (page == 10) { page = 12; }
            else if (page == 11) { page = 14; }
            else if (page == 14) { page = 22; }
            else if (page == 15) { page = 22; }
            else if (page == 16) { page = 18; }
            else if (page == 17) { page = 20; }
            else if (page == 22) { page = 23; }
            else if (page == 23) { page = 1; }
            else if (page == 24) { page = 1; }
            else if (page == 25) { page = 26; }
            else if (page == 26) { page = 1; }
            else if (page == 27) { page = 1; }
            else if (page == 28) { page = 29; }
            else if (page == 29) { page = 30; }
            else if (page == 30) { page = 32; }
            else if (page == 31) { page = 34; }
            else if (page == 32) { page = 36; }
            else if (page == 33) { page = 40; }
            else if (page == 34) { page = 40; }
            else if (page == 35) { page = 40; }
            else if (page == 36) { page = 38; }
            else if (page == 37) { page = 38; }
            else if (page == 38) { page = 42; }
            else if (page == 39) { page = 42; }
            else if (page == 40) { page = 42; }
            else if (page == 41) { page = 42; }
            else if (page == 42) { page = 45; }
            else if (page == 43) { page = 45; }
            else if (page == 44) { page = 45; }
            else if (page == 45)
            {
                successPercent = randGen.Next(1, 101);
                if (successPercent > 50) { page = 49; }
                else { page = 48; }
            }
            else if (page == 46)
            {
                successPercent = randGen.Next(1, 101);
                if (successPercent > 50) { page = 49; }
                else { page = 48; }
            }
            else if (page == 47)
            {
                successPercent = randGen.Next(1, 101);
                if (successPercent > 50) { page = 49; }
                else { page = 48; }
            }
            else if (page == 48) { page = 1; }
            else if (page == 49) { page = 51; }
            else if (page == 50) { page = 1; }
            else if (page == 51) { page = 1; }
            else if (page == 52) { page = 1; }
            else if (page == 53) { page = 54; }
            else if (page == 54) { page = 55; }
            else if (page == 55) { page = 61; }
            else if (page == 56) { page = 58; }
            else if (page == 57) { page = 58; }
            else if (page == 58) { page = 61; }
            else if (page == 59) { page = 61; }
            else if (page == 60) { page = 64; }
            else if (page == 61) { page = 64; }
            else if (page == 62) { page = 64; }
            else if (page == 63) { page = 65; }
            else if (page == 64) { page = 67; }
            else if (page == 65) { page = 67; }
            else if (page == 66) { page = 67; }
            else if (page == 67)
            {
                successPercent = randGen.Next(1, 101);
                if (successPercent > 40) { page = 70; }
                else { page = 71; }
            }

            else if (page == 98) { page = 1; }
            else if (page == 68)
            {
                successPercent = randGen.Next(1, 101);
                if (successPercent > 40) { page = 70; }
                else { page = 71; }
            }
            else if (page == 69)
            {
                successPercent = randGen.Next(1, 101);
                if (successPercent > 40) { page = 73; }
                else { page = 72; }
            }
            else if (page == 70) { page = 1; }
            else if (page == 71)
            {
                successPercent = randGen.Next(1, 101);
                if (successPercent > 40) { page = 73; }
                else { page = 72; }
            }
            else if (page == 72) { page = 1; }
            else if (page == 73) { page = 1; }
            else if (page == 74)
            {
                successPercent = randGen.Next(1, 101);
                if (successPercent > 40) { page = 77; }
                else { page = 76; }
            }
            else if (page == 75) { page = 1; }
            else if (page == 76) { page = 1; }
            else if (page == 77) { page = 1; }
            else if (page == 78) { page = 1; }

            DisplayPage();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                meleeWeapon = "polearm";
                page = 2;
            }
            else if (page == 2)
            {
                rangeWeapon = "daggers";
                page = 3;
            }
            else if (page == 3) { page = 28; }
            else if (page == 4) { page = 3; }
            else if (page == 5) { page = 6; }
            else if (page == 7) { page = 9; }
            else if (page == 8) { page = 11; }
            else if (page == 9) { page = 11; }
            else if (page == 10) { page = 13; }
            else if (page == 11) { page = 15; }
            else if (page == 14) { page = 17; }
            else if (page == 15) { page = 17; }
            else if (page == 16) { page = 19; }
            else if (page == 17) { page = 21; }
            else if (page == 22)
            {
                successPercent = randGen.Next(1, 101);
                if (successPercent > 50) { page = 24; }
                else { page = 25; }
            }
            else if (page == 23) { page = 99; }
            else if (page == 24) { page = 99; }
            else if (page == 25) { page = 27; }
            else if (page == 26) { page = 99; }
            else if (page == 27) { page = 99; }
            else if (page == 28) { page = 3; }
            else if (page == 29) { page = 31; }
            else if (page == 30) { page = 33; }
            else if (page == 31) { page = 35; }
            else if (page == 32) { page = 37; }
            else if (page == 33) { page = 41; }
            else if (page == 34) { page = 41; }
            else if (page == 35) { page = 41; }
            else if (page == 36) { page = 39; }
            else if (page == 37) { page = 39; }
            else if (page == 38) { page = 43; }
            else if (page == 39) { page = 43; }
            else if (page == 40) { page = 43; }
            else if (page == 41) { page = 43; }
            else if (page == 42) { page = 46; }
            else if (page == 43) { page = 46; }
            else if (page == 44) { page = 46; }
            else if (page == 45) { page = 50; }
            else if (page == 46) { page = 50; }
            else if (page == 47) { page = 50; }
            else if (page == 48) { page = 99; }
            else if (page == 49) { page = 52; }
            else if (page == 50) { page = 99; }
            else if (page == 51) { page = 99; }
            else if (page == 52) { page = 99; }
            else if (page == 53) { page = 3; }
            else if (page == 54) { page = 56; }
            else if (page == 55) { page = 60; }
            else if (page == 56) { page = 59; }
            else if (page == 57) { page = 59; }
            else if (page == 58) { page = 60; }
            else if (page == 59) { page = 62; }
            else if (page == 60) { page = 63; }
            else if (page == 61) { page = 63; }
            else if (page == 62) { page = 63; }
            else if (page == 63) { page = 66; }
            else if (page == 64) { page = 68; }
            else if (page == 65) { page = 68; }
            else if (page == 66) { page = 68; }
            else if (page == 67) { page = 69; }
            else if (page == 68) { page = 69; }
            else if (page == 69)
            {
                successPercent = randGen.Next(1, 101);
                if (successPercent > 40) { page = 75; }
                else { page = 74; }
            }
            else if (page == 70) { page = 99; }
            else if (page == 71)
            {
                successPercent = randGen.Next(1, 101);
                if (successPercent > 40) { page = 75; }
                else { page = 74; }
            }
            else if (page == 72) { page = 99; }
            else if (page == 73) { page = 99; }
            else if (page == 74) { page = 78; }
            else if (page == 75) { page = 99; }
            else if (page == 76) { page = 99; }
            else if (page == 77) { page = 99; }
            else if (page == 78) { page = 99; }
            else if (page == 98) { page = 99; }

             DisplayPage();
            }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 5) { page = 7; }
            else if (page == 22)
            {
                successPercent = randGen.Next(1, 101);
                if (successPercent > 50) { page = 24; }
                else { page = 25; }
            }
            else if (page == 38) { page = 44; }
            else if (page == 39) { page = 44; }
            else if (page == 40) { page = 44; }
            else if (page == 41) { page = 44; }
            else if (page == 42) { page = 47; }
            else if (page == 43) { page = 47; }
            else if (page == 44) { page = 47; }
            else if (page == 54) { page = 57; }

            DisplayPage();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (page == 6) { page = 5; }
            else if (page == 12) { page = 16; }
            else if (page == 13) { page = 16; }
            else if (page == 18) { page = 22; }
            else if (page == 19) { page = 22; }
            else if (page == 20) { page = 22; }
            else if (page == 21) { page = 22; }

            nextButton.Visible = false;
            DisplayPage();
        }

        public void DisplayPage()
        {
            switch (page)
            {
                // intro
                case 1:
                    //design changes
                    titleLabel.Text = "Choose Your Weapon";
                    mapImageOutput.Visible = false;

                    //play sound
                    bgmusicPlayer = new SoundPlayer(Properties.Resources.symphony_sounds);
                    bgmusicPlayer.Play();

                    //change image
                    imageOutput.BackgroundImage = Properties.Resources.polearm;

                    //outputs
                    storyOutput.Text = "Congratulations young apprentice, please choose your melee weapon, the weapon you will use in close combat.";
                    option1Output.Text = "Long Sword";
                    option2Output.Text = "Polearm";

                    //Health
                    health = 10; //reset health for when coming back to pg 1
                    HealthCheck();
                    break;
                case 2:
                    imageOutput.BackgroundImage = Properties.Resources.bow_arrows;

                    storyOutput.Text = "Next, please choose your long range weapon, the weapon you will use for long range attacks.";
                    option1Output.Text = "Bow and Arrows";
                    option2Output.Text = "Throwing Daggers";
                    break;
                case 3:
                    titleLabel.Text = "Choose Your Quest";
                    option3Button.Visible = true; //show third option 
                    option3Output.Visible = true;

                    imageOutput.BackgroundImage = Properties.Resources.main_map;

                    storyOutput.Text = "Now that you have your weapons you are ready to begin your journey for...";
                    option1Output.Text = "Riches";
                    option2Output.Text = "Glory";
                    option3Output.Text = "Revenge";
                    break;
                // Riches Storyline
                case 4:                    
                    option3Button.Visible = false; //remove third option 
                    option3Output.Visible = false;

                    imageOutput.BackgroundImage = Properties.Resources.riches_map;

                    storyOutput.Text = "Far to the south there is said to be a cave full of gold and jewels. Would you like to enbark on this quest?";
                    option1Output.Text = "Yes";
                    option2Output.Text = "No";
                    break;
                case 5:
                    titleLabel.Text = "A Quest for Riches";
                    nextButton.Visible = false;
                    option3Button.Visible = true;
                    option3Output.Visible = true;
                    option1Button.Visible = true;
                    option2Button.Visible = true;

                    bgmusicPlayer = new SoundPlayer(Properties.Resources.soft_music);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.mountain_door;

                    storyOutput.Text = "You arrive at the mountain to find a door with strange inscription. Answer the riddle and ye shall enter, it says. People make me, keep me, change me, raise me, even though I can be very dirty. What am I?";
                    option1Output.Text = "Child";
                    option2Output.Text = "Plant";
                    option3Output.Text = "Money";
                    break;
                case 6:
                    option3Button.Visible = false;
                    option3Output.Visible = false;
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    nextButton.Visible = true; //some portions of the story worked best with two pages one after the other, next button to continue

                    imageOutput.BackgroundImage = Properties.Resources.mountain_door_2;

                    storyOutput.Text = "Unfortunately, that answer is incorrect. The door glows and you feel a most painful shock go through you. Press next to try again.";
                    option1Output.Text = "";
                    option2Output.Text = "";

                    health -= 2;
                    HealthCheck(); //check & update health bar - ends game if dead
                    break;
                case 7:
                    option3Button.Visible = false;
                    option3Output.Visible = false;

                    bgmusicPlayer = new SoundPlayer(Properties.Resources.foreboding_music);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.mountain_entrance;

                    storyOutput.Text = "The door glows and the side of the mountain swings open. You step into a large open room with the entrance to a tunnel on the right side.";
                    option1Output.Text = "Look around";
                    option2Output.Text = "Enter the tunnel";
                    break;
                case 8:
                    mapImageOutput.Visible = true;
                    tunnelMap = true;

                    imageOutput.BackgroundImage = Properties.Resources.tunnel_fork;

                    storyOutput.Text = "When searching aroung you trip a trap and obtain minor injuries. However, you also find a map of what seems to be the tunnels leading to the treasure. You then enter the tunnel into the mountain.";
                    option1Output.Text = "Go Right";
                    option2Output.Text = "Go Left";

                    health -= 2;
                    HealthCheck(); 
                    break;
                case 9:
                    imageOutput.BackgroundImage = Properties.Resources.tunnel_fork;

                    storyOutput.Text = "You enter the tunnel and continue until you reach a fork in the tunnel.";
                    option1Output.Text = "Go Right";
                    option2Output.Text = "Go Left";
                    break;
                case 10:
                    soundEffectPlayer = new SoundPlayer(Properties.Resources.slime);
                    soundEffectPlayer.Play();                                                            

                    imageOutput.BackgroundImage = Properties.Resources.slime_monster;

                    storyOutput.Text = "The right tunnel leads to a room, in the centre is a large green monster. How will you attack?";
                    option1Output.Text = "Melee Weapon";
                    option2Output.Text = "Long Range Weapon";

                    imageOutput.Refresh();
                    storyOutput.Refresh();
                    option1Output.Refresh();
                    option2Output.Refresh();
                    Thread.Sleep(1000);

                    bgmusicPlayer = new SoundPlayer(Properties.Resources.battle_music);
                    bgmusicPlayer.Play();
                    break;
                case 11:
                    bgmusicPlayer = new SoundPlayer(Properties.Resources.battle_music);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.armoured_dwarf;

                    storyOutput.Text = "The left tunnel leads to a room, sitting at the side is an armoured dwarf. How will you attack?";
                    option1Output.Text = "Melee Weapon";
                    option2Output.Text = "Long Range Weapon";
                    break;
                case 12:
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    nextButton.Visible = true;

                    imageOutput.BackgroundImage = Properties.Resources.slime_monster;

                    storyOutput.Text = $"You pierce the monster with your {meleeWeapon}, it explodes and your arms are burned by a slimy substance. After wiping it off quickly you continue through a tunnel on the other side of the room.";
                    option1Output.Text = "";
                    option2Output.Text = "";

                    if (meleeWeapon == "polearm") { health -= 2; }
                    else { health -= 3; }
                    HealthCheck();
                    break;
                case 13:
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    nextButton.Visible = true;

                    imageOutput.BackgroundImage = Properties.Resources.slime_monster;

                    storyOutput.Text = "You attack the monster from a distance so when it explodes you are left with only some minor burns as you continue through a tunnel on the other side of the room.";
                    option1Output.Text = "";
                    option2Output.Text = "";

                    health--;
                    HealthCheck();
                    break;
                case 14:
                    imageOutput.BackgroundImage = Properties.Resources.armoured_dwarf;

                    storyOutput.Text = $"You draw your {meleeWeapon} and attack. The dwarf swings it's ax at you but only manages to clip you before you land a killing blow. Then you continue through the tunnel on the other side of the room to another fork.";
                    option1Output.Text = "Go Left";
                    option2Output.Text = "Continue Straight";

                    health--;
                    HealthCheck();
                    break;
                case 15:
                    imageOutput.BackgroundImage = Properties.Resources.armoured_dwarf;

                    storyOutput.Text = $"You attack with your {rangeWeapon}, but the dwarf's armor partially protects it. It attacks you before dying, leaving you injured but alive as you continue through the tunnel on the other side of the room to another fork.";
                    option1Output.Text = "Go Left";
                    option2Output.Text = "Continue Straight";

                    if (rangeWeapon == "daggers") { health -= 2; }
                    else { health -= 3; }
                    HealthCheck();
                    break;
                case 16:
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    nextButton.Visible = false;

                    imageOutput.BackgroundImage = Properties.Resources.armoured_dwarf;

                    storyOutput.Text = "The tunnel leads to a room, sitting at the side is an armoured dwarf. How will you attack?";
                    option1Output.Text = "Melee Weapon";
                    option2Output.Text = "Long Range Weapon";
                    break;
                case 17:
                    soundEffectPlayer = new SoundPlayer(Properties.Resources.slime);
                    soundEffectPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.slime_monster;

                    storyOutput.Text = "The tunnel leads to a room, in the centre is a large green monster. How will you attack?";
                    option1Output.Text = "Melee Weapon";
                    option2Output.Text = "Long Range Weapon";

                    imageOutput.Refresh();
                    storyOutput.Refresh();
                    option1Output.Refresh();
                    option2Output.Refresh();
                    Thread.Sleep(1000);

                    bgmusicPlayer.Play();
                    break;
                case 18:
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    nextButton.Visible = true;

                    imageOutput.BackgroundImage = Properties.Resources.armoured_dwarf;

                    storyOutput.Text = $"You draw your {meleeWeapon} and attack. The dwarf swings it's ax at you but only manages to clip you before you land a killing blow. Then you continue through the next tunnel.";
                    option1Output.Text = "";
                    option2Output.Text = "";

                    health--;
                    HealthCheck();
                    break;
                case 19:
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    nextButton.Visible = true;

                    imageOutput.BackgroundImage = Properties.Resources.armoured_dwarf;

                    storyOutput.Text = $"You attack with your {rangeWeapon}, but the dwarf's armor partially protects it. It attacks you before dying, leaving you injured but alive as you continue through the next tunnel.";
                    option1Output.Text = "";
                    option2Output.Text = "";

                    if (rangeWeapon == "daggers") { health -= 2; }
                    else { health -= 3; }
                    HealthCheck();
                    break;
                case 20:
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    nextButton.Visible = true;

                    imageOutput.BackgroundImage = Properties.Resources.slime_monster;

                    storyOutput.Text = $"You pierce the monster with your {meleeWeapon}, it explodes and your arms are burned by a slimy substance. After wiping it off quickly you continue through another tunnel.";
                    option1Output.Text = "";
                    option2Output.Text = "";

                    if (meleeWeapon == "polearm") { health -= 2; }
                    else { health -= 3; }
                    HealthCheck();
                    break;
                case 21:
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    nextButton.Visible = true;

                    imageOutput.BackgroundImage = Properties.Resources.slime_monster;

                    storyOutput.Text = "You attack the monster from a distance so when it explodes you are left with only some minor burns as you continue through another tunnel.";
                    option1Output.Text = "";
                    option2Output.Text = "";

                    health--;
                    HealthCheck();
                    break;
                case 22:
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    nextButton.Visible = false;
                    option3Button.Visible = true;
                    option3Output.Visible = true;
                                        
                    soundEffectPlayer = new SoundPlayer(Properties.Resources.dragon_growl);
                    soundEffectPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.dragon_treasure;

                    storyOutput.Text = "You enter a large cavern filled with gold and riches, however there is a huge red dragon guarding it all.";
                    option1Output.Text = "Speak to the Dragon";
                    option2Output.Text = "Attack Long";
                    option3Output.Text = "Attack Melee";
                    break;
                case 23:
                    option3Button.Visible = false;
                    option3Output.Visible = false;

                    soundEffectPlayer = new SoundPlayer(Properties.Resources.dragon_breathe_fire);
                    soundEffectPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.angry_dragon;

                    storyOutput.Text = "Really? Everyone knows dragons don't converse with theives. The dragon obliterates you where you stand, so close to such riches, how sad. Play again?";
                    option1Output.Text = "Yes";
                    option2Output.Text = "No";
                    break;
                case 24:
                    option3Button.Visible = false;
                    option3Output.Visible = false;

                    soundEffectPlayer = new SoundPlayer(Properties.Resources.victory_fanfare);
                    soundEffectPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.treasure;

                    storyOutput.Text = "Congratulations, you have acheived your goal and obtained a great fortune!";

                    if (tunnelMap == false)
                    {
                        storyOutput.Text += " Unfortunately, you have forgotten the way out so goodluck living to spend it. Play again?";                        
                    }
                    else
                    {
                        storyOutput.Text += " Using the map you navigate your way out of the mountain and return home with your spoils. Play again?";
                    }

                    option1Output.Text = "Yes";
                    option2Output.Text = "No";
                    break;
                case 25:
                    option3Button.Visible = false;
                    option3Output.Visible = false;

                    imageOutput.BackgroundImage = Properties.Resources.angry_dragon;

                    storyOutput.Text = "Your attack fails and the dragon becomes angered.";
                    option1Output.Text = "Surrender";
                    option2Output.Text = "Attack again";

                    health -= 2;
                    HealthCheck();
                    break;
                case 26:
                    soundEffectPlayer = new SoundPlayer(Properties.Resources.dragon_breathe_fire);
                    soundEffectPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.angry_dragon;

                    storyOutput.Text = "I'm sorry, really? You just attacked the thing? The dragon cares nothing for your surrenders and you are engulfed by fire. Too bad you're not fireproof. Play again?";
                    option1Output.Text = "Yes";
                    option2Output.Text = "No";
                    break;
                case 27:
                    soundEffectPlayer = new SoundPlayer(Properties.Resources.victory_fanfare);
                    soundEffectPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.treasure;

                    storyOutput.Text = "Congratulations, you're very lucky to be alive, but you have acheived your goal and obtained a great fortune!";

                    if (tunnelMap == false)
                    {
                        storyOutput.Text += " Unfortunately, you have forgotten the way out so goodluck living to spend it. Play again?";
                    }
                    else
                    {
                        storyOutput.Text += " Using the map you navigate your way out of the mountain and return home with your spoils. Play again?";                        
                    }

                    option1Output.Text = "Yes";
                    option2Output.Text = "No";
                    break;
                // Glory Storyline
                case 28:
                    option3Button.Visible = false;
                    option3Output.Visible = false;

                    imageOutput.BackgroundImage = Properties.Resources.glory_map;

                    storyOutput.Text = "In the south there is village terrorized by a monster in the nearby forest. Would you like to enbark on this quest?";
                    option1Output.Text = "Yes";
                    option2Output.Text = "No";
                    break;
                case 29:
                    titleLabel.Text = "A Quest for Glory";

                    bgmusicPlayer = new SoundPlayer(Properties.Resources.background_music);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.forest_edge;

                    storyOutput.Text = "You travel to a small town and are directed to the forest, the villagers wish you luck. How will you enter the forest?";
                    option1Output.Text = "Climb to the treetops";
                    option2Output.Text = "Travel on ground";
                    break;
                case 30:
                    bgmusicPlayer = new SoundPlayer(Properties.Resources.battle_music);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.monkey_moster;

                    storyOutput.Text = "While traveling from branch to branch you encounter a monkey-like monster, its eyes wild as it charges you. How will you attack?";
                    option1Output.Text = "Long Range Weapon";
                    option2Output.Text = "Melee Weapon";
                    break;
                case 31:
                    soundEffectPlayer = new SoundPlayer(Properties.Resources.bear_growl);
                    soundEffectPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.bear_monster;

                    storyOutput.Text = "While traveling through the forest you encounter a bear-like monster, a growl growing in its throat as it begins to swipe at you. How will you attack?";
                    option1Output.Text = "Long Range Weapon";
                    option2Output.Text = "Melee Weapon";

                    imageOutput.Refresh();
                    storyOutput.Refresh();
                    option1Output.Refresh();
                    option2Output.Refresh();
                    Thread.Sleep(2000);

                    bgmusicPlayer = new SoundPlayer(Properties.Resources.battle_music);
                    bgmusicPlayer.Play();
                    break;
                case 32:
                    bgmusicPlayer = new SoundPlayer(Properties.Resources.creepy_music);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.tree_spirit;

                    storyOutput.Text = "Slightly wounded, you continue on in the treetops until a tree spirit stops you in your tracks.";
                    option1Output.Text = "Attack";
                    option2Output.Text = "Talk";

                    health--;
                    HealthCheck();
                    break;
                case 33:
                    bgmusicPlayer = new SoundPlayer(Properties.Resources.piano_melody);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.forest_pond;

                    storyOutput.Text = "The monkey knocks you out of the treetops as it dies and you land hard on the ground. Beside you is a faintly glowing pond, a spirit floating in the middle.";
                    option1Output.Text = "Attack";
                    option2Output.Text = "Talk";

                    if (meleeWeapon == "sword") { health--; }
                    else { health -= 2; }
                    HealthCheck();
                    break;
                case 34:
                    bgmusicPlayer = new SoundPlayer(Properties.Resources.piano_melody);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.forest_pond;

                    storyOutput.Text = "After defeating the monster, you continue on until you reach a faintly glowing  pond, a spirit floating in the middle.";
                    option1Output.Text = "Attack";
                    option2Output.Text = "Talk";

                    if (rangeWeapon == "daggers") { health--; }
                    else { health -= 2; }
                    HealthCheck();
                    break;
                case 35:
                    bgmusicPlayer = new SoundPlayer(Properties.Resources.piano_melody);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.forest_pond;

                    storyOutput.Text = "After defeating the monster, you continue on until you reach a faintly glowing pond, a spirit floating in the middle.";
                    option1Output.Text = "Attack";
                    option2Output.Text = "Talk";

                    health--;
                    HealthCheck();
                    break;
                case 36:
                    bgmusicPlayer = new SoundPlayer(Properties.Resources.piano_melody);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.forest_pond;

                    storyOutput.Text = "You injure the spirit but knocks you from the treetops and you fall to the ground. Beside you is a faintly glowing pond, a spirit floating in the middle.";
                    option1Output.Text = "Attack";
                    option2Output.Text = "Talk";

                    health -= 2;
                    HealthCheck();
                    break;
                case 37:
                    bgmusicPlayer = new SoundPlayer(Properties.Resources.piano_melody);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.forest_pond;

                    storyOutput.Text = "You tell the spirit you are here to defeat the evil spirit, it smirks and suggests you visit the pond spirit just through the trees. You climb down and find a faintly glowing pond, a spirit floating in the middle.";
                    option1Output.Text = "Attack";
                    option2Output.Text = "Talk";
                    break;
                case 38:
                    option3Button.Visible = true;
                    option3Output.Visible = true;

                    bgmusicPlayer = new SoundPlayer(Properties.Resources.forest_sound_1);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.thorns;

                    storyOutput.Text = "You attack the pond spirit but it drags you underwater, you barely fight it off but manage to resurface. You continue on until you reach a wall of torns.";
                    option1Output.Text = "Climb Over";
                    option2Output.Text = "Cut Through";
                    option3Output.Text = "Go Around";

                    health -= 2;
                    HealthCheck();
                    break;
                case 39:
                    option3Button.Visible = true;
                    option3Output.Visible = true;
                    spiritWater = true;

                    bgmusicPlayer = new SoundPlayer(Properties.Resources.forest_sound_1);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.thorns;

                    storyOutput.Text = "You explain your intentions of defeating the evil spirit and the water spirit gives you a glowing vial, for a price, and sends you on your way. Eventually, you come across a wall of torns.";
                    option1Output.Text = "Climb Over";
                    option2Output.Text = "Cut Through";
                    option3Output.Text = "Go Around";

                    health--;
                    HealthCheck();
                    break;
                case 40:
                    option3Button.Visible = true;
                    option3Output.Visible = true;

                    bgmusicPlayer = new SoundPlayer(Properties.Resources.forest_sound_1);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.thorns;

                    storyOutput.Text = "You attack the pond spirit but it drags you underwater, you barely fight it off but manage to resurface. You continue on until you reach a wall of torns.";
                    option1Output.Text = "Climb Over";
                    option2Output.Text = "Cut Through";
                    option3Output.Text = "Go Around";

                    health -= 2;
                    HealthCheck();
                    break;
                case 41:
                    option3Button.Visible = true;
                    option3Output.Visible = true;
                    spiritWater = true;

                    bgmusicPlayer = new SoundPlayer(Properties.Resources.forest_sound_1);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.thorns;

                    storyOutput.Text = "You explain your intentions of defeating the evil spirit and the water spirit gives you a glowing vial, for a price, and sends you on your way. Eventually, you come across a wall of torns.";
                    option1Output.Text = "Climb Over";
                    option2Output.Text = "Cut Through";
                    option3Output.Text = "Go Around";

                    health--;
                    HealthCheck();
                    break;
                case 42:
                    bgmusicPlayer = new SoundPlayer(Properties.Resources.final_battle_music);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.evil_spirit;

                    storyOutput.Text = "You climb over the torns, falling often and getting very scratched up. On the other side, you face the evil spirit.";
                    option1Output.Text = "Attack Melee";
                    option2Output.Text = "Attack Long";
                    option3Output.Text = "Talk";

                    health -= 2;
                    HealthCheck();
                    break;
                case 43:
                    bgmusicPlayer = new SoundPlayer(Properties.Resources.final_battle_music);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.evil_spirit;

                    storyOutput.Text = "You cut through the torns but they grow back behind you and you get very scratched up. On the other side, you face the evil spirit.";
                    option1Output.Text = "Attack Melee";
                    option2Output.Text = "Attack Long";
                    option3Output.Text = "Talk";

                    health -= 2;
                    HealthCheck();
                    break;
                case 44:
                    bgmusicPlayer = new SoundPlayer(Properties.Resources.final_battle_music);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.evil_spirit;

                    storyOutput.Text = "It takes a while, but eventually you find an opening just large enough for you to navigate through and obtain only minor injuries. On the other side, you face the evil spirit.";
                    option1Output.Text = "Attack Melee";
                    option2Output.Text = "Attack Long";
                    option3Output.Text = "Talk";

                    health--;
                    HealthCheck();
                    break;
                case 45:
                    option3Button.Visible = false;
                    option3Output.Visible = false;

                    imageOutput.BackgroundImage = Properties.Resources.evil_spirit;

                    storyOutput.Text = $"You attack with your {meleeWeapon}. The spirit is injured but attacks you, controlling forest around you.";
                    option1Output.Text = "Attack Again";
                    if (spiritWater == true) { option2Output.Text = "Throw Vial"; }
                    else
                    {
                        option2Button.Visible = false;
                        option2Output.Text = "";
                    }

                    if (meleeWeapon == "sword") { health -= 2; }
                    else { health--; }
                    HealthCheck();
                    break;
                case 46:
                    option3Button.Visible = false;
                    option3Output.Visible = false;

                    imageOutput.BackgroundImage = Properties.Resources.evil_spirit;

                    storyOutput.Text = "You attack from a distance. The spirit is injured but attacks you, controlling forest around you, you are lucky to be far enough away that the attack weakens before hitting you.";
                    option1Output.Text = "Attack Again";
                    if (spiritWater == true) { option2Output.Text = "Throw Vial"; }
                    else
                    {
                        option2Button.Visible = false;
                        option2Output.Text = "";
                    }

                    health--;
                    HealthCheck();
                    break;
                case 47:
                    option3Button.Visible = false;
                    option3Output.Visible = false;

                    imageOutput.BackgroundImage = Properties.Resources.evil_spirit;

                    storyOutput.Text = "You attempt to converse with the spirit but does not respond and attacks you, controlling forest around you. However, you notice that it seems to glow the same way as the water in the pond.";
                    option1Output.Text = "Attack Again";
                    if (spiritWater == true) { option2Output.Text = "Throw Vial"; }
                    else
                    {
                        option2Button.Visible = false;
                        option2Output.Text = "";
                    }

                    health--;
                    HealthCheck();
                    break;
                case 48:
                    option2Button.Visible = true;

                    bgmusicPlayer = new SoundPlayer(Properties.Resources.sad_music);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.gravestone;

                    storyOutput.Text = "Unfortunately, you fail to deafeat the evil spirit and become yet another of it's victims. So much for glory. Play again?";
                    option1Output.Text = "Yes";
                    option2Output.Text = "No";
                    break;
                case 49:                    
                    imageOutput.BackgroundImage = Properties.Resources.evil_spirit;

                    storyOutput.Text = "You attack and the spirit collapses and begins to die.";
                    option1Output.Text = "Return To Village";
                    if (spiritWater == true) 
                    {
                        option2Button.Visible = true;
                        option2Output.Text = "Give Vial"; 
                    }
                    else
                    {
                        option2Button.Visible = false;
                        option2Output.Text = "";
                    }
                    break;
                case 50:
                    option2Button.Visible = true;

                    bgmusicPlayer = new SoundPlayer(Properties.Resources.purify);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.purified_spirit;

                    storyOutput.Text = "You throw the vial at the evil spirit and it shatters, spilling its contents all over the spirit. A shell falls off of the spirit and the forest become brighter. You return to the village a hero, song will be sung and your story will be told forever. Play again?";
                    option1Output.Text = "Yes";
                    option2Output.Text = "No";
                    break;
                case 51:
                    option2Button.Visible = true;

                    bgmusicPlayer = new SoundPlayer(Properties.Resources.foreboding_music);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.dying_forest;

                    storyOutput.Text = "You leave the dying spirit and return to the village. They celebrate your return and you seem to be a hero, but over time the forest begins to die and everything around dies along with it, what did you miss? Play again?";
                    option1Output.Text = "Yes";
                    option2Output.Text = "No";
                    break;
                case 52:
                    option2Button.Visible = true;

                    bgmusicPlayer = new SoundPlayer(Properties.Resources.purify);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.purified_spirit;

                    storyOutput.Text = "You give the vial to the dying the evil spirit and it splashes the contents all over itseld. A shell falls off of the spirit and the forest become brighter. You return to the village a hero, song will be sung and your story will be told forever. Play again?";
                    option1Output.Text = "Yes";
                    option2Output.Text = "No";
                    break;
                // Revenge Storyline
                case 53:
                    option3Button.Visible = false;
                    option3Output.Visible = false;

                    imageOutput.BackgroundImage = Properties.Resources.revenge_map;

                    storyOutput.Text = "Many years ago a lord from the North raided your hometown and killed your parents, today you are finally ready to seek your renvenge. Would you like to enbark on this quest?";
                    option1Output.Text = "Yes";
                    option2Output.Text = "No";
                    break;
                case 54:
                    titleLabel.Text = "A Quest for Revenge";
                    option3Button.Visible = true;
                    option3Output.Visible = true;

                    bgmusicPlayer = new SoundPlayer(Properties.Resources.dramatic_music_start);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.city_gates;

                    storyOutput.Text = "You travel to the city of the lord, there is a huge wall surrounding the city and the gates are heavily guarded. However, you've spent years gathering information and you know of a possible secret entrance. How will you enter the city?";
                    option1Output.Text = "Search for Secret Entrance";
                    option2Output.Text = "Scale the Wall";
                    option3Output.Text = "Trick Guards at Main Entrance";
                    break;
                case 55:
                    option3Button.Visible = false;
                    option3Output.Visible = false;

                    bgmusicPlayer = new SoundPlayer(Properties.Resources.suspenceful_music);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.dungeon_open_door;

                    storyOutput.Text = "You find the entrance and enter through a tunnel, eventually the tunnel end and you exit into what appears to be the dungeons. Only one cell is occupied, a young boy sits inside. The keys hang on the opposite wall and the guards at the end of the hall seem distracted for now.";
                    option1Output.Text = "Let the Boy out";
                    option2Output.Text = "Sneak by Guards";
                    break;
                case 56:
                    option3Button.Visible = false;
                    option3Output.Visible = false;

                    bgmusicPlayer = new SoundPlayer(Properties.Resources.suspenceful_music);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.dungeon;

                    storyOutput.Text = "You scale the wall, but as soon as you reach the top you are spotted by the many soldiers guarding the top of the wall, you don't even have a chance to fight back before you are captured and jailed. How do you escape your cell?";
                    option1Output.Text = "Pick the Lock";
                    option2Output.Text = "Bribe a Guard";

                    health--;
                    HealthCheck();
                    break;
                case 57:
                    option3Button.Visible = false;
                    option3Output.Visible = false;

                    bgmusicPlayer = new SoundPlayer(Properties.Resources.suspenceful_music);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.dungeon;

                    storyOutput.Text = "You attempt to trick the guards at the main entrance into letting you in but they find you suspicious and decide to keep you in the dungeons until your story can be verified. How do you escape your cell?";
                    option1Output.Text = "Pick the Lock";
                    option2Output.Text = "Bribe a Guard";

                    health--;
                    HealthCheck();
                    break;
                case 58:
                    imageOutput.BackgroundImage = Properties.Resources.dungeon_open_door;

                    storyOutput.Text = "You pick the lock quietly while the guards backs are turned and exit your cell. You notice that only one other cell is occupied, a young boy sits inside, the keys hang on the opposite wall.";
                    option1Output.Text = "Let the Boy out";
                    option2Output.Text = "Sneak by Guards";
                    break;
                case 59:
                    imageOutput.BackgroundImage = Properties.Resources.dungeon_open_door;

                    storyOutput.Text = "The guard opens the door for you, but you don't actually have any gold so you have no choice but to kill the guards before they can throw you back in your cell. Once the guards are all down, you notice that only one other cell is occupied, a young boy sits inside, the keys hang on the opposite wall.";
                    option1Output.Text = "Let the Boy out";
                    option2Output.Text = "Leave the Dungeon";

                    health -= 2;
                    HealthCheck();
                    break;
                case 60:
                    bgmusicPlayer = new SoundPlayer(Properties.Resources.foreboding_music);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.city_stairs;

                    storyOutput.Text = "You turn your back on the boy and attempt to sneak by the guards, but the boy, obviously upset at being left behind, shouts out and the guards turn. You deafeat them, to the boys dismay, and leave the dungeon. Once you leave the dungeon you enter an intersection.";
                    option1Output.Text = "Left";
                    option2Output.Text = "Right";

                    health -= 2;
                    HealthCheck();
                    break;
                case 61:
                    littleBoy = true;

                    bgmusicPlayer = new SoundPlayer(Properties.Resources.foreboding_music);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.city_stairs;

                    storyOutput.Text = "You grab the keys and let the boy out, he thanks you quietly and then you both sneak past the guards. After extiting the dungeon, you split up and you enter an intersection.";
                    option1Output.Text = "Left";
                    option2Output.Text = "Right";
                    break;
                case 62:
                    bgmusicPlayer = new SoundPlayer(Properties.Resources.foreboding_music);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.city_stairs;

                    storyOutput.Text = "You turn your back on the boy and leave the dungeon, the boy shouting after you but theres no one to hear him. Once you leave the dungeon you enter an intersection.";
                    option1Output.Text = "Left";
                    option2Output.Text = "Right";
                    break;
                case 63:
                    imageOutput.BackgroundImage = Properties.Resources.dead_end;

                    storyOutput.Text = "The right hallway leads to a dead end with guards patrolling, luckily they currently have their backs turned.";
                    option1Output.Text = "Turn Around";
                    option2Output.Text = "Attack Them";
                    break;
                case 64:
                    bgmusicPlayer = new SoundPlayer(Properties.Resources.battle_music_2);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.throne_door;

                    storyOutput.Text = "The left hallway leads to a fancy door, it's heavily guarded which means its clearly an important room, likely where the lord resides.";
                    option1Output.Text = "Attack Melee";
                    option2Output.Text = "Attack Long";
                    break;
                case 65:
                    bgmusicPlayer = new SoundPlayer(Properties.Resources.battle_music_2);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.throne_door;

                    storyOutput.Text = "You slip back and down the other halway unnoticed. The other hallway leads to a fancy door, heavily guarded so likely an important room, possibly where the lord resides.";
                    option1Output.Text = "Attack Melee";
                    option2Output.Text = "Attack Long";
                    break;
                case 66:
                    bgmusicPlayer = new SoundPlayer(Properties.Resources.battle_music_2);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.throne_door;

                    storyOutput.Text = "You attack the guards, finishing them off rather quickly and then turn around and go down the other halway. The other hallway leads to a fancy door, heavily guarded so likely an important room, possibly where the lord resides.";
                    option1Output.Text = "Attack Melee";
                    option2Output.Text = "Attack Long";

                    health -= 2;
                    HealthCheck();
                    break;
                case 67:
                    imageOutput.BackgroundImage = Properties.Resources.throne_room;

                    storyOutput.Text = "You charge the guards at the door, cutting through them one by one until no one stands between you and the door. You enter a large room with a throne on the opposite side of the room. The lord sits on the throne, more guards stationed around the room.";
                    option1Output.Text = $"Attack Lord with {rangeWeapon}";
                    option2Output.Text = "Talk";

                    health -= 2;
                    HealthCheck();
                    break;
                case 68:
                    imageOutput.BackgroundImage = Properties.Resources.throne_room;

                    storyOutput.Text = "You kill many of the guards from a distance and then finish off the last of them so that no one stands between you and the door. You enter a large room with a throne on the opposite side of the room. The lord sits on the throne, more guards stationed around the room.";
                    option1Output.Text = $"Attack Lord with {rangeWeapon}";
                    option2Output.Text = "Talk";

                    health--;
                    HealthCheck();
                    break;
                case 69:
                    imageOutput.BackgroundImage = Properties.Resources.throne_room;

                    storyOutput.Text = "You shout to the lord and tell him why you have come to kill him, you are here to take revenge for your parents. However, before you can talk for more than a couple seconds the guards attack you and you are preoccupied with taking them all down. Once you do though, you turn your attention back to the lord.";
                    option1Output.Text = $"Attack Lord with {rangeWeapon}";
                    option2Output.Text = "Talk";

                    health -= 2;
                    HealthCheck();
                    break;
                case 70:
                    imageOutput.BackgroundImage = Properties.Resources.throne_room;

                    storyOutput.Text = "You draw your long range weapon and attack the lord, it sails over the guards and pierces the lord's heart, a perfect shot. The guards are bewildered and many turn and run to the dying lord.";
                    if (littleBoy == true)
                    {
                        storyOutput.Text += " The little boy from the dungeon opens a secret passage in a nearby wall, he ushers you through and leads you out of the city. You have finally gotten your revenge and now you are free. Play again?";
                    }
                    else
                    {
                        storyOutput.Text += " After all those years you have finally gotten your revenge but the throne room is soon flooded with guards that drag you to the dungeons, although they have no leader your execution is sure to be soon. Play again?";
                    }
                    option1Output.Text = "Yes";
                    option2Output.Text = "No";
                    break;
                case 71:
                    imageOutput.BackgroundImage = Properties.Resources.throne_room;

                    storyOutput.Text = "You attempt a long range attack but the lord moves at the last second and it misses the heart. The guards around the room jump into action and your focus becomes taking each of them down before you are able to turn back to the lord.";
                    option1Output.Text = "Attack Melee";
                    option2Output.Text = "Attack Long";

                    health -= 2;
                    HealthCheck();
                    break;
                case 72:
                    imageOutput.BackgroundImage = Properties.Resources.throne_room;

                    storyOutput.Text = "You finish off the guards and sprint across the room to the throne, focused on the lord, but you missed a guard and just as you reach the lord, the last standing guard kills you. It seems the lord will not pay for his transgressions quite yet. Play again?";
                    option1Output.Text = "Yes";
                    option2Output.Text = "No";
                    break;
                case 73:
                    imageOutput.BackgroundImage = Properties.Resources.throne_room;

                    storyOutput.Text = $"You finish off the guards and sprint across the room to the throne, focused on the lord. The lords eyes widen in shock as you run him through with your {meleeWeapon}, 'For my parents' you say.";
                    if (littleBoy == true)
                    {
                        storyOutput.Text += " The little boy from the dungeon opens a secret passage in a nearby wall, he ushers you through and leads you out of the city. You have finally gotten your revenge and now you are free. Play again?";
                    }
                    else
                    {
                        storyOutput.Text += " After all those years you have finally gotten your revenge but the throne room is soon flooded with guards that drag you to the dungeons, although they have no leader your execution is sure to be soon. Play again?";
                    }
                    option1Output.Text = "Yes";
                    option2Output.Text = "No";
                    break;
                case 74:
                    imageOutput.BackgroundImage = Properties.Resources.throne_room;

                    storyOutput.Text = "You attempt a range attack now that the guards are out of the way, but you're weakened from the fighting and you miss again. You can hear rienforcements coming, you will soon be overwhelmed.";
                    option1Output.Text = "Attack";
                    option2Output.Text = "Surender";

                    health--;
                    HealthCheck();
                    break;
                case 75:
                    imageOutput.BackgroundImage = Properties.Resources.throne_room;

                    storyOutput.Text = "You draw your long range weapon and attack the lord, it sails over the guards and pierces the lord's heart, a perfect shot despite your weakened state.";
                    if (littleBoy == true)
                    {
                        storyOutput.Text += " The little boy from the dungeon opens a secret passage in a nearby wall, he ushers you through and leads you out of the city. You have finally gotten your revenge and now you are free. Play again?";
                    }
                    else
                    {
                        storyOutput.Text += " After all those years you have finally gotten your revenge but the throne room is soon flooded with guards that drag you to the dungeons, although they have no leader your execution is sure to be soon. Play again?";
                    }
                    option1Output.Text = "Yes";
                    option2Output.Text = "No";
                    break;
                case 76:
                    imageOutput.BackgroundImage = Properties.Resources.throne_room;

                    storyOutput.Text = $"You attempt one last attack, rushing the lord with your {meleeWeapon}. But the rienforcements reach the throne room before you can get to the lord and they take you down before you can get your revenge. Play again?";
                    option1Output.Text = "Yes";
                    option2Output.Text = "No";
                    break;
                case 77:
                    imageOutput.BackgroundImage = Properties.Resources.throne_room;

                    storyOutput.Text = $"You attempt one last attack, rushing the lord with your {meleeWeapon}. The lords eyes widen in shock as you run him through, 'For my parents' you say.";
                    if (littleBoy == true)
                    {
                        storyOutput.Text += " The little boy from the dungeon opens a secret passage in a nearby wall, he ushers you through and leads you out of the city. You have finally gotten your revenge and now you are free. Play again?";
                    }
                    else
                    {
                        storyOutput.Text += " After all those years you have finally gotten your revenge but the throne room is soon flooded with guards that drag you to the dungeons, although they have no leader your execution is sure to be soon. Play again?";
                    }
                    option1Output.Text = "Yes";
                    option2Output.Text = "No";
                    break;
                case 78:
                    imageOutput.BackgroundImage = Properties.Resources.throne_room;

                    storyOutput.Text = "You turn towards the doors and drop your weapons as hundreds of guard flood through. The lord decends from the throne and approaches you. 'Good try' the lord chuckles and fells you where you stand. Did you really expect mercy? Play again?";
                    option1Output.Text = "Yes";
                    option2Output.Text = "No";
                    break;
                case 98:
                    bgmusicPlayer = new SoundPlayer(Properties.Resources.sad_music);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.gravestone;

                    storyOutput.Text = "Unfortunately, you have succumbed to your wounds and died before completing your quest. Your skeleton shall be a warning to others attempting this quest. Play again?";

                    option1Output.Text = "Yes";
                    option2Output.Text = "No";
                    break;
                case 99:
                    mapImageOutput.Visible = false;
                    option1Button.Visible = false;
                    option1Output.Visible = false;
                    option2Button.Visible = false;
                    option2Output.Visible = false;
                    healthOutput.Visible = false;

                    bgmusicPlayer = new SoundPlayer(Properties.Resources.symphony_sounds);
                    bgmusicPlayer.Play();

                    imageOutput.BackgroundImage = Properties.Resources.start_hut;

                    titleLabel.Text = "Thank you for playing!";
                    storyOutput.Text = "";
                    Refresh();

                    Thread.Sleep(3000);

                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        public void HealthCheck() //if health = 0, common end page for health death
        {
            if (health <= 0)
            {
                page = 98;
                DisplayPage();
            }
            else
            {
                healthOutput.Text = $"Health: {health}";
            }
        }
    }
}
