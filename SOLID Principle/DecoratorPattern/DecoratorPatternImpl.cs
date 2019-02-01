using System;

namespace DecoratorPattern
{
    public interface ICar
    {
       ICar ManufactureCar();
    }
    public class BMWCar : ICar
    {
        public string Wheel { get; set; }
        public string Door { get; set; }
        public string Color { get; set; }
        public string Glasses { get; set; }
        public string Engine { get; set; }
        public ICar ManufactureCar()
        {
            this.Wheel = "4 Wheel";
            this.Door = "4 Door";
            this.Color = "Gray";
            this.Glasses = "6 Glasses";
            return this;
        }
    }
    public abstract class CarDecorator : ICar
    {
        protected ICar _car;
        public CarDecorator(ICar car)
        {
            this._car = car;
        }
        public ICar ManufactureCar()
        {
            return _car.ManufactureCar();
        }
    }
    public class PatrolEngineDecorator : CarDecorator
    {
        public PatrolEngineDecorator(ICar car) : base(car)
        {           
        }
        public ICar  ManufactureCar()
        {
            base.ManufactureCar();
            addEngine(_car);
            return _car;
        }
        private void addEngine(ICar _car)
        {
            BMWCar car = (BMWCar)_car;
            car.Engine = "Patrol engine";
            Console.WriteLine("Patrol engine added.");
        }
    }
}
