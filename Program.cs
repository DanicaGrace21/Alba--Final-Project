using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Alba
{
    internal class ZodiacSign
    {
        public static string Aquarius(string Astro, string Characteristics)
        {
            Console.WriteLine("You are Aquarius");
            Console.WriteLine();
            Console.WriteLine("Your Characteristics: Innovative, independent, intellectual, humanitarian, and forward-thinking.");
            Astro = "Aquarius";
            Characteristics = "Innovative, independent, intellectual, humanitarian";
            Astro = $"{Astro.ToString().PadRight(15)} {Characteristics.ToString().PadRight(15)}";
            return Astro;
        }
        public static string Capiricorn(string Astro, string Characteristics)
        {
            Console.WriteLine("You are Capiricorn");
            Console.WriteLine();
            Console.WriteLine("Your Characteristics: Ambitious, disciplined, responsible, practical, and determined.");
            Astro = "Capricorn";
            Characteristics = "Ambitious, disciplined, responsible, practical";
            Astro = $"{Astro.ToString().PadRight(15)} {Characteristics.ToString().PadRight(15)}";
            return Astro;
        }
        public static string Pisces(string Astro, string Characteristics)
        {
            Console.WriteLine("You are Pisces");
            Console.WriteLine();
            Console.WriteLine("Your Characteristics: Compassionate, intuitive, artistic, gentle, and empathetic.");
            Astro = "Pisces";
            Characteristics = "Compassionate, intuitive, artistic, gentle";
            Astro = $"{Astro.ToString().PadRight(15)} {Characteristics.ToString().PadRight(15)}";
            return Astro;
        }
        public static string Aries(string Astro, string Characteristics)
        {
            Console.WriteLine("You are Aries");
            Console.WriteLine();
            Console.WriteLine("Your Characteristics: Bold, energetic, competitive, confident, and independent.");
            Astro = "Aries";
            Characteristics = "Bold, energetic, competitive, confident";
            Astro = $"{Astro.ToString().PadRight(15)} {Characteristics.ToString().PadRight(15)}";
            return Astro;
        }
        public static string Taurus(string Astro, string Characteristics)
        {
            Console.WriteLine("You are Taurus");
            Console.WriteLine();
            Console.WriteLine("Your Characteristics: Reliable, patient, practical, determined, and loyal.");
            Astro = "Taurus";
            Characteristics = "Reliable, patient, practical, determined";
            Astro = $"{Astro.ToString().PadRight(15)} {Characteristics.ToString().PadRight(15)}";
            return Astro;
        }
        public static string Gemini(string Astro, string Characteristics)
        {
            Console.WriteLine("You are Gemini");
            Console.WriteLine();
            Console.WriteLine("Your Characteristics: Curious, adaptable, expressive, witty, and versatile.");
            Astro = "Gemini";
            Characteristics = "Curious, adaptable, expressive, witty";
            Astro = $"{Astro.ToString().PadRight(15)} {Characteristics.ToString().PadRight(15)}";
            return Astro;
        }
        public static string Cancer(string Astro, string Characteristics)
        {
            Console.WriteLine("You are Cancer");
            Console.WriteLine();
            Console.WriteLine("Your Characteristics: Emotional, nurturing, intuitive, empathetic, and protective.");
            Astro = "Cancer";
            Characteristics = "Emotional, nurturing, intuitive, empathetic";
            Astro = $"{Astro.ToString().PadRight(15)} {Characteristics.ToString().PadRight(15)}";
            return Astro;
        }
        public static string Leo(string Astro, string Characteristics)
        {
            Console.WriteLine("You are Leo");
            Console.WriteLine();
            Console.WriteLine("Your Characteristics: Confident, charismatic, generous, loyal, and ambitious.");
            Astro = "Leo";
            Characteristics = "Confident, charismatic, generous, loyal";
            Astro = $"{Astro.ToString().PadRight(15)} {Characteristics.ToString().PadRight(15)}";
            return Astro;
        }
        public static string Virgo(string Astro, string Characteristics)
        {
            Console.WriteLine("You are Virgo");
            Console.WriteLine();
            Console.WriteLine("Your Characteristics: Practical, analytical, detail-oriented, diligent, and reliable.");
            Astro = "Virgo";
            Characteristics = "Practical, analytical, detail-oriented, diligent";
            Astro = $"{Astro.ToString().PadRight(15)} {Characteristics.ToString().PadRight(15)}";
            return Astro;
        }
        public static string Libra(string Astro, string Characteristics)
        {
            Console.WriteLine("You are Libra");
            Console.WriteLine();
            Console.WriteLine("Your Characteristics: Diplomatic, social, fair-minded, charming, and cooperative.");
            Astro = "Libra";
            Characteristics = "Diplomatic, social, fair-minded, charming";
            Astro = $"{Astro.ToString().PadRight(15)} {Characteristics.ToString().PadRight(15)}";
            return Astro;
        }
        public static string Scorpio(string Astro, string Characteristics)
        {
            Console.WriteLine("You are Scorpio");
            Console.WriteLine();
            Console.WriteLine("Your Characteristics: Passionate, determined, resourceful, secretive, and resilient.");
            Astro = "Scorpio";
            Characteristics = "Passionate, determined, resourceful, secretive";
            Astro = $"{Astro.ToString().PadRight(15)} {Characteristics.ToString().PadRight(15)}";
            return Astro;
        }
        public static string Sagittarius(string Astro, string Characteristics)
        {
            Console.WriteLine("You are Sagittarius");
            Console.WriteLine();
            Console.WriteLine("Your Characteristics: Adventurous, optimistic, independent, straightforward, and philosophical.");
            Astro = "Sagittarius";
            Characteristics = "Adventurous, optimistic, independent, straightforward";
            Astro = $"{Astro.ToString().PadRight(15)} {Characteristics.ToString().PadRight(15)}";
            return Astro;
        }
    }
}
