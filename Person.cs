using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb4
{
    public class Person
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; private set; }
        public string EyeColor { get; private set; }
        public Gender Gender { get; set; }
        public Hair Hair { get; set; }

        // Tilldelar födelsedatum till egenskapen Birthday
        public void SetBirthday(DateTime date)
        {
            Birthday = date;
        }

        // Tilldelar ögonfärg till egenskapen EyeColor
        public void SetEyeColor(string color)
        {
            EyeColor = color;
        }

        // Metod som returnerar Person-objekt i string
        public override string ToString()
        {
            return $"\nNamn: {Name} \nÅlder: {Age}" 
                + $"\nFödelsedag: {Birthday:yyyy-MM-dd}\nÖgonfärg: {EyeColor}\n" +
                $"Kön: {Gender}\nHår: {Hair}\n";
        }

    }
}
