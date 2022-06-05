using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYarismasi
{
    class Question
    {
        private int id;
        private String soru;
        public String secenekA;
        public String secenekB;
        public String secenekC;
        public String secenekD;

        public Question()
        {
            id = -1;
            soru = null;
        }
        public string Soru  
        {
            get { return soru; }   
            set { soru = value; }  
        }

       
    }
}
