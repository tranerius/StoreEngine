﻿using System.Text;

namespace Treynessen.Functions
{
    public static partial class OtherFunctions
    {
        // В js не переносить (отвратительная анимации отделения цифр при загрузке страницы)
        public static string PriceFormatting(uint price)
        {
            string strPrice = price.ToString();
            StringBuilder builder = new StringBuilder(strPrice);
            int count = 0;
            for (int i = strPrice.Length - 1; i >= 0; --i)
            {
                ++count;
                if (count == 3 && i != 0)
                {
                    count = 0;
                    builder.Insert(i, "&thinsp;");
                }
            }
            return builder.ToString();
        }
    }
}