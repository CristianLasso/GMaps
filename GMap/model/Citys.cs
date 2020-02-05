using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Citys
    {
        private String name;
        private List<Double> delays;


        public Citys(String name)
        {
            this.name = name;
            delays = new List<Double>();
        }

        public void addDelay(Double delay)
        {
            delays.Add(delay);
        }

        public String Name { get; set; }

        public Double promDelays()
        {
            Double prom = 0;
            int num = 0;
            for (int i = 0; i < delays.Count(); i++)
            {
                prom = prom + delays.ElementAt(i);
                num = i;
            }
            prom = prom / num;

            return prom;
        }
    }
}
