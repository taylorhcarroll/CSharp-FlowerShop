using System;
using System.Collections.Generic;

namespace flowershop
{
    class Program
    {
        static void Main(string[] args)
        {
            Rose rose1 = new Rose()
            {
                color = "red",
                name = "Rosey",
                type = "red rose",
                cost = 28.11,
                petalcount = 28,
                waterschedule = "whenever",
                thorny = true,
                fragrant = true
            };

            Sunflower flowey = new Sunflower()
            {
                color = "yellow",
                name = "flowey",
                type = "collosal sunflower",
                cost = 28.11,
                petalcount = 28,
                waterschedule = "whenever",
                thorny = true,
                fragrant = true,
            };

            Tulip tulip = new Tulip()
            {
                color = "yellow",
                name = "tip-toe",
                type = "common tulip",
                cost = 28.11,
                petalcount = 28,
                waterschedule = "whenever",
                thorny = true,
                fragrant = true,
                wild = true,
            };

            Snapdragon snappy = new Snapdragon()
            {
                color = "red",
                name = "snappy",
                type = "red snapdragon",
                cost = 28.11,
                petalcount = 28,
                waterschedule = "whenever",
                thorny = true,
                fragrant = true,
                wild = true,
            };

            FlowerShop JohnsFlowerShop = new FlowerShop();
            List<IBirthday> Arrangement1 = JohnsFlowerShop.MakeBirthdayArrangement();
            List<IMothersDay> Arrangement2 = JohnsFlowerShop.MakeMothersDayArrangement();
            List<IGetWell> Arrangement3 = JohnsFlowerShop.MakeGetWellArrangement();

        }
    }
}