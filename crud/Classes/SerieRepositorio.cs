using crud.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace crud.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        //meu banco de dados ficticio 
        private List<Serie> listaSerie = new List<Serie>();

        public void Atualiza(int id, Serie serie)
        {
            listaSerie[id] = serie;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Exclui();
        }

        public void Insere(Serie serie)
        {
            listaSerie.Add(serie);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RepornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}
