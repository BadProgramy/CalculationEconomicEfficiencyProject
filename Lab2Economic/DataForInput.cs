using System.Collections;
using System.Collections.Generic;

namespace Lab2Economic
{
    public class DataForInput
    {
        public long startingInvestments { get; set; } = 1;//Стартовые инвестиции, IC:
        public long discountRate { get; set; } = 1;//Ставка дисконтирования, i:
        public long horizonOfCalculationOfTheProject { get; set; } = 1;//Горизонт расчета проекта (кол-во лет), n:
        public long[] inflowOfMeansInTheAllYears { get; set; } = { 1 };//Приток средств в 1-й год, DP1:
        public long[] outflowOfFundsInTheAllYears { get; set; } = { 1 };//Отток средств в 1-й год, Z1:


        public DataForInput()
        {

        }

        public List<Map> getData()
        {
            List<Map> ht = new List<Map>();

            ht.Add(new Map("Стартовые инвестиции, IC", startingInvestments));
            ht.Add(new Map("Ставка дисконтирования, i", discountRate));
            inflowOfMeansInTheAllYears = new long[horizonOfCalculationOfTheProject];
            for (int i = 0; i < horizonOfCalculationOfTheProject; i++)
            {
                ht.Add(new Map("Приток средств в " + (i + 1) + "-й год, DP" + (i + 1), inflowOfMeansInTheAllYears[i]));
            }
            outflowOfFundsInTheAllYears = new long[horizonOfCalculationOfTheProject];
            for (int i = 0; i < horizonOfCalculationOfTheProject; i++)
            {
                ht.Add(new Map("Отток средств в " + (i + 1) + "-й год, Z" + (i + 1), outflowOfFundsInTheAllYears[i]));
            }

            //ht.Add(new Map("Стартовые инвестиции, IC", 110000));
            //ht.Add(new Map("Ставка дисконтирования, i", 13));
            //inflowOfMeansInTheAllYears = new long[horizonOfCalculationOfTheProject];
            //for (int i = 0; i < horizonOfCalculationOfTheProject; i++)
            //{
            //    ht.Add(new Map("Приток средств в " + (i + 1) + "-й год, DP" + (i + 1), 75000));
            //}
            //outflowOfFundsInTheAllYears = new long[horizonOfCalculationOfTheProject];
            //for (int i = 0; i < horizonOfCalculationOfTheProject; i++)
            //{
            //    ht.Add(new Map("Отток средств в " + (i + 1) + "-й год, Z" + (i + 1), 20000 - 5000 * i));
            //}
            return ht;
        }
    }
}
