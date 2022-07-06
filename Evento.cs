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
        public int postiPrenotati { get; private set;}

        public string Titolo {
            get { return titolo; }
            set {
                try{
                    titolo = value;
                }catch(Exception e){
                    Console.WriteLine("è obbligatorio inserire il titolo!");
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


        public Evento(string titolo, DateTime data, int capienzaMassima){
            Titolo = titolo;
            Data = data;
            CapienzaMassima = capienzaMassima;
            this.postiPrenotati = 0;
        }

        public void PrenotaPosti(int numeroPosti){
            
            try{
                if (this.capienzaMassima == 0 || DateTime.Now.CompareTo(this.data) > 0 || this.capienzaMassima - this.postiPrenotati <= 0){
                    throw new Exception();
                }
                this.postiPrenotati += numeroPosti;

            }catch(Exception e){
                Console.WriteLine("Errore nella prenotazione! Assicurati di aver scritto i dati correttamente");
            }
        }

        public void DisdiciPosti(int postiDaRimuovere){
            try{
                if (DateTime.Now.CompareTo(this.data) > 0 || this.postiPrenotati < postiDaRimuovere){
                    throw new Exception();
                }
                this.postiPrenotati -= postiDaRimuovere;

            }
            catch (Exception e){
                Console.WriteLine("Errore nella disdetta! Assicurati di aver scritto i dati correttamente");
            }

        }

        public override string ToString(){
            return this.data.ToString("dd/mm/yyyy");
        }
    }
}
