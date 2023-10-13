using System.Text;

namespace PatternBuilderEducationTests
{
    public class Burger
    {
        public List<Bun> Bun { get; set; }
        public List<Sauce> Sauce { get; set; }
        public List<Onion> Onion { get; set; }
        public List<LettuceLeaves> LettuceLeaves { get; set; }
        public List<Cheese> Cheese { get; set; }
        public List<Cutlet> Cutlet { get; set; }
        public List<Cucumbers> Cucumbers { get; set; }
        public List<Tomatoes> Tomatoes { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Bun != null)
                foreach (Bun s in Bun)
                    sb.Append("Булка: " + s.Sort + ", Форма: " + s.Form + "\n");
            if (Sauce != null)
            {
                foreach (Sauce s in Sauce)
                    sb.Append("Соус: " + s.Sort + "\n");
            }
            if (Onion != null)
                foreach (Onion s in Onion)
                    sb.Append("Лук: " + s.Sort + "\n");
            if (LettuceLeaves != null)
                foreach (LettuceLeaves s in LettuceLeaves)
                    sb.Append("Листья салата: " + s.Sort + "\n");
            if (Cutlet != null)
                foreach (Cutlet s in Cutlet)
                    sb.Append("Котлета: " + s.Sort + "\n");
            if (Cucumbers != null)
                foreach (Cucumbers s in Cucumbers)
                    sb.Append("Огурцы: " + s.Sort + "\n");
            if (Tomatoes != null)
                foreach (Tomatoes s in Tomatoes)
                    sb.Append("Томаты: " + s.Sort + "\n");

            return sb.ToString();
        }
    }

    public class Cheese
    {
        public string Sort { get; set; }
    }

    public class Sauce
    {
        public string Sort { get; set; }

    }

    public class Onion
    {
        public string Sort { get; set; }

    }

    public class LettuceLeaves
    {
        public string Sort { get; set; }

    }
    public class Cutlet
    {
        public string Sort { get; set; }
    }
    public class Cucumbers
    {
        public string Sort { get; set; }
    }
    public class Tomatoes
    {
        public string Sort { get; set; }
    }
    public class Bun
    {
        public string Sort { get; set; }
        public string Form { get; set; }

    }
}
