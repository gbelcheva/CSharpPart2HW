public class Chef
{
    public void Cook()
    {
        Bowl bowl = this.GetBowl();
        Potato potato = this.GetPotato();
        Carrot carrot = this.GetCarrot();

        Peel(potato);
        Peel(carrot);

        this.Cut(potato);
        this.Cut(carrot);

        bowl.Add(carrot);
        bowl.Add(potato);
    }

    private Bowl GetBowl()
    {
        //... 
    }

    private Potato GetPotato()
    {
        //...
    }

    private Carrot GetCarrot()
    {
        //...
    }

    private void Cut(Vegetable vegetable)
    {
        //...
    }

}