class Cylinder : Circle{
    private double length = 2;
    public Cylinder(){

    }
    public Cylinder(double length){
        this.length = length;
    }
    public Cylinder(double length,double radius,string color):base(radius,color){
        this.length = length;
    }
    public double GetLength(){
        return length;
    }
    public void SetLength(double length){
        this.length=length;
    }
    public double volume(){
        return length*Math.PI*GetRadius();
    }
    public override string ToString(){
        return "A CyLinder length = "
        +GetLength()
        +volume() 
        +base.ToString();
    }
}