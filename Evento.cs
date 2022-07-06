using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class Evento{
        public string titolo;
        public DateTime data;
        public int capienzaMassima;

        public string Titolo {
            get { return titolo; }
            set {
                try{

                }catch(Exception e){
                    Console.WriteLine("è obbligatorio inserire il titolo");
                }
            } 
        }

        public DateTime Data { 
            get { return data; } 
            set {
                try{
                    data = value;

                }
                catch (Exception e){
                    Console.WriteLine("Data inserita già trascorsa!");
                }
            }
        }
        public int CapienzaMassima {
            get { return capienzaMassima; }
            private set {
                try{
                    capienzaMassima = value;

                }
                catch (Exception e){
                    Console.WriteLine("Non puoi inserire un numero negativo!");
                }
            }
        }
        public int postiPrenotati { get; }


        public Evento(string titolo, DateTime data, int capienzaMassima){
            Titolo = titolo;
            Data = data;
            CapienzaMassima = capienzaMassima;
            this.postiPrenotati = 0;
        }
    }
}
