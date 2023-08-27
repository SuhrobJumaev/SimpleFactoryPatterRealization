namespace FitnessClub.Entity;

public interface IMembership
{
    string Name { get; }
    string Description { get; set; }
    decimal GetPrice();
}