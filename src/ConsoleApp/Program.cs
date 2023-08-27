using FitnessClub.Entity;
using FitnessClub.Factories;


System.Console.WriteLine(">>> Welcome to FitnessClub CRM<<<");

System.Console.WriteLine("> Enter the membership type you would like to create: ");

System.Console.WriteLine("> G - Gym");
System.Console.WriteLine("> P - Gym + Pool");
System.Console.WriteLine("> T - Personal Training");

string membershipType = Console.ReadLine();

MembershipFactory factory = GetFactory(membershipType);

IMembership membership = factory.GetMembership();

System.Console.WriteLine("\n> Membership you've just created: \n");

System.Console.WriteLine(
    $"\tName:\t\t{membership.Name}\n" +
    $"\tDescription:\t{membership.Description}\n" +
    $"\tPrice:\t\t{membership.GetPrice()}"
);

MembershipFactory GetFactory(string membershipType)
{
    switch (membershipType.ToLower())
    {
        case "g": 
            return new GymMembershipFactory(100, "Basic membership");
       case "p": 
            return new GymPlusPoolMembershipFactory(250, "Good price membership");
        case "t" : 
            return new PersonalTrainingMembershipFactory(400, "Best for professionals");
        default: 
            return null;
    }
}