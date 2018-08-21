using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1608_EFDatabaseFirst.Controllers
{
    class PersonController
    {
        void Inserir(Person p)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            contexto.Person.Add(p);
            contexto.SaveChanges();
        }

        List<Person> ListarTodosPerson()
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Person.ToList();
        }

        Person BuscarPorID(int id)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
            return contexto.Person.Find(id);
        }

        void Excluir(int id)
        {
            Person pExcluir = BuscarPorID(id);

            if(pExcluir != null)
            {
                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();
                contexto.Person.Remove(pExcluir);
                contexto.SaveChanges();
            }
        }

        void Editar(int id, Person novoDadosPerson)
        {
            Person personAntigo = BuscarPorID(id);

            if(personAntigo != null)
            {
                personAntigo.FirstName = novoDadosPerson.FirstName;
                personAntigo.LastName = novoDadosPerson.LastName;
                personAntigo.Title = novoDadosPerson.Title;

                AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();

                contexto.Entry(personAntigo).State =
                    System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        List<Person> PesquisarPorFirstName(string firstName)
        {
            AdventureWorks2016Entities contexto = new AdventureWorks2016Entities();

            // LINQ (https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b)

            //var lista = from p in contexto.Person
            //            select p; // SELECT * FROM Person

            var lista = from p in contexto.Person
                        where p.FirstName == firstName
                        select p;

            return lista.ToList();
        }
    }
}
