using DynamicApp.Abstractions;
using DynamicApp.Shared;
using System;
using System.ComponentModel.Composition;

namespace BCRPaymentModule
{
    
    
    public class BCPPayment : IDynamicModule
    {
        
        public string Name { get; set; }
        [Export]
        public string GetName()
        {
            this.Name = "Plugin from Plugin1";

            return this.Name;
        }

        public IMenu GetModuleMenu()
        {
            IMenu retMenu = new MenuItem((parameters)=> 
            { 
                
                Console.WriteLine("BCR PaymentModule Execute"); 
                Console.ReadLine(); 
            }) { DisplayText = Name };

            return retMenu;
        }

        public void InitializeModule(string initializeData)
        {
            //throw new NotImplementedException();
        }
    }
}
