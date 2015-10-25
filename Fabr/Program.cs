using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabr
{
    class Program
    {
        static void Main(string[] args)
        {
 
    PianoFactory y_p = new YamahaFactory (); 
     Client c1 = new Client(y_p); 
     c1.Run();          
     PianoFactory c_p = new ChaykaFactory();
     Client c2 = new Client(c_p);
     c1.Run();     
     Console.Read(); 
        }
    }
// dkdslgjlkd
    abstract class PianoFactory
    {
        public abstract AbstractPiano CreatePiano();
        public abstract AbstractCorpus CreateCorpus();
    }

    class YamahaFactory : PianoFactory
    {
        public override AbstractPiano CreatePiano()
        {return new YamahaPiano();}
        public override AbstractCorpus CreateCorpus()
        {return new YamahaCorpus();}
    }

    class ChaykaFactory : PianoFactory
    {
        public override AbstractPiano CreatePiano()
        { return new ChaykaPiano();}
        public override AbstractCorpus CreateCorpus()
        {return new ChaykaCorpus();}
    }

    abstract class AbstractPiano
    { public abstract void Material(AbstractPiano Corpus);}

    abstract class AbstractCorpus
    { public string material;}

    class YamahaPiano : AbstractPiano 
 { public override void Material(AbstractCorpus corpus) 
{Console.WriteLine("Material: " + corpus.material);} 
 } 

    class YamahaCorpus : AbstractCorpus 
 {  public YamahaCorpus() 
 {  material = "Plastik"; } 
 }

    class ChaykaPiano : AbstractPiano
  { public override void Material(AbstractCorpus corpus) 
{Console.WriteLine("Material: " + corpus.material);} 
}

    class ChaykaCorpus : AbstractCorpus  
  { public ChaykaCorpus() 
  { material = "дерево"; } 
  }

    class Client 
 { 
   private AbstractPiano abstractPiano; 
private AbstractCorpus abstractCorpus; 
public Client(PianoFactory p_f) 
   { abstractPiano = p_f.CreatePiano();
     abstractCorpus = p_f.CreateCorpus(); }    
public void Run() 
   { abstractPiano.Material(abstractCorpus); } 
  }

}
