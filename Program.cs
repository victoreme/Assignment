
using System;
using System.Collections.Generic;

public class PetAdoptionAgency
{
    // Members of the Pet Adoption Agency class

    // 1. Adoption Coordinator
    public class AdoptionCoordinator
    {
        public string Name { get; set; }
        public int YearsOfExperience { get; set; }

        public void CoordinateAdoptionProcess()
        {
            Console.WriteLine($"{Name} is coordinating the adoption process.");
        }
    }

    // 2. Veterinarian
    public class Veterinarian
    {
        public string Name { get; set; }
        public string Specialization { get; set; }

        public void PerformHealthCheckup()
        {
            Console.WriteLine($"{Name} is performing a health checkup on the pets.");
        }
    }

    // 3. PetOwner
    public class PetOwner
    {
        public string Name { get; set; }
        public List<string> OwnedPets { get; set; }

        public void AdoptPet(string petName)
        {
            OwnedPets.Add(petName);
            Console.WriteLine($"{Name} has adopted a new pet named {petName}.");
        }
    }

    // 4. Pet
    public class Pet
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }

        public void DisplayPetInfo()
        {
            Console.WriteLine($"Name: {Name}, Breed: {Breed}, Age: {Age} years");
        }
    }
}

class Program
{
    static void Main()
    {
        // Example usage of the Pet Adoption Agency class

        // Create an Adoption Coordinator
        var adoptionCoordinator = new PetAdoptionAgency.AdoptionCoordinator
        {
            Name = "Ope",
            YearsOfExperience = 3
        };

        // Create a Veterinarian
        var veterinarian = new PetAdoptionAgency.Veterinarian
        {
            Name = "Dr. Aproko",
            Specialization = "General Medicine"
        };

        // Create a PetOwner
        var petOwner = new PetAdoptionAgency.PetOwner
        {
            Name = "Esther",
            OwnedPets = new List<string>()
        };

        // Create a Pet
        var pet = new PetAdoptionAgency.Pet
        {
            Name = "Bankai",
            Breed = "German shepard",
            Age = 2
        };

        // Perform actions within the Pet Adoption Agency
        adoptionCoordinator.CoordinateAdoptionProcess();
        veterinarian.PerformHealthCheckup();
        petOwner.AdoptPet(pet.Name);

        // Display information about the adopted pet
        pet.DisplayPetInfo();
    }
}

