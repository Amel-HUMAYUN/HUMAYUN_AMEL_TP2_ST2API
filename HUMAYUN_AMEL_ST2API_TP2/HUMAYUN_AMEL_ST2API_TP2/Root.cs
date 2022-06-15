 using System;
using System.Collections.Generic;
using System.Text;

namespace HUMAYUN_AMEL_ST2API_TP2
{
    public class Root
    {
        public Coord Coord { get; set; }
        public List<Weather> Weather { get; set; }
        public string @base { get; set; }
        public Main Main { get; set; }
        public int Visibility { get; set; }
        public Wind Wind { get; set; }
        public Clouds Clouds { get; set; }
        public int Dt { get; set; }
        public Sys Sys { get; set; }
        public int Timezone { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }
    }
}
