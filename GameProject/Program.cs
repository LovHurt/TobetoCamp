namespace GameProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer{Id = 1, BirthYear = 1997, FirstName = "ALİCAN", LastName = "DAĞIDIR", IdentityNumber = 12345});
            Console.WriteLine("Hello, World!");

            ICampaignService campaignManager = new CampaignManager();
            campaignManager.Update();

            ICampaignService campaignManager2 = new CampaignManager();
            OrderManager orderManager = new OrderManager();
            orderManager.Remove(campaignManager2);

            ICampaignService campaignManager3 = new CampaignManager();
            OrderManager orderManager2 = new OrderManager();
            orderManager2.Add(campaignManager3);
        }
    }
}