using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        
        public string CategoryName { get; set; }

        public bool CategoryStatus { get; set; }
    }
}
/*
Field-Variable-Property
 
int x --> Field (değişken yapısı bir sınıfın içine tanımlanırsa field olur.)
int y --> Variable (değişken yapısı bir metodun içinde tanımlanırsa variable olur.)
int z {get;set;} --> Property (değişken yapısı sonuna get set ifadesi alırsa property olur.)
 */