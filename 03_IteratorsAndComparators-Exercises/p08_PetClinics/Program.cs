using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Pet> pets = new List<Pet>();
        List<PetClinic> petClinics = new List<PetClinic>();
        int numberOfCommands = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCommands; i++)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string command = input[0];

            switch (command)
            {
                case "Create":
                    try
                    {
                        string typeOfCreation = input[1];
                        if (typeOfCreation == "Pet")
                        {
                            int age = int.Parse(input[3]);
                            Pet pet = new Pet(input[2], age, input[4]);
                            pets.Add(pet);
                        }
                        else if (typeOfCreation == "Clinic")
                        {
                            int roomCount = int.Parse(input[3]);
                            PetClinic petClinic = new PetClinic(input[2], roomCount);
                            petClinics.Add(petClinic);
                        }
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "Add":
                    Pet petToAdd = pets.FirstOrDefault(p => p.Name == input[1]);
                    PetClinic clinic = petClinics.FirstOrDefault(p => p.Name == input[2]);
                    Console.WriteLine(clinic.Add(petToAdd));
                    break;
                case "Release":
                    PetClinic clinicToRelease = petClinics.FirstOrDefault(p => p.Name == input[1]);
                    Console.WriteLine(clinicToRelease.Release());
                    break;
                case "HasEmptyRooms":
                    PetClinic clinicEmpty = petClinics.FirstOrDefault(p => p.Name == input[1]);
                    Console.WriteLine(clinicEmpty.HasEmptyRooms);
                    break;
                case "Print":
                    PetClinic clinicToPrint = petClinics.FirstOrDefault(p => p.Name == input[1]);
                    if (input.Length == 3)
                    {
                        int roomNumber = int.Parse(input[2]);
                        Console.WriteLine(clinicToPrint.Print(roomNumber));
                    }
                    else
                    {
                        Console.WriteLine(clinicToPrint.Print());
                    }
                    break;
            }
        }
    }
}