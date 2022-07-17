Animal animal = new Animal{name = "Dick", kind = "Dog",age = 12, owner_name = "Taras"};
animal.print();
class Animal
{
    public string name, kind, owner_name;
    public int age;

    public void print()
    {
        Console.writeLine($"Information about animal.\n Owner name:{owner_name}\n Name:{name}\n Animal kind:{kind}\n Animal age:{age}\n");
    }
}

