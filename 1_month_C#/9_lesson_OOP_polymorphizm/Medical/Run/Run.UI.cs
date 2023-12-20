﻿namespace _9_lesson_OOP_polymorphizm.Medical
{
    public partial class Run
    {
        public void RunUi()
        {
            while (isRun)
            {
                Console.WriteLine("<<1>> Bemor qo'shish.");
                Console.WriteLine("<<2>> Bemor haqida ma'lumot olish.");
                Console.WriteLine("<<3>> Doctor qo'shish.");
                Console.WriteLine("<<4>> Doctor haqida ma'lumot olish.");
                Console.WriteLine("<<5>> Shifokorga be'mor biriktirish.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("<<0>> Dasturni to'xtatish.");
                Console.ResetColor();
                userSelect = Console.ReadLine().ToString();

                if (userSelect == "1")
                {
                    Console.Clear();
                    Console.Write("Enter patient's name: ");
                    var name = Console.ReadLine();
                    Console.Write("Enter patient's surname: ");
                    var surname = Console.ReadLine();
                    Console.WriteLine("Enter patient's gender.");
                    Console.Write("<<1>> Male | <<2>> Female: ");

                    // agar ma'lumot kiritmasa ortga qaytaradi.
                    if (name == "" || surname == "")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter the information completely!");
                        Console.ResetColor();
                        continue;
                    }

                    Enum gender;
                    var enteredGender = Console.ReadLine().ToString();
                    if (enteredGender == "1")
                    {
                        gender = Gender.Male;
                    }
                    else if (enteredGender == "2")
                    {
                        gender = Gender.Male;
                    }
                    else
                    {
                        gender = Gender.None;
                    }
                    Person person = new Person(name, surname, ssn++, gender);

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(klinika.AddPatient(person));
                    Console.ResetColor();
                    Console.WriteLine($"Your SSN: <<{person.Ssn}>>\n");
                }
                else if (userSelect == "2")
                {
                    Console.Clear();
                    Console.Write("Enter patient's ssn: ");
                    int ssn = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(klinika.GetPatient(ssn));
                    Console.Read();
                }
                else if (userSelect == "3")
                {
                    Console.Clear();
                }
                else if (userSelect == "4")
                {
                    Console.Clear();
                }
                else if (userSelect == "5")
                {
                    Console.Clear();
                }
                else if (userSelect == "0")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dastur'ni to'xtatdingiz.");
                    Console.ResetColor();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter unknown key!");
                    Console.ResetColor();
                }
            }
        }
    }
}
