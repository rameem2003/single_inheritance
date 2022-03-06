using System;

namespace single_inheritance
{
    class salary
    {
        public int member_salary = 2000;
    }

    class bonus: salary
    {
        public int member_bonus = 5000;
    }


    class app
    {
        public static void Main()
        {
            bonus obj = new bonus();

            Console.WriteLine("Member salary is: " + obj.member_salary + " TK");
            Console.WriteLine("Member bonus is: " + obj.member_bonus + " TK");
        }
    }
}