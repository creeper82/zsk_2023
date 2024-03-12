using Classes;

Food f1 = new("Jabłko", 300);
Dog dog = new("pudel", "Czips", "idk species", 12);
Animal dogAsAnimal = new Dog("pudel", "Czips(animal)", "idk species", 12);

dog.AnimalSoundEvent +=
    n => { Console.WriteLine($"dog named {n} made sound."); };

dogAsAnimal.AnimalSoundEvent +=
    n => { Console.WriteLine($"dog casted to animal, named {n} made sound."); };

f1.PrintInfo();
dog.PrintInfo();
dog.MakeSound();
dogAsAnimal.PrintInfo();
dogAsAnimal.MakeSound();