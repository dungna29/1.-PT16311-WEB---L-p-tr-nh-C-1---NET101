using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3._5_KeThua
{
    class Person //Lớp cha
    {
        private string Ho;
        private string tendem;
        private string ten;

        public Person()
        {
            
        }

        public Person(string ho, string tendem, string ten)
        {
            Ho = ho;
            this.tendem = tendem;
            this.ten = ten;
        }

        public string Ho1
        {
            get => Ho;
            set => Ho = value;
        }

        public string Tendem
        {
            get => tendem;
            set => tendem = value;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public virtual void inRaManHinhPeron()
        {
            Console.WriteLine("Đây là phương thức của lớp cha");
        }
        public void inRaManHinhPeron1()
        {
            Console.WriteLine("Đây là phương thức của lớp cha");
        }
    }
}
