﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tamagotchi.Actions;
using Tamagotchi.Interfaces;

namespace Tamagotchi.UI._6._Activities.Cleaning.CleaningKinds
{
    public class FaceWash:Cleansing, IClean
    {
        public FaceWash() 
        {
            cleanlinesslevelaffect = 2;
        }

        public void Clean()
        {
            Console.WriteLine("Your animal has been cleaned");
            MainUi.activitiesHistory.Add(new Activity(MainUi.p.Username, MainUi.a.Animalname, "Cleaning", "Skincare", MainUi.a.Age, MainUi.a.LifeCycle));
            MainUi.a.CleanlinessLevel += cleanlinesslevelaffect;
            if (MainUi.a.CleanlinessLevel > 5)
                MainUi.a.CleanlinessLevel = 5;
            Back();
        }
    }
}
