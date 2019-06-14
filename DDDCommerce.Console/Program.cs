using DDDEvents.Domain.Events.Entities;
using DDDEvents.Domain.Events.Repositories;
using DDDEvents.Domain.Events.ValueObjects;
using DDDEvents.Infra.Contexts;
using DDDEvents.Infra.Repositories;
using System;
using System.Collections.Generic;

namespace DDDEvents.Console
{
    public class Program
    {
        static void Main(string[] args)
        {

            DDDEvents_EventsDataContext context = new DDDEvents_EventsDataContext();

            UserRepository userRepository = new UserRepository(context);
            GenerateUser(userRepository);

            var fakeBudgetRepository = new FakeBudgeRepository();
            var fakeEventRepository = new FakeEventRepository();
            var fakeUserRepository = new FakeUserRepository();


            var event1 = new Dictionary<Guid, int> { { Guid.NewGuid(), 1 } };
            var event2 = new Dictionary<Guid, int> { { Guid.NewGuid(), 2 } };

            var budget1 = new Dictionary<Guid, int> { { Guid.NewGuid(), 3 } };

            var selectedEvents = new List<Dictionary<Guid, int>> { event1, event2 };

        }

        public static void GenerateEvent(
            IBudgetRepository budgetRepository,
            IEventRepository eventRepository,
            IUserRepository userRepository,
            List<Dictionary<Guid, int>> eventGuids,
            Guid userId)
        {
            var user = userRepository.GetById(userId);
            var events = new Event(user);
            var budgets = new Budget(user);

            foreach (var eventGuid in eventGuids)
            {
                var budget = budgetRepository.Get(eventGuid.First().Key);
                var eventItem = new Budget(budget, eventGuid.First().Value);
                events.AddItem(budget);
            }
        }

        public static void GenerateUser(IUserRepository userRepository)
        {
            var name = new Name("Asdrubal", "de souza");

            var user = new User(name, "123456789", new Email("teste@teste.com"), "01415996686666");
            userRepository.Save(user);
        }
}

public class FakeEventRepository : IEventRepository
{
    public Event Get(Guid id)
    {
        var fakeEvent = new Event
        (
            "Semana de TI",
            new EventDate("DATA INICIO", "DATA FIM"),
            new Address("1111-111", "Rua dos bobos", "0", "Marilia", "SP")
        );
);
        return fakeEvent;
    }

    public IList<Event> GetEvents(List<Guid> ids)
    {
        throw new NotImplementedException();
    }
}

public class FakeBudgeRepository : IBudgetRepository
{
    public Budget Get(Guid id)
    {
        var fakeBudget = new Budget
        (
            1000,
            300,
            300
        );
        return fakeBudget;
    }

    public IList<Budget> GetBudgets(List<Guid> ids)
    {
        throw new NotImplementedException();
    }
}

public class FakeUserRepository : IUserRepository
{

    //Vamos criar um Customer Fake para fazermos testes
    public User GetById(Guid id)
    {
        var fakeUser = new User
        (
            new Name("Fabio", "Navarro"),
            "123456789",
            new Email("navarro@univem.edu.br"),
            "996691122"
        );
        return fakeUser;
    }

    public void Save(User user)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> GetUsers()
    {
        throw new NotImplementedException();
    }
}