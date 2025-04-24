using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_5
{
    public class Phone
    {
        public string Model { get; set; }
        public string Diagonal { get; set; }
        public int Cores { get; set; }
        public string Platform { get; set; }
        public int SimQuantity { get; set; }
        public bool HasAI { get; set; }
        public bool HasTypeC { get; set; }

        public Phone()
        {
        }

        public Phone(string model, string diagonal, int cores, string platform, int simQuantity, bool hasAI, bool hasTypeC)
        {
            Model = model;
            Diagonal = diagonal;
            Cores = cores;
            Platform = platform;
            SimQuantity = simQuantity;
            HasAI = hasAI;
            HasTypeC = hasTypeC;
        }

        public string Has4Cores()
        {
            if (Cores == 4)
            {
                return "Телефон має 4 ядра";
            }
            return "Телефон не має 4 ядер";
        }

        public string GetPhone4Cores
        {
            get
            {
                return Has4Cores();
            }
        }
    }
}
