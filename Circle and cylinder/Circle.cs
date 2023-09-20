class Circle{
    private double radius =1.0;
    private string color= "blue";
    public Circle(){

    }
    public Circle(double radius, string color){
        this.radius=radius;
        this.color=color;
    }
    public double GetRadius(){
        return radius;
    }
    public void SetRadius(double radius){
        this.radius = radius;
    }
    public string GetColor(){
        return color;
    }
    public void SetColor(string color){
        this.color = color;
    }
    public double GetArea(){
        return (radius * radius) * Math.PI;
    }
    public override string ToString(){
        return "color = "+GetColor() + " radius = "+GetRadius() +" Area = "+GetArea();
    }
}