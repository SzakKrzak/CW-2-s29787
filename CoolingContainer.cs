namespace cw2;

class CoolingContainer:Container
{
    private Cargo typeOfProduct;
    private int temperature;
    
    public CoolingContainer(int maximumCargoWeight, int height, int weight, int depth, ContainerType type, int typeCount,Cargo typeOfProduct,int temperature) 
        : base(maximumCargoWeight, height, weight, depth, type, typeCount)
    {
        this.typeOfProduct = typeOfProduct;
        this.temperature = temperature;
        if (this.temperature < typeOfProduct.temperature)
        {
            throw new Exception("Container temperature is too low for this product");
        }
    }
}