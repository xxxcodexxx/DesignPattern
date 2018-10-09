using System.Collections.Generic;

namespace BuilderPattern.Product
{
    public class Product
    {
        List<object> parts = new List<object>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void AddRange(List<object> lsparts)
        {
            parts.AddRange(lsparts);
        }

        public string ListParts()
        {
            var str = string.Empty;
            parts.ForEach(part =>
            {
                str += part + @", ";
            });
            str = !string.IsNullOrEmpty(str) ? str.Remove(str.Length - 2) : str;
            return @"Product parts: " + str + "\n";
        }
    }
}
