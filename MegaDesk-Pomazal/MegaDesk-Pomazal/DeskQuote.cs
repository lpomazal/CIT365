using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Pomazal
{
    namespace ShippingCost
    {
        internal class DeskQuote
        {
            private int rushAmt;
            private Desk desk;
            private const int basePrice = 200;
            private const int surfaceAreaMin = 1000;
            //cost per area charges extra after 1000sqInch
            private const int costPerDrawer = 50;
            private const int costPerArea = 1;
            private int surfaceArea;
            //area over charge for inches over surfaceAreaMin

            public DeskQuote(Desk desk, int shippingDays)
            {
                this.desk = desk;
                surfaceArea = desk.deskWidth * desk.deskHeight;
            }
            public int calQuoteCost()
            {
                var quoteAmount = basePrice + areaCost() + drawerCost() + TotalRushCost(rushAmt, surfaceArea) + (int)desk.selectedSurfaceMaterial;
                return quoteAmount;
            }
            private int areaCost()
            {
                if (surfaceArea > surfaceAreaMin)
                {
                    return (surfaceArea - surfaceAreaMin) * costPerArea;
                }
                else
                {
                    return 0;
                }

            }
            private int drawerCost()
            {
                int drawerCost = desk.numDrawers * costPerDrawer;
                return drawerCost;
            }
            private int TotalRushCost(int rushAmt, int surfaceArea)
            {
                int multiplier;
                if (surfaceArea <= 1000) multiplier = 0;
                else if (surfaceArea <= 2000) multiplier = 1;
                else multiplier = 2;

                switch (rushAmt)
                {
                    case 3:
                        return 60 + multiplier * 10;
                    case 5:
                        return 40 + multiplier * 10;

                    case 7:
                        return 30 + multiplier * 5;

                    default:
                        return 0;
                }

            }

        }
    }
}