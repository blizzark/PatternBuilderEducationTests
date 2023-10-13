using System.Text;

namespace PatternBuilderEducationTests
{
    public class Burger
    {
        public Bun Bun { get; set; }
        public List<Sauce> Sauce { get; set; }
        public Onion Onion { get; set; }
        public LettuceLeaves LettuceLeaves { get; set; }
        public Cutlet Cutlet { get; set; }
        public Cucumbers Cucumbers { get; set; }
        public Tomatoes Tomatoes { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Bun != null)
                sb.Append("Булка: " + Bun.Sort + ", Форма: " + Bun.Form + "\n");
            if (Sauce != null)
            {
                foreach (Sauce s in Sauce)
                    sb.Append("Соус: " + s.Sort + "\n");
            }
            if (Onion != null)
                sb.Append("Лук: " + Onion.Sort + "\n");
            if (LettuceLeaves != null)
                sb.Append("Листья салата: " + LettuceLeaves.Sort + "\n");
            if (Cutlet != null)
                sb.Append("Котлета: " + Cutlet.Sort + "\n");
            if (Cucumbers != null)
                sb.Append("Огурцы: " + Cucumbers.Sort + "\n");
            if (Tomatoes != null)
                sb.Append("Томаты: " + Tomatoes.Sort + "\n");

            return sb.ToString();
        }
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
