using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class DatingProspect : Contact
{
    private string _mutualInterests;
    private string _interestLevel;
    private List<(string, DateTime)> _history;
    private bool _stillTalking;

    // Constructor
    public DatingProspect(PersonInfo personContact, string mutualInterests, string interestLevel, bool stillTalking)
        : base(personContact)
    {
        _mutualInterests = mutualInterests;
        _interestLevel = interestLevel;
        _stillTalking = stillTalking;
        _history = new List<(string, DateTime)>();
    }

    // Edit DatingProspect-specific details
    public void EditDatingDetails(string mutualInterests, string interestLevel, bool stillTalking)
    {
        Console.WriteLine(_mutualInterests);
        Console.WriteLine(_interestLevel);
        _mutualInterests = mutualInterests;
        _interestLevel = interestLevel;
        _stillTalking = stillTalking;
    }

    public override string GetContactDetails()
    {
        string historyStr = _history.Count > 0 ? string.Join("\n", _history.ConvertAll(h => $"- {h.Item1} ({h.Item2.ToShortDateString()})")) : "None";

        return base.GetContactDetails() +
               $"\nMutual Interests: {_mutualInterests}" +
               $"\nInterest Level: {_interestLevel}" +
               $"\nStill Talking: {_stillTalking}" +
               $"\nInteraction History:\n{historyStr}";
    }
}