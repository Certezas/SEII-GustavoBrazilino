//Create Read Update Delete
//CRUD
//Create
string petFish = "pufferfish";

//Concatenation
petFish = "porcupine" + petFish;

//Template Literal
Console.WriteLine($"I AM BUYING {petFish}. YOU CANNOT STOP ME!!!");

Console.WriteLine(petFish);


//Read
//Console.WriteLine()


//Update
//petFish[0] = "P";
string newPetFish = petFish.Replace("porcupine", "bluedot");
Console.WriteLine(newPetFish);


//Delete
//String Builder
StringBuilder newCrustacean = new StringBuilder();
newCrustacean.Append("fiddler crab");
Console.WriteLine(newCrustacean);
newCrustacean.Remove(0, 8);
Console.WriteLine(newCrustacean);
