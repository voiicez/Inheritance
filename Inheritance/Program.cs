Student std = new Student()
{
    Department = "Yazılım"
};



//inheritance-kalıtım,miras

abstract class Person //base,parent,(abstract:soyut)
{
    public int Id {get;set;}
    public string Name {get;set;}
    public string Surname {get;set;}
    
    //string AdSoyadYazdir(); interface örneği
    public string AdSoyadYazdir()
    {
        return Name + " " + Surname;
    }
}

class Customer : Person
{
    public string KartNo {get;set;}
    
    //public string AdSoyadYazdir() Interface
    //{
    //    return Name + " " + Surname;
    //}
}
class Student : Person
{
    public string Department {get;set;}
    
    //public string AdSoyadYazdir() Interface
    //{
    //    return Name + " " + Surname;
    //}
}