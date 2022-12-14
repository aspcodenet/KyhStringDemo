using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KyhStringDemo
{
    internal class App
    {
        /*                  Tisdag 20 sept
         *               GENOMGÅNG STRING-LABBAR
         *
         *                Fundera på vilka ni vill att jag visar??
         
         *                 Så frågar jag 08:30
         */



        /*
         *Be användaren mata in en mailadress.
        Programmet skall kontrollera att inmatningen är rätt
        dvs att det finns ett @ tecken och
        att det finns en . med 2 eller 3 tecken efter.
        Meddela användaren om det är rätt eller felaktig adress
        ex a@a.se = ok a@a.hejsan = fel a@a = fel
         *
         *
         */


        public void Run()
        {
            string texten = "Detta är min text som jag matar in";
            // antalord = antal mellanslag + 1
            int antalMellanslag = 0;
            foreach (char ch in texten)
            {
                if (ch == ' ')
                    antalMellanslag++;
            }
            Console.WriteLine($"Antal ord är {antalMellanslag+1} hallo");




            string orig = "Ni talar bra latin";
            orig = orig.ToLower().Replace(" ", "");  // len = 15
            string reversed = "";

            foreach (char ch in orig)
            {
                reversed = ch + reversed;
            }
            //for (int i = orig.Length - 1; i >= 0; i--)
            //{
            //    reversed += orig[i];
            //}

            if (reversed == orig)
            {
                Console.WriteLine("Palindrom");
            }


















            foreach (char c in orig)
            {
                reversed = c + reversed;
            }

            reversed = "";
            for (int i = orig.Length - 1; i >= 0; i--)
            {
                char c = orig[i];
                reversed += c;
            }


            string email = "se.h@aase354";
            int index = email.IndexOf("@");   // -> -1
            int lastDotIndex = email.LastIndexOf('.'); // 7
            int antalAfterDot = email.Length - lastDotIndex - 1;

            if(index != -1 && lastDotIndex != -1 && (antalAfterDot == 2 || antalAfterDot == 3))
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Ogiltig");



            //              0123456789
            //string email = "se.h@aase354";

            //int index = email.IndexOf("@");   // -> -1
            //if (index != -1)
            //{
            //    int lastDotIndex = email.LastIndexOf('.'); // 7
            //    if (lastDotIndex == -1)
            //    {
            //        Console.WriteLine("Gogiltif");
            //    }
            //    else
            //    {
            //        //Length = 10
            //        int antalAfterDot = email.Length - lastDotIndex - 1;
            //        if (antalAfterDot == 2 || antalAfterDot == 3)
            //        {
            //            Console.WriteLine("Giltig");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Ogiltig");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Ogiltig");
            //}

            //if (email.Contains("@"))
            //{

            //}





            // 12:30 GENOMGÅNG "Kurt Arne Andersson"
            string namn = "kurt arne andersson";
            string modifiedString = "";


            for (int i = 0; i < namn.Length; i++)
            {
                bool firstLetter2 = i == 0;
//                char currentLetter = namn[i];
                if (firstLetter2 || namn[i - 1] == ' ')
                    modifiedString = modifiedString + char.ToUpper(namn[i]);
                else
                    modifiedString = modifiedString + namn[i];

            }


            //VAD AVGÖR OM EN BOKSTAV SKA BLI UPPERCASE?
            // om bokstaven innan är ett mellanslag
            // eller om det är den första bokstavem
            bool firstLetter = true;
            char letterBefore = ' ';
            foreach (char ch in namn)
            {
                if (firstLetter || letterBefore == ' ')
                    modifiedString = modifiedString + char.ToUpper(ch);
                else
                    modifiedString = modifiedString + ch;
                firstLetter = false;
                letterBefore = ch;
            }
            Console.WriteLine(modifiedString);






//            string name = "Stefan";
//            int age = 12;
//            Console.WriteLine("Du heter " + name + " och är " + age + " år gammal");
//            Console.WriteLine($"Du heter {name} och är {age} år gammal men om tre år är dy {age+3}");
//            string email = "stefan.hol@aaa.se"; // stefan@aaa.se
//            //Kontrollera så att det finns minst 2 . i email

//            int numberOfDotsIHaveFoundSoFar = 0;
//            foreach (char letter in email)
//            {
//                if (letter == '.')
//                    numberOfDotsIHaveFoundSoFar++;
//            }
//            Console.WriteLine("Det finns " + numberOfDotsIHaveFoundSoFar + " punkter");

//            //string aName = "Stefan";
//            //char firstLetter = aName[0];
//            //char nextLetter = aName[1];
//            //for (int i = 0; i < aName.Length; i++)
//            //{
//            //    Console.WriteLine(aName[i]);
//            //}

//            //foreach (char letter in aName)
//            //{
//            //    Console.WriteLine(letter);
//            //}


//            //string namnet = Console.ReadLine();


//            //if (namnet.EndsWith(".se"))
//            //{
//            //    Console.WriteLine("Nice");
//            //}

//            ////namnet = namnet.TrimStart();//Tar bort mellanslag i början men inte efter
//            ////namnet = namnet.TrimEnd();//Tar bort mellanslag i början men inte efter
//            //namnet = namnet.Trim();
//            ////stefan  

//            //if (namnet.Length > 5)
//            //{
//            //    Console.WriteLine("Dui har skrivit för långt");
//            //}

//            ////text.LastIndexOf()
//            ////                  
//            //string name = "c:\\temp\\blabla\\hello.jpg";
//            //int pos = name.LastIndexOf("\\");
//            //string fileName = name.Substring(pos+1);
//            //Console.WriteLine(pos);

//            //string n2 = "hej hopp stefan";
//            //string n3 = n2.Substring(4, 3);
//            //Console.WriteLine(n3);

//            //Längden
//            //Trim
//            //StartsWith
//            //EndsWith
//            // Substring
//            // delar av sträng med []
//            // splitting
//            // looping




////            Console.WriteLine("Välkommen till chatten");
////            while (true)
////            {
////                Console.WriteLine("Säg nåt:");
////                string text = Console.ReadLine();

////                // string lowerText = text.ToLower();
////                text = text.Replace("dumma", "*****");
////                text = text.Replace("dummis", "*****");

////                //if (lowerText.Contains("dumma"))
////                //{
////                //    Console.WriteLine("You are banned from the chat");
////                //    break;
////                //}
////                //int position = lowerText.IndexOf("dumma"); // -1
////                //if (position != -1)
////                //{
////                //    Console.WriteLine("You are banned from the chat");
////                //    break;
////                //}



////                Console.WriteLine(text);
////            }

////            while (true)
////            {
////                Console.WriteLine("Spelet körs");
////                Console.WriteLine("Vill du fortsätta Ja/Nej");
////                string action = Console.ReadLine();

////                action = action.ToUpper();

////                if (action=="NEJ")
////                {
////                    break;
////                }
////            }
////            Console.WriteLine("Spelet är slut");


////            int age = 12;
////            int age2 = 0;
////            age = age + 13;
//////          age 25

////            string namn = "S";
////            string namn1 = "sdghasdasdasdasdajhsdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdad";
////            namn = "sdghasdasdasdasdajhsdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdad";
////            namn1 = "A";


////            string fornamn = "Stefan";
////            string efternamn = "Holmberg";
////            string fullName = fornamn + efternamn;
////            Console.WriteLine(fullName);

////            string tal1= "25";
////            string tal2= "2";
////            string summa= tal1 + tal2;
////            Console.WriteLine(summa);






        }
    }
}
