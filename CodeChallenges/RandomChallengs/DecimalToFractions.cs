using System;

namespace CodeChallenges.RandomChallengs
{
    public class DecimalToFractions
    {
        public static string Fractional(decimal originalValue)
        {
            var roundedResult = new decimal();

            //split value into main and decimal
            string[] values = originalValue.ToString("0.00").Split('.');
            int valueSplit = Convert.ToInt32(values[0]);

            //round decimal to nearest
            try
            {
                var decimalSplit = Convert.ToDecimal(values[1]) / 100;
                roundedResult = (decimal.Round(decimalSplit * 4, MidpointRounding.ToEven) / 4);
            }
            catch (IndexOutOfRangeException)
            {
                //just to allow for no action to happen when a whole number is returned
            }

            //switch based on value
            string fractionValue = string.Empty;
            switch (roundedResult)
            {
                case 0.25M:
                    fractionValue = "1/4";
                    break;
                case 0.50M:
                    fractionValue = "2/4";
                    break;
                case 0.75M:
                    fractionValue = "3/4";
                    break;
                case 1:
                    valueSplit++;
                    break;
            }

            //combine and return
            string result;
            if (valueSplit.Equals(0) && !roundedResult.Equals(0))
                result = fractionValue;
            else if (valueSplit.Equals(0) && roundedResult.Equals(0))
                result = "0";
            else if (!valueSplit.Equals(0) && roundedResult.Equals(1) || roundedResult.Equals(0))
                result = valueSplit.ToString();
            else
                result = valueSplit + " " + fractionValue;
            return result;
        }
    }
}