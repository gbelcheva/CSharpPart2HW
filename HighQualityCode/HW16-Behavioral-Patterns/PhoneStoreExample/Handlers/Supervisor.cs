namespace PhoneStoreExample.Handlers
{
    using PhoneStoreExample.Phones;
    using System;

    public class Supervisor : Handler
    {
        public override void HandleRequest(MobilePhone phone)
        {
            if (CanHandle(phone))
            {
                Console.WriteLine("{0} handled request {1}",
                  this.GetType().Name, phone.Type);
            }
            else if (successor != null)
            {
                successor.HandleRequest(phone);
            }
        }
        public bool CanHandle(MobilePhone phone)
        {
            return (phone.Type == PhoneType.Budget);
        }
    }
}
