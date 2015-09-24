namespace PhoneStoreExample.Handlers
{
    using PhoneStoreExample.Phones;
    using System;

    public class Manager : Handler
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

        public bool CanHandle(MobilePhone mobile)
        {
            return ((mobile.Type == PhoneType.Budget && mobile.Cost >= 200) ||
                    (mobile.Type == PhoneType.Premium && mobile.Cost < 500));
        }
    }
}
