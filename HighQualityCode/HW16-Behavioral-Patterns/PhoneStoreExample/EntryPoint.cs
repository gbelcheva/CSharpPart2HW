namespace PhoneStoreExample
{
    using PhoneStoreExample.Contracts;
    using PhoneStoreExample.Handlers;
    using PhoneStoreExample.Phones;
    using PhoneStoreExample.Specifications;
    using System.Collections.Generic;

    public class EntryPoint
    {
        public static void Main(string[] args)
        {
            List<MobilePhone> phones = new List<MobilePhone> { 
                new MobilePhone(PhoneType.Premium, 450), 
                new MobilePhone(PhoneType.Premium, 800), 
                new MobilePhone(PhoneType.Basic, 100), 
                new MobilePhone(PhoneType.Budget, 160),
                new MobilePhone(PhoneType.Premium, 800) ,
                new MobilePhone(PhoneType.Budget, 250),
                new MobilePhone(PhoneType.Budget, 1)
            };

            ISpecification<MobilePhone> basicSpec = new Specification<MobilePhone>(o => o.Type == PhoneType.Basic);
            ISpecification<MobilePhone> budgetSpec = new Specification<MobilePhone>(o => o.Type == PhoneType.Budget);
            ISpecification<MobilePhone> premiumSpec = new Specification<MobilePhone>(o => (o.Type == PhoneType.Premium));


            ISpecification<MobilePhone> budgetLowCostSpec = new Specification<MobilePhone>(o => o.Cost < 200 && o.Cost >= 100);
            ISpecification<MobilePhone> budgetHighCostSpec = new Specification<MobilePhone>(o => (o.Cost >= 200));
            ISpecification<MobilePhone> premiumLowCostSpec = new Specification<MobilePhone>(o => (o.Cost < 500));
            ISpecification<MobilePhone> premiumHighCostSpec = new Specification<MobilePhone>(o => (o.Cost >= 500));
            var invProcess = new InventoryProcess<MobilePhone>();

            IHandler<MobilePhone> seniorManager = new Approver<MobilePhone>("SeniorManager", invProcess.placeOrder);
            IHandler<MobilePhone> manager = new Approver<MobilePhone>("Manager", invProcess.placeOrder);
            IHandler<MobilePhone> supervisor = new Approver<MobilePhone>("Supervisor", invProcess.placeOrder);
            IHandler<MobilePhone> employee = new Approver<MobilePhone>("Employee", invProcess.placeOrder);


            employee.SetSpecification(basicSpec);
            supervisor.SetSpecification(basicSpec);
            manager.SetSpecification(budgetSpec.And<MobilePhone>(budgetHighCostSpec).Or<MobilePhone>(premiumSpec.And<MobilePhone>(premiumLowCostSpec)));
            seniorManager.SetSpecification(premiumSpec.And<MobilePhone>(premiumHighCostSpec));

            employee.SetSuccessor(supervisor);
            supervisor.SetSuccessor(manager);
            manager.SetSuccessor(seniorManager);

            IHandler<MobilePhone> defaultApprover = new Approver<MobilePhone>("Default", invProcess.defaultOrder);
            ISpecification<MobilePhone> defaultSpec = new Specification<MobilePhone>(o => true);
            defaultApprover.SetSpecification(defaultSpec);
            seniorManager.SetSuccessor(defaultApprover);

            phones.ForEach(o => employee.HandleRequest(o));
        
        }
    }
}
