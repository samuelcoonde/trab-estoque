using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabEstoque.Model
{
    public class Produto
    {
        private int _id;
        private String _nome;
        private float _preco;
        private int _quantidade;

        public Produto() { }

        public Produto(string nome, float preco, int quantidade)
        {
            this._nome = nome;
            this. _preco = preco;
            this._quantidade = quantidade;
        }

        // Construtor para exibição
        public Produto(int id, String nome, float preco, int quantidade)
        {
            this._id = id;
            this._nome = nome;
            this._preco = preco;
            this._quantidade = quantidade;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public float Preco
        {
            get { return _preco; }
            set
            {
                if(value > 0)
                {
                    _preco = value;
                }
            }
        }
        
        public int Quantidade
        {
            get { return _quantidade; }
            set
            {
                if(value >= 0)
                {
                    _quantidade = value;
                }
            }
        }
    }
}
