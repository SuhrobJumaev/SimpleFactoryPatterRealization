using FitnessClub.Entity;

namespace FitnessClub.Factories;

public abstract class MembershipFactory 
{
    public abstract IMembership GetMembership();
}