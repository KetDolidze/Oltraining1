﻿class Training
{
    static void Main(string[] argss)
    {
        /* 1. შევქმნათ სამი ცვლადი (x,y,z) მივანიჭოთ მნიშვნელობები. გამოვიყვაოთ კონსოლში: x+y*y=ჯამი
        * მაგ: 4,5,10-ის შედეგია 54/
        */
        int x = 4;
        int z = 5;
        int y = 10;
        int sum = x + (5 * 10);
        Console.Write("The sum of x (4) +(y (5)*z (10)) equals to: " + sum);

        Console.WriteLine();

        /* 2. პროგრამა სთავაზობს მომხმარებელს შეიყვაოს სახელი (Archil), გვარი (Sikharulidze), asaki (11) da wona (88.7).
         * შევინახოთ ეს მონაცემები შესაბამისი ტიპის ცვლადებში. გამოვიყვანოთ მთელი ინფორმაცია კონსოლში
         */
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Please enter yous surname: ");
        string surname = Console.ReadLine();
        Console.Write("Please enter your age: ");
        int age = Int32.Parse(Console.ReadLine());
        Console.Write("Please enter your height: ");
        int height = Int32.Parse(Console.ReadLine());
        Console.Write("Please enter your weight: ");
        float weight = float.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Your name is: " + name);
        Console.WriteLine("Your surname is: " + surname);
        Console.WriteLine("Your age is: " + age);
        Console.WriteLine("Your height is: " + height);
        Console.WriteLine("Your weight is: " + weight);

        Console.WriteLine();
        /*დაწერეთ კოდი, რომელიც ითვლის ადამიანის BMI მოიძიეთ ფორმულა ინტერნეტში.
         * ლოგიკა და კოდი დამოუკიდებლად გაწერეთ
         */

        Console.Write("Weight in kg: ");
        int kg;
        kg = Convert.ToInt32(Console.ReadLine());
        Console.Write("Height in m: ");
        int m;
        m = Convert.ToInt32(Console.ReadLine());
        int BMI;
        BMI = kg / ((m / 100) * (m / 100));
        Console.WriteLine("Your BMI is: " + BMI);



        /* 4
         */

        Console.WriteLine("   | | ");
        Console.WriteLine("  1|2|3");
        Console.WriteLine("   | | ");
        Console.WriteLine("  _ _ _");
        Console.WriteLine("   | | ");
        Console.WriteLine("  4|5|6");
        Console.WriteLine("   | | ");
        Console.WriteLine("  _ _ _");
        Console.WriteLine("   | | ");
        Console.WriteLine("  7|8|9");
        Console.WriteLine("   | | ");



    }
}
