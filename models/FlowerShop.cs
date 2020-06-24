using System;
using System.Collections.Generic;

namespace flowershop
{
    public class FlowerShop
    {
        public List<Rose> Roses = new List<Rose>();
        public List<Tulip> Tulips = new List<Tulip>();
        public List<Snapdragon> Snapdragons = new List<Snapdragon>();
        public List<Sunflower> Sunflower = new List<Sunflower>();
        public List<IMothersDay> MakeMothersDayArrangement()
        {
            List<IMothersDay> Arrangement = new List<IMothersDay>();
            Arrangement.Add(new Rose());
            Arrangement.Add(new Rose());
            Arrangement.Add(new Tulip());
            Arrangement.Add(new Tulip());
            //cannot add a snapdragon because it does not belong to IMothersDay interface

            return Arrangement;
        }
        public List<IBirthday> MakeBirthdayArrangement()
        {
            List<IBirthday> Arrangement = new List<IBirthday>();
            Arrangement.Add(new Snapdragon());
            Arrangement.Add(new Snapdragon());
            Arrangement.Add(new Sunflower());
            Arrangement.Add(new Sunflower());
            Arrangement.Add(new Rose());

            return Arrangement;
        }

        public List<IGetWell> MakeGetWellArrangement()
        {
            List<IGetWell> Arrangement = new List<IGetWell>();
            Arrangement.Add(new Orchid());
            Arrangement.Add(new Orchid());
            Arrangement.Add(new Orchid());

            return Arrangement;
        }
    }
}