using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class vichisleniya
    {
        public double vichislenie(double znachenie1, double znachenie2, string deistvie_arifmeticheskoe)
        {
                if (deistvie_arifmeticheskoe == "*")
                {
                    return znachenie1 * znachenie2;
                }
                else if (deistvie_arifmeticheskoe == "/")
                {
                    return znachenie1 / znachenie2;
                }
                else if (deistvie_arifmeticheskoe == "+")
                {
                    return znachenie1 + znachenie2;
                }
                else if (deistvie_arifmeticheskoe == "-")
                {
                    return znachenie1 - znachenie2;
                }
                else
                    return 0;
            }
}
}
