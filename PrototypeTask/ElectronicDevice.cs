using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeTask
{
    public class ElectronicDevice : ICloneableDevice
    {
        private string brand;
        private string model;

        public ElectronicDevice(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }

        public ICloneableDevice Clone()
        {
           
            return new ElectronicDevice(brand, model);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {brand}, Model: {model}");
        }
    }
}
