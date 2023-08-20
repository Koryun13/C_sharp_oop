namespace Packt.Shared;

public partial class Person
{
    public string Origin
    {
        get
        {
            return $"{name} was born on {HomePlanet}";
        }
    }

    public string FavoriteIceCream {get; set;}
    
    public string Greeting => $"{name} says hello!";
    public int Age => System.DateTime.Today.Year - DateofBirth.Year;

    private string favoritePrimaryColor;

    public string FavoritePrimaryColor
    {
        get
        {
            return favoritePrimaryColor;
        }
        
        set
        {
            switch (value.ToLower())
            {
                case "red":
                case "green":
                case "blue":
                favoritePrimaryColor = value;
                break;
                default:
                throw new System.ArgumentOutOfRangeException($"{value} is not a primart color" + " Choose from: red, green, blue");


            }
        }
    }


     public Person this[int index]
            {
                get
                {
                    return Children[index];
        
                }
                set
                {
                    Children[index] = value;
                }
            }

}

           
        
    

    
