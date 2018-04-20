using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningPolymorphismLongTaskV2._0
{


    public partial class Form1 : Form
    {
        Location currentLocation;
        Room dinningRoom;
        OutsideWithHidingPlace garden;
        RoomWithDoor kitchen;
        RoomWithDoor livingRoom;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Opponent hiddenOpponent;
        Room staircase;
        RoomWithHidingPlace corridor;
        RoomWithHidingPlace bigSleepingRoom;
        RoomWithHidingPlace secondSleepingRoom;
        RoomWithHidingPlace bathroom;
        OutsideWithHidingPlace driveway;
        public int stepsNeededToFindOpponent = 0;
        

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            checkButton.Visible = false;
            goThere.Visible = false;
            goThrough.Visible = false;
            exitsBox.Visible = false;

        }
        private void CreateObjects()
        {
            dinningRoom = new Room("Jadalnia", "solidny drewniany stół");
            garden = new OutsideWithHidingPlace("Ogród", false, "szopa z narzędziami");
            kitchen = new RoomWithDoor("Kuchnia", "masę doniczek z przyprawami","w szafce kuchennej", "drzwi dębowe z mosiężną klamką");
            livingRoom = new RoomWithDoor("Salon", "obraz z Cirillą z wiedźmina","za kanapą", "drzwi zasuwane");
            frontYard = new OutsideWithDoor("Podrówko przed domem", true, "drzwi dębowe z mosiążną klamką");
            backYard = new OutsideWithDoor("Podwórko za domem", false, "drzwi zasuwane");
            hiddenOpponent = new Opponent(frontYard);
            staircase = new Room("Klatka schodowa", "drewniana poręcz");
            corridor = new RoomWithHidingPlace("Korytarz na piętrze", "obrazek z psem", "szafa ścienna");
            bigSleepingRoom = new RoomWithHidingPlace("Duża sypialnia", "duże łóżko", "pod łóżkiem");
            secondSleepingRoom = new RoomWithHidingPlace("Druga sypialnia", "łóżko", "pod łóżkiem");
            bathroom = new RoomWithHidingPlace("Łazienka", "umywalka i toaleta", "pod prysznicem");
            driveway = new OutsideWithHidingPlace("Droga dojazdowa", true, "garaż");

            dinningRoom.Exits = new Location[] { kitchen, livingRoom, staircase };
            garden.Exits = new Location[] { frontYard, backYard };
            kitchen.Exits = new Location[] { dinningRoom };
            livingRoom.Exits = new Location[] { dinningRoom };
            frontYard.Exits = new Location[] { backYard, garden, driveway };
            backYard.Exits = new Location[] { frontYard, garden, driveway };
            staircase.Exits = new Location[] { dinningRoom, corridor };
            corridor.Exits = new Location[] { bigSleepingRoom, secondSleepingRoom, bathroom, staircase};
            bigSleepingRoom.Exits = new Location[] { corridor };
            secondSleepingRoom.Exits = new Location[] { corridor };
            bathroom.Exits = new Location[] { corridor };
            driveway.Exits = new Location[] { frontYard, backYard };


            backYard.DoorLocation = kitchen;
            kitchen.DoorLocation = backYard;
            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;


        }
        private void MoveToNewLocation(Location newLocation)
        {
            currentLocation = newLocation;
            exitsBox.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                exitsBox.Items.Add(currentLocation.Exits[i].Name);
            }
            exitsBox.SelectedIndex = 0;
            textBox1.Text = currentLocation.Description;
            if (currentLocation is IHasExteriorDoor)
            {
                goThrough.Visible = true;
            }
            else
            { 
                goThrough.Visible = false;
            }                    
        }
        private void ResetGame()
        {
            hiddenOpponent = null;
            hiddenOpponent = new Opponent(backYard);
            checkButton.Visible = false;
            goThere.Visible = false;
            goThrough.Visible = false;
            exitsBox.Visible = false;
            hideButton.Visible = true;
            currentLocation = livingRoom;
            stepsNeededToFindOpponent = 0;
            textBox1.Text = "";


        }
        private void RedrawForm()
        {
            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                checkButton.Text = "Sprawdź " + hidingPlace.HidingPlace;
            }
            else
            {
                checkButton.Text = "----";
            }
           
        }

        private void goThere_Click(object sender, EventArgs e)
        {
            MoveToNewLocation(currentLocation.Exits[exitsBox.SelectedIndex]);
            RedrawForm();
            stepsNeededToFindOpponent++;
        }

        private void goThrough_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToNewLocation(hasDoor.DoorLocation);
            stepsNeededToFindOpponent++;
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            hideButton.Visible = false;
            for (int i = 0; i <= 10; i++)
            {
                textBox1.Text +=   + i + "..." + "\r\n";
                hiddenOpponent.Move();
                System.Threading.Thread.Sleep(500);
                Application.DoEvents();
            }
            textBox1.Text += "Gotowy czy nie - nadchodzę!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(2000);
            checkButton.Visible = true;
            goThere.Visible = true;
            goThrough.Visible = true;
            exitsBox.Visible = true;
            MoveToNewLocation(livingRoom);
            
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            stepsNeededToFindOpponent++;
            if (hiddenOpponent.Check(currentLocation) && currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                MessageBox.Show("Odnalazłeś mnie! Byłem schowany w " + currentLocation.Name + " " + hidingPlace.HidingPlace + ". Potrzebowałeś na to " + stepsNeededToFindOpponent + " ruchów" );
                ResetGame();
            }
        }
    }
}
