using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pessoa;

public class Pessoa
{
    public int Id;
    public string Nome;
    public string Telefone;

    public Pessoa(int id, string nome, string telefone)
    {
        Id = id;
        Nome = nome;
        Telefone = telefone;
    }

    public int getid()
    {
        return Id;
    }

    public void setid(int id)
    {
        if (id > 0)
        {
            Id = id;
        }

    }

    public string getNome()
    {
        return Nome;
    }

    public void setNome(string nome)
    {
        Nome = nome;
    }

    public string getTelefone()
    {
        return Telefone;
    }

    public void setTelefone(string telefone)
    {
        Telefone = telefone;
    }

}
