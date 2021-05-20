using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kit.Data
{
    //http://www.kievoit.ippo.kubg.edu.ua/kievoit/2012/24/24.html#:~:text=Зв%27язок%20один%20до%20багатьох,менше%20двох%20записів%20іншої%20таблиці.&text=Кожному%20запису%20у%20зв%27язаній,зв%27язаній%20таблиці%20і%20навпаки.
    //https://kafinfo.org.ua/files/Informatyka_10_11/Glava_9_47.pdf
    public class Base
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public Base ()
        {
            Id = Guid.NewGuid();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
