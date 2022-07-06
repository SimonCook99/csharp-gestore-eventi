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
                    if (titolo == null)
                        throw new Exception();
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

                    if (DateTime.Now.CompareTo(this.data) > 0)
                        throw new Exception();
                }
                catch (Exception e){
                    Console.WriteLine("Non puoi inserire una data già trascorsa!");
                }
            }
        }
        public int CapienzaMassima {
            get { return capienzaMassima; }
            private set {
                try{
                    capienzaMassima = value;

                    if (capienzaMassima <= 0)
                        throw new Exception();
                }
                catch (Exception e){
                    Console.WriteLine("La capienza deve essere un numero positivo!");
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
                if (this.capienzaMassima == 0 || DateTime.Now.CompareTo(this.data) > 0 || this.capienzaMassima - this.postiPrenotati <= 0 || this.CapienzaMassima < numeroPosti){
                    throw new Exception();
                }
                this.postiPrenotati += numeroPosti;
                Console.WriteLine("Posti prenotati, hai riservato " + numeroPosti + " posti per te");

            }catch(Exception e){
                Console.WriteLine("Errore nella prenotazione! Assicurati di aver scritto i dati correttamente");
            }
        }

        public int DisdiciPosti(int postiDaRimuovere){
            try{
                if (DateTime.Now.CompareTo(this.data) > 0 || this.postiPrenotati < postiDaRimuovere){
                    throw new Exception();
                }
                this.postiPrenotati -= postiDaRimuovere;
                Console.WriteLine("Disdetta avvenuta con successo!");

                return this.postiPrenotati;

            }
            catch (Exception e){
                Console.WriteLine("Errore nella disdetta! Assicurati di aver scritto i dati correttamente");
                return 0;
            }

        }

        public override string ToString(){
            return this.data.ToString("dd/MM/yyyy") + "- " + this.titolo;
        }
    }
}
