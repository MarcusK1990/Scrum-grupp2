﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace vIT_System.XmlRelaterat
{
    public class CompensationModel
    {
        public string eMail { get; set; }
        public string forNamn { get; set; }
        public string eftNamn { get; set; }
        public int milErsattning { get; set; }
        public string ÄndraISparadAnsökan { get; set; }
        public BindingList<Utgift> Utgifter { get; set; }
        public BindingList<Resa> Resor { get; set; }

        public CompensationModel(BindingList<Utgift> utkastet, BindingList<Resa> resor)
        {
            Utgifter = new BindingList<Utgift>();
            Resor = new BindingList<Resa>();
            Utgifter = utkastet;
            Resor = resor;  
        }
    
        public CompensationModel()
        {
        }
    }
   
    
}
