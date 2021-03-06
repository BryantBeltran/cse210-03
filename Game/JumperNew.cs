using System;
using System.Collections.Generic;

namespace CSE210_03
{
    public class JumperNew
    {
        public List<string> parachute = new List<string>() {
            "  ___",
            " /___\\",
            " \\   /",
            "  \\ /",};
        public List<string> person = new List<string>() {"   0   ", "  /|\\  ", "  / \\  "};

        public JumperNew()
        {

        }
        public void PrintChute()
        {
             Console.WriteLine("\n");
            foreach (string line in parachute)
            {
                Console.WriteLine(line);
            }
        }

        public void PrintPerson()
        {
            foreach (string line in person)
            {
                Console.WriteLine(line);
            }
        }

        public void CutChute()
        {
            if (parachute.Count > 0)
            {
                parachute.Remove(parachute[0]);
            }
            else
            {
                person[0] = "   X   ";
            }
        }

        public bool IsDead()
        {
            return (person[0] != "   0   ");
        }
    }
}