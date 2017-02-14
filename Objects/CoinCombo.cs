using System.Collections.Generic;
using System;

namespace CoinCombo
{
    public class Coin
    {
        private int _input;

        public int GetInput()
        {
            return _input;
        }
        public void SetInput(int Input)
        {
            _input = Input;
        }

        public string CoinCount()
        {
            string Quar = "";
            string Dime = "";
            string Nick = "";
            string Penn = "";

            string result = "";

            int QuarterCount;
            int DimeCount;
            int NickelCount;
            int PennieCount;

            QuarterCount = GetInput() / 25;
            DimeCount = (GetInput() - (QuarterCount * 25)) / 10;
            NickelCount = (GetInput() - (QuarterCount * 25) - (DimeCount * 10)) / 5;
            PennieCount = GetInput() - (QuarterCount * 25) - (DimeCount * 10) - (NickelCount * 5);

            Quar = QuarterCount + " Quarters ";
            Dime = DimeCount + " Dimes ";
            Nick = NickelCount + " Nickels ";
            Penn = PennieCount + " Pennies ";

            if (QuarterCount == 0)
            {
                Quar = "";
            }
            if (DimeCount == 0)
            {
                Dime = "";
            }
            if (NickelCount == 0)
            {
                Nick = "";
            }
            if (PennieCount == 0)
            {
                Penn = "";
            }

            result = Quar + Dime + Nick + Penn;
            Console.WriteLine(result);
            return result;
        }
    }
}
