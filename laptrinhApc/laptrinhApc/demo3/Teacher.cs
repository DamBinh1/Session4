using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptrinhApc.demo3
{
    public class Teacher:AbstractTeacher
    {
        private List<String> tels;
        private string name;
        public Teacher(){
            tels = new List<String>();
        }
        public Teacher(String name)
        {
            this.name = name;
        }
        public List<String> Tels
        {
            get => tels;
            set => tels = value;
        }
        public String this[int index]{
            get => Tels[index];
            set => Tels[index] = value;
        }
        
        public virtual void Teach()
        {
            Console.WriteLine("teach....");
        }
        public void Lunch()
        {

        }
        public override void Run()
        {

        }
    }
}
