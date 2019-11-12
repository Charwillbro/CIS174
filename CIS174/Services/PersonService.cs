using CIS174.Entities;
using CIS174.Models;
using System;
using System.Linq;

namespace CIS174.Services
{
    public class PersonService
    {
        private readonly PersonAccomplishmentContext _personAccomplishmentContext;
        public PersonService(PersonAccomplishmentContext demoContext)
        {
            _personAccomplishmentContext = demoContext;
        }

        public bool DoesPersonExist(int id)
        {
            return _personAccomplishmentContext.People.Any(e => e.Id == id);
        }

        public PersonDetailViewModel GetPersonDetail(int id)
        {
            var person = _personAccomplishmentContext.People
                                     .Where(x => x.Id == id)
                                     .Select(x => new PersonDetailViewModel
                                     {
                                         Id = x.Id,
                                         FirstName = x.FirstName,
                                         LastName = x.LastName,
                                         Birthdate = x.Birthdate,
                                         City = x.City,
                                         State = x.State
                                     })
                                     .SingleOrDefault();
            return person;
        }

        public void UpdatePerson(int id, UpdatePersonCommand command)
        {
            var person = _personAccomplishmentContext.People.Find(id);
            if (person == null)
            {
                throw new Exception("Unable to find person");
            }

            person.FirstName = command.FirstName;
            person.LastName = command.LastName;
            person.Birthdate = command.Birthdate;
            person.City = command.City;
            person.State = command.State;

            _personAccomplishmentContext.SaveChanges();
        }

        public int CreatePerson(CreatePersonCommand cmd)
        {
            var person = new Person
            {
                FirstName = cmd.FirstName,
                LastName = cmd.LastName,
                Birthdate = cmd.Birthdate,
                City = cmd.City,
                State = cmd.State,
               // Accomplishments = cmd.Accomplishments?.Select(i => new Accomplishment
               // {
               //     Name = i.Name,
                //    DateOfAccomplishment = i.DateOfAccomplishment,
               // }).ToList()
            };
            _personAccomplishmentContext.Add(person);
            _personAccomplishmentContext.SaveChanges();

            return person.Id;
        }


        public void DeletePerson(int personId)
        {
            var person = _personAccomplishmentContext.People.Find(personId);
            _personAccomplishmentContext.Remove(person);
            _personAccomplishmentContext.SaveChanges();
        }
    }
}
