using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{

    internal struct Klass
    {
        public Klass(int Number, char Symbol)
        {
            number = Number;
            symbol = Symbol;
        }

        public Klass(string str)
        {
            number = Int32.Parse(str.Substring(0, str.Length-1));
            symbol = str[str.Length-1];
        }

        public double number { get; set; }
        public char symbol { get; set; }

        public override string ToString() => $"{number}{symbol}";
    }

    class student
    {
        internal string name;
        internal int age;
        internal Klass klass;
        internal string sex;
        internal bool attendance;
        internal string academic_performance;
        internal bool foreign;

        public student(string n, int a, Klass kl, string s, bool at, string ac, bool f)
        {
            name = n;
            age = a;
            klass = kl;
            sex = s;
            attendance = at;
            academic_performance = ac;
            foreign = f;
        }

        public override string ToString()
        {
            return name + ", " + age + ", " + klass.ToString() + ", " + sex + ", " + attendance + ", " + academic_performance + ", " + foreign;
        }
    }
}
