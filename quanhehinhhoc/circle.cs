public class Circle:Shape{
    private double radius = 1.0;
    public Circle(){

    }
    public Circle(double radius){
        this.radius = radius;
    }
    public Circle(double radius,string color,bool filled):base(color,filled){
        this.radius = radius;
    }
    public double GetRadius(){
        return radius;
    }
    public void SetRadius(double radius){
        this.radius = radius;
    }
    public double GetArea(){
        return radius*radius*Math.PI;
    }
    public double GetPerimeter(){
        return 2*radius*Math.PI;
    }
    public override string ToString(){
        return "a Circle with radius  = "
        +GetRadius()
        +" wich is a subclass of "
        +base.ToString();
    }
}