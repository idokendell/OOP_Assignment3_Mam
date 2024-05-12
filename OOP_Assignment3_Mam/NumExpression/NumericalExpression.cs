using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment3_Mam.NumExpression
{
    public class NumericalExpression
    {
        private int _num { get; set; }
        //אם המשתמש רוצה להוסיף בצורה תכנותית עוד מימושים יכול לשנות.
        //י את הקריאה לפעולות לפעולות שונות שהוא יישם עם שפות אחרות/מספרים יותר גדולים
        private Func<string[]> _first_twenty = EnglishNumToWords.First_twenty;
        private Func<string[]> _multiplier = EnglishNumToWords.Multiplier;
        private Func<string[]> _tens = EnglishNumToWords.Tens;
        private Func<string> _hundred = EnglishNumToWords.Hundred;
        private Func<string> _zero = EnglishNumToWords.Zero;

        public NumericalExpression(int num)
        {
            _num= num;
        }
        public NumericalExpression(int num, Func<string[]> twenty, Func<string[]> multipliers, Func<string[]> tens, Func<string> hundred, Func<string> zero)
        {
            _num=num;
            _first_twenty=twenty;
            _multiplier=multipliers;
            _tens=tens;
            _hundred=hundred;
            _zero=zero;
        }
        public int GetNum()
        {
            return _num;
        }
        private int NumLength(int num)
        {
            return (""+num).Length;
        }
        private int NumOfLoops(int num)
        {
            int len = NumLength(num);
            if (len%3==0) return len/3;
            return len/3+1;
        }
        public override string ToString()
        {
            int num2 = _num;
            // powers of 10
            String[] multiplier = _multiplier();
            // numbers till 20
            String[] first_twenty = this._first_twenty();
            // multiples of ten
            String[] tens = _tens();

            if (_num==0) return this._zero();
            if (_num<20) return first_twenty[_num];
            List<string> temp_answer = new List<string>();
            string answer = "";
            int temp_number = 0;
            for (int i = 0; i<NumOfLoops(_num); i++)
            {
                temp_number=num2%1000;
                if (temp_number/100!=0)
                { answer+=first_twenty[(temp_number/100)]+" "+ this._hundred()+" "; }
                temp_number=temp_number%100;
                if (temp_number!=0)
                {
                    if (temp_number<20) answer+=first_twenty[temp_number]+""+ multiplier[i];
                    else { answer+=tens[temp_number/10]+" "+first_twenty[temp_number%10]+" "+multiplier[i]; }
                }
                num2=num2/1000;
                temp_answer.Add(answer);
                answer="";
            }
            answer="";
            temp_answer.ForEach(x => answer=x+" "+answer);
            return answer;

        }
        public static int SumLetters(int num)
        {

            int letters = 0;
            for (int i = 0; i<=num; i++)
            {
                letters+=new NumericalExpression(i).ToString().Replace(" ", "").Length;
            }
            return letters;

        }
        //method overloading
        public static int SumLetters(NumericalExpression obj)
        {
            //DRY
            return SumLetters(obj.GetNum());

        }
        
    }
}
