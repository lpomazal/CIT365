using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Pomazal
{
   
        internal class DeskQuote
        {
            private int rushAmt;
            private Desk desk;
            private const int basePrice = 200;
            private const int surfaceAreaMin = 1000;
            private const int costPerDrawer = 50;
            private const int costPerArea = 1;
            private int? surfaceArea;


        public DeskQuote(Desk desk, int shippingDays)
            {
                this.desk = desk;
                surfaceArea = desk.deskWidth * desk.deskHeight;
                rushAmt = shippingDays;
            }

        public DeskQuote(Desk desk)
        {
            this.desk = desk;
        }

        public DeskQuoteResult CalQuoteCost()
            {
                var quoteAmount = basePrice + AreaCost() + DrawerCost() + TotalRushCost(rushAmt, surfaceArea??0) + (int)desk.selectedSurfaceMaterial;
            return new DeskQuoteResult {quoteAmount = quoteAmount, desk = desk, rushAmt = rushAmt };
                
            }
            private int? AreaCost()
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
            private int? DrawerCost()
            {
                var drawerCost = desk.numDrawers * costPerDrawer;
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
        public class DeskQuoteResult
        {
            public Desk desk;
            public int? quoteAmount { get; set; }
            public int rushAmt { get; set; }
        }
        }
    }
