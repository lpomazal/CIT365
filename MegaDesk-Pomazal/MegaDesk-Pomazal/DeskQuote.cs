using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Pomazal
{
    internal class DeskQuote
    {
        public Desk Desk = new Desk();
        public int quoteAmount;
        public int rushAmt;
        
        private const int basePrice = 200;
        private const int surfaceAreaMin = 1000;
        //cost per area charges extra after 1000sqInch
        private const int costPerDrawer = 50;
        private const int costPerArea = 1; 
        public int surfaceArea = Desk.deskWidth * Desk.deskHeight;
        //area over charge for inches over surfaceAreaMin

        public DeskQuote(Desk.surfaceMaterial surfaceMaterial, string customerName, int rushAmt, int height, int width, int numDrawers,int surfaceArea, Desk desk)
        {
            Desk.customerName = customerName;
            Desk.deskHeight = height;
            Desk.deskWidth = width;
            Desk.surfaceMaterial = surfaceMaterial;
            Desk.numDrawers = numDrawers;
            this.rushAmt = rushAmt;
            Desk.surfaceArea = surfaceArea;
            
            
        }
        public int calQuoteCost()
        {
            quoteAmount = basePrice + areaCost() + drawerCost() + TotalRushCost(rushAmt, surfaceArea) + surfaceMaterial;
            return quoteAmount;
        }
        private int areaCost()
        {
            if (Desk.surfaceArea > surfaceAreaMin)
            {
                return (Desk.surfaceArea - surfaceAreaMin) * costPerArea;
            }
            else
            {
                return 0;
            }

        }
        private int drawerCost()
        {
            int drawerCost = Desk.numDrawers * costPerDrawer;
            return drawerCost;
        }
        static int TotalRushCost(int rushAmt, int surfaceArea)
        {   
            int multiplier;
            if (surfaceArea <= 1000) multiplier = 0;
            else if (surfaceArea <= 2000) multiplier = 1;
            else multiplier = 2;

            switch (rushAmt)
            {
                case 3:
                    return  60 + multiplier * 10;
                case 5:
                    return 40 + multiplier * 10;
                    
                case 7:
                    return 30 + multiplier * 5;
                   
                default:
                    return 0;
            }
            
        }

}
